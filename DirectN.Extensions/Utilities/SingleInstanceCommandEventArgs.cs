namespace DirectN.Extensions.Utilities;

public class SingleInstanceCommandEventArgs : HandledEventArgs
{
    internal bool _outputSet;
    private object? _output;
    private readonly Lazy<Process?> _callingProcess;

    public SingleInstanceCommandEventArgs(SingleInstanceCommandType type, int callingProcessId, string currentDirectory, string userDomainName, string userName, Guid callingDesktopId, IReadOnlyList<object>? arguments)
    {
        Type = type;
        CallingProcessId = callingProcessId;
        CurrentDirectory = currentDirectory;
        UserDomainName = userDomainName;
        UserName = userName;
        CallingDesktopId = callingDesktopId;
        _callingProcess = new Lazy<Process?>(() => LoadProcess(CallingProcessId));
        Arguments = arguments ?? [];
    }

    public SingleInstanceCommandType Type { get; }
    public string CurrentDirectory { get; }
    public string UserDomainName { get; }
    public string UserName { get; }
    public Guid CallingDesktopId { get; }
    public int CallingProcessId { get; }
    public IReadOnlyList<object?> Arguments { get; }
    public Process? CallingProcess => _callingProcess.Value;
    public string CallingProcessName => CallingProcess?.ProcessName ?? CallingProcessId.ToString();
    public object? Output
    {
        get => _output;
        set
        {
            if (value == _output)
                return;

            _output = value;
            _outputSet = true;
        }
    }

    public override string ToString()
    {
        var str = $"{Type} User:{UserName}@{UserDomainName} Process:{CallingProcessId}";
        var pn = CallingProcess?.ProcessName;
        if (pn != null)
        {
            str += $" ('{pn}')";
        }

        if (Arguments?.Count > 0)
        {
            str += $" Arguments:{string.Join(';', Arguments)}";
        }
        return str;
    }

    private static Process? LoadProcess(int id)
    {
        if (id == 0)
            return null;

        try
        {
            return Process.GetProcessById(id);
        }
        catch
        {
            return null;
        }
    }
}
