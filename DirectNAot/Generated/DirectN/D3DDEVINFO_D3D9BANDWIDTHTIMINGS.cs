namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddevinfo-d3d9bandwidthtimings
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDEVINFO_D3D9BANDWIDTHTIMINGS
{
    public float MaxBandwidthUtilized;
    public float FrontEndUploadMemoryUtilizedPercent;
    public float VertexRateUtilizedPercent;
    public float TriangleSetupRateUtilizedPercent;
    public float FillRateUtilizedPercent;
}
