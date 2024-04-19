namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/ns-wmcontainer-asf_mux_statistics
[StructLayout(LayoutKind.Sequential)]
public partial struct ASF_MUX_STATISTICS
{
    public uint cFramesWritten;
    public uint cFramesDropped;
}
