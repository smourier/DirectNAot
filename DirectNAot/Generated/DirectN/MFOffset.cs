#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ns-mfobjects-mfoffset
[StructLayout(LayoutKind.Sequential)]
public partial struct MFOffset
{
    public ushort fract;
    public short value;
}
