namespace DirectN.Extensions.Utilities;

public sealed class CommandTargetEventArgs(Guid commandGroup, uint id, object? input) : EventArgs
{
    internal bool _outputSet;
    private object? _output;

    public Guid Group { get; } = commandGroup;
    public uint Id { get; } = id;
    public object? Input { get; } = input;
    public HRESULT HResult { get; set; } = Constants.E_NOTIMPL;
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
}
