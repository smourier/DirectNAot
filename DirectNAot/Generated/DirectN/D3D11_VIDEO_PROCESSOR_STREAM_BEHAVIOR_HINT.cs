namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/ns-d3d11_1-d3d11_video_processor_stream_behavior_hint
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT
{
    [MarshalAs(UnmanagedType.U4)]
    public bool Enable;
    public uint Width;
    public uint Height;
    public DXGI_FORMAT Format;
}
