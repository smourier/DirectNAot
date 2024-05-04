#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAC3_ALTERNATE_AUDIO
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fStereo;
    public uint DualMode;
}
