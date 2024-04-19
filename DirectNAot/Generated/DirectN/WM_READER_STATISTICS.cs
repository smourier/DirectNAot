namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_reader_statistics
[StructLayout(LayoutKind.Sequential)]
public partial struct WM_READER_STATISTICS
{
    public uint cbSize;
    public uint dwBandwidth;
    public uint cPacketsReceived;
    public uint cPacketsRecovered;
    public uint cPacketsLost;
    public ushort wQuality;
}
