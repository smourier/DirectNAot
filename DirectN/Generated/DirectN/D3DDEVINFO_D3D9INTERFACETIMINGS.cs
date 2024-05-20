#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddevinfo-d3d9interfacetimings
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDEVINFO_D3D9INTERFACETIMINGS
{
    public float WaitingForGPUToUseApplicationResourceTimePercent;
    public float WaitingForGPUToAcceptMoreCommandsTimePercent;
    public float WaitingForGPUToStayWithinLatencyTimePercent;
    public float WaitingForGPUExclusiveResourceTimePercent;
    public float WaitingForGPUOtherTimePercent;
}
