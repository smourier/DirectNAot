namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddevinfo-d3d9pipelinetimings
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDEVINFO_D3D9PIPELINETIMINGS
{
    public float VertexProcessingTimePercent;
    public float PixelProcessingTimePercent;
    public float OtherGPUProcessingTimePercent;
    public float GPUIdleTimePercent;
}
