namespace DirectN.Extensions.Utilities;

public sealed class CommandResult(HRESULT hresult, object? output)
{
    public HRESULT HResult { get; } = hresult;
    public object? Output { get; } = output;

    public override string ToString() => $"{HResult} {Output}";
}
