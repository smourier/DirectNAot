namespace DirectN.Extensions.Utilities;

public partial class SingleInstance(Guid groupId)
{
    public event EventHandler<SingleInstanceCommandEventArgs>? Command;

    private const int _wellKnownArgs = 5;
    private CommandTarget? _commandTarget;

    public Guid GroupId { get; } = groupId;
    public CommandTarget? CommandTarget => _commandTarget;

    public override string ToString() => $"{GroupId}";

    // well-known commands
    public IEnumerable<CommandResult> SendCommandLine(Guid? desktopId = null, int targetPid = 0, IEnumerable<string?>? arguments = null) => Send(desktopId, targetPid, SingleInstanceCommandType.SendCommandLine, arguments?.ToArray());
    public IEnumerable<CommandResult> Quit(Guid? desktopId = null, int targetPid = -1) => Send(desktopId, targetPid, SingleInstanceCommandType.Quit);
    public IEnumerable<CommandResult> FailFast(Guid? desktopId = null, int targetPid = -1) => Send(desktopId, targetPid, SingleInstanceCommandType.FailFast);
    public IEnumerable<CommandResult> Ping(Guid? desktopId = null, int targetPid = -1) => Send(desktopId, targetPid, SingleInstanceCommandType.Ping);
    public IEnumerable<CommandResult> Send(Guid? desktopId, int targetPid, SingleInstanceCommandType type, params object?[]? arguments) => Send(desktopId, targetPid, (uint)type, arguments);
    public virtual IEnumerable<CommandResult> Send(Guid? desktopId, int targetPid, uint type, params object?[]? arguments)
    {
        var ct = _commandTarget;
        if (ct == null)
            return [];

        var input = new List<object?>();
        AddWellKnownArguments(desktopId, input);
        if (input.Count != _wellKnownArgs)
            throw new InvalidOperationException();

        if (arguments != null && arguments.Length > 0)
        {
            input.AddRange(arguments!);
        }

        return CommandTarget.TryExec(targetPid, ct.Moniker, GroupId, type, input.ToArray());
    }

    public virtual void AllowSetForegroundWindow(Guid desktopId)
    {
        foreach (var result in Ping(desktopId))
        {
            if (result.HResult.IsOk &&
                Conversions.TryChangeType<uint>(result.Output, out var pid)
                && pid > 0)
            {
                Functions.AllowSetForegroundWindow(pid);
            }
        }
    }

    public virtual void UnregisterCommandTarget() => Interlocked.Exchange(ref _commandTarget, null)?.Dispose();
    public virtual void RegisterCommandTarget(string? moniker = null)
    {
        UnregisterCommandTarget();
        moniker ??= typeof(SingleInstance).FullName!;
        _commandTarget = new CommandTarget(moniker);
        _commandTarget.Command += OnCommand;
        _commandTarget.Register();
    }

    public virtual void WithCommandTarget(Action<CommandTarget> action, string? moniker = null)
    {
        ArgumentNullException.ThrowIfNull(action);
        RegisterCommandTarget(moniker);
        try
        {
            action(CommandTarget!);
        }
        finally
        {
            UnregisterCommandTarget();
        }
    }

    public virtual async Task WithCommandTarget(Func<CommandTarget, Task> action, string? moniker = null)
    {
        ArgumentNullException.ThrowIfNull(action);
        RegisterCommandTarget(moniker);
        try
        {
            await action(CommandTarget!);
        }
        finally
        {
            UnregisterCommandTarget();
        }
    }

    public virtual T WithCommandTarget<T>(Func<CommandTarget, T> action, string? moniker = null)
    {
        ArgumentNullException.ThrowIfNull(action);
        RegisterCommandTarget(moniker);
        try
        {
            return action(CommandTarget!);
        }
        finally
        {
            UnregisterCommandTarget();
        }
    }

    public virtual async Task<T> WithCommandTarget<T>(Func<CommandTarget, Task<T>> action, string? moniker = null)
    {
        ArgumentNullException.ThrowIfNull(action);
        RegisterCommandTarget(moniker);
        try
        {
            return await action(CommandTarget!);
        }
        finally
        {
            UnregisterCommandTarget();
        }
    }

    public static CommandResult Send(IComObject<IOleCommandTarget> target, Guid commandGroupId, uint commandId, Guid? desktopId = null, params object?[]? arguments) => Send(target?.Object!, commandGroupId, commandId, desktopId, arguments);
    public static CommandResult Send(IOleCommandTarget target, Guid commandGroupId, uint commandId, Guid? desktopId = null, params object?[]? arguments)
    {
        ArgumentNullException.ThrowIfNull(target);
        var input = new List<object?>();
        AddWellKnownArguments(desktopId, input);
        if (input.Count != _wellKnownArgs)
            throw new InvalidOperationException();

        if (arguments != null && arguments.Length > 0)
        {
            input.AddRange(arguments!);
        }

        return CommandTarget.TryExec(target, commandGroupId, commandId, input.ToArray());
    }

    protected static void AddWellKnownArguments(Guid? desktopId, IList<object?> list)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.Add(SystemUtilities.CurrentProcess.Id);
        list.Add(Environment.CurrentDirectory);
        list.Add(Environment.UserDomainName);
        list.Add(Environment.UserName);
        list.Add((desktopId ?? Guid.Empty).ToString("N"));
    }

    private sealed class SingleInstanceCommand
    {
        public required int ProcessId;
        public required string CurrentDirectory;
        public required string UserDomainName;
        public required string UserName;
        public required Guid DesktopId;
        public required object[] Arguments;

        public static SingleInstanceCommand? Parse(CommandTargetEventArgs e)
        {
            if (e.Input is not object[] args || args.Length < _wellKnownArgs)
                return null;

            if (!int.TryParse(string.Format("{0}", args[0]), out var processId))
                return null;

            if (args[1] is not string currentDirectory)
                return null;

            if (args[2] is not string userDomainName)
                return null;

            if (args[3] is not string userName)
                return null;

            if (args[4] is not string did || !Guid.TryParse(did, out var desktopId))
                return null;

            args = args.Skip(_wellKnownArgs).ToArray();
            return new SingleInstanceCommand
            {
                ProcessId = processId,
                CurrentDirectory = currentDirectory,
                UserDomainName = userDomainName,
                UserName = userName,
                DesktopId = desktopId,
                Arguments = args
            };
        }
    }

    private void OnCommand(object? sender, CommandTargetEventArgs e)
    {
        var cmd = SingleInstanceCommand.Parse(e);
        if (cmd == null)
            return;

        var ce = new SingleInstanceCommandEventArgs((SingleInstanceCommandType)e.Id,
            cmd.ProcessId,
            cmd.CurrentDirectory,
            cmd.UserDomainName,
            cmd.UserName,
            cmd.DesktopId,
            cmd.Arguments);
        Command?.Invoke(sender, ce);
        if (ce._outputSet)
        {
            e.Output = ce.Output;
        }

        if (ce.Handled)
        {
            e.HResult = Constants.S_OK;
        }
    }
}
