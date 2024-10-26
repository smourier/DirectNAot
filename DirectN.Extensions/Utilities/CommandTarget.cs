namespace DirectN.Extensions.Utilities;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public sealed partial class CommandTarget : IOleCommandTarget, IDisposable
{
    private uint _cookie;
    public const string Delimiter = "!";

    public event EventHandler<CommandTargetEventArgs>? Command;

    public CommandTarget(string moniker, Guid groupId)
    {
        ArgumentNullException.ThrowIfNull(moniker);
        Moniker = moniker;
        GroupId = groupId;
    }

    public string Moniker { get; }
    public Guid GroupId { get; }

    public void Register() => RunningObjectTable.Register(this, out _cookie);
    public void Revoke()
    {
        var cookie = Interlocked.Exchange(ref _cookie, 0);
        if (cookie != 0)
        {
            RunningObjectTable.Revoke(cookie);
        }
    }

    public void Dispose() => Revoke();

    // targetPid = 0 => first
    // targetPid = -1 => all
    // targetPid = X => process id X
    public static IEnumerable<CommandResult> TryExec(int targetPid, string moniker, Guid commandGroup, uint commandId, object? input)
    {
        ArgumentNullException.ThrowIfNull(moniker);
        foreach (var unk in GetObjects(targetPid, moniker))
        {
            using var target = ComObject.FromPointer<IOleCommandTarget>(unk);
            if (target is null)
                continue;

            var result = getResult();
            if (result is not null)
                yield return result;

            CommandResult? getResult()
            {
                try
                {
                    return TryExec(target.Object, commandGroup, commandId, input);
                }
                catch
                {
                    return null;
                }
            }
        }
    }

    public static CommandResult TryExec(IComObject<IOleCommandTarget> target, Guid commandGroup, uint commandId, object? input) => TryExec(target?.Object!, commandGroup, commandId, input);
    public static CommandResult TryExec(IOleCommandTarget target, Guid commandGroup, uint commandId, object? input)
    {
        ArgumentNullException.ThrowIfNull(target);
        using var vi = new Variant(input);
        var vo = new VARIANT();
        var hr = target.Exec(commandGroup, commandId, 0, vi.Detached, ref vo);
        if (hr.IsError)
            return new CommandResult(hr, null);

        return new CommandResult(hr, Variant.Unwrap(vo));
    }

    private static IEnumerable<nint> GetObjects(int targetPid, string moniker)
    {
        if (targetPid > 0)
        {
            var unk = RunningObjectTable.GetObject(moniker + ":" + targetPid, throwOnError: false);
            if (unk != 0)
                yield return unk;

            yield break;
        }

        Functions.CreateBindCtx(0, out var ctx);
        if (ctx == null)
            yield break;

        foreach (var mk in RunningObjectTable.Enumerate(false))
        {
            var name = getName();
            if (name == null)
                continue;

            if (name.StartsWith(Delimiter + moniker))
            {
                var remoteUnk = RunningObjectTable.GetObject(mk, false);
                if (remoteUnk != 0)
                {
                    yield return remoteUnk;
                    if (targetPid == 0)
                        break;
                }
            }

            string? getName()
            {
                try
                {
                    mk.GetDisplayName(ctx, null!, out var dn);
                    return dn.ToString();
                }
                catch
                {
                    return null;
                }
            }
        }
    }

    HRESULT IOleCommandTarget.QueryStatus(in Guid pguidCmdGroup, uint cCmds, ref OLECMD prgCmds, ref OLECMDTEXT pCmdText) => Constants.E_NOTIMPL;
    HRESULT IOleCommandTarget.Exec(in Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, in VARIANT pvaIn, ref VARIANT pvaOut)
    {
        var e = new CommandTargetEventArgs(pguidCmdGroup, nCmdID, Variant.Unwrap(pvaIn));
        Command?.Invoke(this, e);

        if (e._outputSet)
        {
            var vo = new Variant(e.Output);
            pvaOut = vo.Detached;
        }
        return e.HResult;
    }
}
