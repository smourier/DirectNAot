#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct RedEyeCorrectionParams
{
    public uint numberOfAreas;
    public nint areas;
}
