namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-seq-set-parms
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_SEQ_SET_PARMS
{
    public nuint dwCallback;
    public uint dwTimeFormat;
    public uint dwAudio;
    public uint dwTempo;
    public uint dwPort;
    public uint dwSlave;
    public uint dwMaster;
    public uint dwOffset;
}
