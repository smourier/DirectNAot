namespace DirectN.Extensions.Utilities;

public static partial class SingleInstance
{
    public static Guid CommandGroupId { get; set; } = new("a10c0a04-6d0f-412f-b185-df0785fec625");

    private static CommandTarget? _commandTarget = new(typeof(SingleInstance).FullName!);

    public static event EventHandler<SingleInstanceCommandEventArgs>? Command;

    public static IEnumerable<CommandResult> SendCommandLine(Guid? desktopId = null, int targetPid = 0, IEnumerable<string?>? arguments = null) => Send(desktopId, targetPid, SingleInstanceCommandType.SendCommandLine, arguments?.ToArray());
    public static IEnumerable<CommandResult> Quit(Guid? desktopId = null, int targetPid = -1) => Send(desktopId, targetPid, SingleInstanceCommandType.Quit);
    public static IEnumerable<CommandResult> Ping(Guid? desktopId = null, int targetPid = -1) => Send(desktopId, targetPid, SingleInstanceCommandType.Ping);

    private static IEnumerable<CommandResult> Send(Guid? desktopId, int targetPid, SingleInstanceCommandType type, params object?[]? arguments) => Send(desktopId, targetPid, (uint)type, arguments);
    private static IEnumerable<CommandResult> Send(Guid? desktopId, int targetPid, uint type, params object?[]? arguments)
    {
        var ct = _commandTarget;
        if (ct == null)
            return [];

        var input = new List<object>
        {
            SystemUtilities.CurrentProcess.Id,
            Environment.CurrentDirectory,
            Environment.UserDomainName,
            Environment.UserName,
            (desktopId ?? Guid.Empty).ToString("N"),
        };

        if (input.Count != _wellKnownArgs)
            throw new InvalidOperationException();

        if (arguments != null && arguments.Length > 0)
        {
            input.AddRange(arguments!);
        }

        return CommandTarget.TryExec(targetPid, ct.Moniker, CommandGroupId, type, input.ToArray());
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

    public static void UnregisterCommandTarget() => Interlocked.Exchange(ref _commandTarget, null)?.Dispose();
    public static void RegisterCommandTarget()
    {
        var ct = _commandTarget;
        if (ct == null)
            return;

        ct.Command += OnCommand;
        ct.Register();
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

    private const int _wellKnownArgs = 5;
}
