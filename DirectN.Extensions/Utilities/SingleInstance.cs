namespace DirectN.Extensions.Utilities;

public static partial class SingleInstance
{
    public static event EventHandler<SingleInstanceCommandEventArgs>? Command;

    public static Guid DefaultGroupId { get; } = new("a10c0a04-6d0f-412f-b185-df0785fec625");

    private const int _wellKnownArgs = 5;
    private static CommandTarget? _commandTarget;

    // well-known commands
    public static IEnumerable<CommandResult> SendCommandLine(Guid? desktopId = null, int targetPid = 0, IEnumerable<string?>? arguments = null) => Send(desktopId, targetPid, SingleInstanceCommandType.SendCommandLine, arguments?.ToArray());
    public static IEnumerable<CommandResult> Quit(Guid? desktopId = null, int targetPid = -1) => Send(desktopId, targetPid, SingleInstanceCommandType.Quit);
    public static IEnumerable<CommandResult> FailFast(Guid? desktopId = null, int targetPid = -1) => Send(desktopId, targetPid, SingleInstanceCommandType.FailFast);
    public static IEnumerable<CommandResult> Ping(Guid? desktopId = null, int targetPid = -1) => Send(desktopId, targetPid, SingleInstanceCommandType.Ping);
    public static IEnumerable<CommandResult> Send(Guid? desktopId, int targetPid, SingleInstanceCommandType type, params object?[]? arguments) => Send(desktopId, targetPid, (uint)type, arguments);

    public static void AddWellKnownArguments(Guid? desktopId, IList<object?> list)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.Add(SystemUtilities.CurrentProcess.Id);
        list.Add(Environment.CurrentDirectory);
        list.Add(Environment.UserDomainName);
        list.Add(Environment.UserName);
        list.Add((desktopId ?? Guid.Empty).ToString("N"));
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

    public static IEnumerable<CommandResult> Send(Guid? desktopId, int targetPid, uint type, params object?[]? arguments)
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

        return CommandTarget.TryExec(targetPid, ct.Moniker, ct.GroupId, type, input.ToArray());
    }

    public static void AllowSetForegroundWindow(Guid desktopId)
    {
        foreach (var result in Ping(desktopId))
        {
            if (result.HResult.IsOk && Conversions.TryChangeType<uint>(result.Output, out var pid) && pid > 0)
            {
                Functions.AllowSetForegroundWindow(pid);
            }
        }
    }

    public static void WithCommandTarget(Action action, string? moniker = null, Guid? groupId = null)
    {
        ArgumentNullException.ThrowIfNull(action);
        RegisterCommandTarget(moniker, groupId);
        try
        {
            action();
        }
        finally
        {
            UnregisterCommandTarget();
        }
    }

    public static void UnregisterCommandTarget() => Interlocked.Exchange(ref _commandTarget, null)?.Dispose();
    public static void RegisterCommandTarget(string? moniker = null, Guid? groupId = null)
    {
        UnregisterCommandTarget();
        moniker ??= typeof(SingleInstance).FullName!;
        groupId ??= DefaultGroupId;
        _commandTarget = new CommandTarget(moniker, groupId.Value);
        _commandTarget.Command += OnCommand;
        _commandTarget.Register();
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

    private static void OnCommand(object? sender, CommandTargetEventArgs e)
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
