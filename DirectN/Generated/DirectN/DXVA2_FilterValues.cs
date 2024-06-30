#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_filtervalues
public partial struct DXVA2_FilterValues
{
    public DXVA2_Fixed32 Level;
    public DXVA2_Fixed32 Threshold;
    public DXVA2_Fixed32 Radius;
}
