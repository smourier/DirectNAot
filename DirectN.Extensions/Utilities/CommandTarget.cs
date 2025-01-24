namespace DirectN.Extensions.Utilities;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class CommandTarget : IOleCommandTarget, IConnectionPointContainer, IDisposable
{
    private readonly ConcurrentDictionary<Guid, IConnectionPoint> _connectionPoints = new();
    private uint _cookie;
    public const string Delimiter = "!";

    public event EventHandler<CommandTargetEventArgs>? Command;

    public CommandTarget(string moniker)
    {
        ArgumentNullException.ThrowIfNull(moniker);
        Moniker = moniker;
    }

    public string Moniker { get; }

    public virtual void Register() => RunningObjectTable.Register(this, out _cookie);
    public virtual void Revoke()
    {
        var cookie = Interlocked.Exchange(ref _cookie, 0);
        if (cookie != 0)
        {
            RunningObjectTable.Revoke(cookie);
        }
    }

    public virtual void AddConnectionPoint(IConnectionPoint connectionPoint)
    {
        ArgumentNullException.ThrowIfNull(connectionPoint);
        if (connectionPoint is CommandTargetConnectionPoint target)
        {
            if (target._container != null)
                throw new ArgumentException("Connection point already has a container", nameof(connectionPoint));

            target._container = this;
        }

        connectionPoint.GetConnectionInterface(out var iid).ThrowOnError();
        if (!_connectionPoints.TryAdd(iid, connectionPoint))
            throw new ArgumentException($"Connection point with iid {iid} is already registered", nameof(connectionPoint));
    }

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

    HRESULT IConnectionPointContainer.EnumConnectionPoints(out IEnumConnectionPoints enumerator)
    {
        enumerator = new ConnectionsPoints([.. _connectionPoints]);
        return Constants.S_OK;
    }

    HRESULT IConnectionPointContainer.FindConnectionPoint(in Guid riid, out IConnectionPoint icp)
    {
        _connectionPoints.TryGetValue(riid, out var cp);
        icp = cp!;
        return cp == null ? Constants.CONNECT_E_NOCONNECTION : Constants.S_OK;
    }

    [System.Runtime.InteropServices.Marshalling.GeneratedComClass]
    private sealed partial class ConnectionsPoints(KeyValuePair<Guid, IConnectionPoint>[] connections) : IEnumConnectionPoints
    {
        private int _index = -1;

        public HRESULT Clone(out IEnumConnectionPoints enumerator)
        {
            enumerator = new ConnectionsPoints(connections);
            return Constants.S_OK;
        }

        public HRESULT Next(uint count, IConnectionPoint[] points, out uint fetched)
        {
            var max = (uint)Math.Max(0, Math.Min(connections.Length - (_index + 1), count));
            fetched = max;
            if (fetched > 0)
            {
                for (var i = _index + 1; i < fetched; i++)
                {
                    points[i] = connections[i].Value;
                    _index++;
                }
            }
            return (fetched == count) ? Constants.S_OK : Constants.S_FALSE;
        }

        public HRESULT Reset() => _index = -1;
        public HRESULT Skip(uint count)
        {
            var max = (uint)Math.Max(0, Math.Min(connections.Length - (_index + 1), count));
            if (max > 0)
            {
                _index += (int)max;
            }
            return (max == count) ? Constants.S_OK : Constants.S_FALSE;
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            Revoke();
            // dispose managed state (managed objects)
        }

        // free unmanaged resources (unmanaged objects) and override finalizer
        // set large fields to null
    }

    ~CommandTarget() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
}
