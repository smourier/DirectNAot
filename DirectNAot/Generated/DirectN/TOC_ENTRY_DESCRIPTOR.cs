namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/ns-wmcodecdsp-toc_entry_descriptor
[StructLayout(LayoutKind.Sequential)]
public partial struct TOC_ENTRY_DESCRIPTOR
{
    public ulong qwStartTime;
    public ulong qwEndTime;
    public ulong qwStartPacketOffset;
    public ulong qwEndPacketOffset;
    public ulong qwRepresentativeFrameTime;
}
