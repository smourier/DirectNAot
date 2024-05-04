#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_cut_parms
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_CUT_PARMS
{
    public nuint dwCallback;
    public uint dwFrom;
    public uint dwTo;
    public RECT rc;
    public uint dwAudioStream;
    public uint dwVideoStream;
}
