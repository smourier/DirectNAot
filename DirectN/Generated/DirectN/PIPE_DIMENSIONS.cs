#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PIPE_DIMENSIONS
{
    public KS_COMPRESSION AllocatorPin;
    public KS_COMPRESSION MaxExpansionPin;
    public KS_COMPRESSION EndPin;
}
