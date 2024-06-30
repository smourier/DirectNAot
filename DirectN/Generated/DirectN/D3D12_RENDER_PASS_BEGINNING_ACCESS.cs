#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_render_pass_beginning_access
public partial struct D3D12_RENDER_PASS_BEGINNING_ACCESS
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS Clear;
        
        [FieldOffset(0)]
        public D3D12_RENDER_PASS_BEGINNING_ACCESS_PRESERVE_LOCAL_PARAMETERS PreserveLocal;
    }
    
    public D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE Type;
    public _Anonymous_e__Union Anonymous;
}
