#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_clear_value
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_CLEAR_VALUE
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public InlineArraySingle_4 Color;
        
        [FieldOffset(0)]
        public D3D12_DEPTH_STENCIL_VALUE DepthStencil;
    }
    
    public DXGI_FORMAT Format;
    public _Anonymous_e__Union Anonymous;
}
