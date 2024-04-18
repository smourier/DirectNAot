namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_render_pass_ending_access
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RENDER_PASS_ENDING_ACCESS
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS Resolve;
        
        [FieldOffset(0)]
        public D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS PreserveLocal;
    }
    
    public D3D12_RENDER_PASS_ENDING_ACCESS_TYPE Type;
    public _Anonymous_e__Union Anonymous;
}
