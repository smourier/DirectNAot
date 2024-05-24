#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-vd-step-parms
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_VD_STEP_PARMS
{
    public nuint dwCallback;
    public uint dwFrames;
}
