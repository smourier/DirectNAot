namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_content_protection_caps
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_CONTENT_PROTECTION_CAPS
{
    public uint Caps;
    public uint KeyExchangeTypeCount;
    public uint BlockAlignmentSize;
    public ulong ProtectedMemorySize;
}
