#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AM_AC3_ALTERNATE_AUDIO
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fStereo;
    public uint DualMode;
}
