#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSERROR
{
    public nint Context;
    public uint Status;
}
