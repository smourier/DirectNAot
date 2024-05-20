#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSQUALITY
{
    public nint Context;
    public uint Proportion;
    public long DeltaTime;
}
