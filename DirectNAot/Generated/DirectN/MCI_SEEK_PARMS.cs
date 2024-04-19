namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-seek-parms
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_SEEK_PARMS
{
    public nuint dwCallback;
    public uint dwTo;
}
