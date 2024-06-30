#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_versioned_root_signature_desc
public partial struct D3D12_VERSIONED_ROOT_SIGNATURE_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_ROOT_SIGNATURE_DESC Desc_1_0;
        
        [FieldOffset(0)]
        public D3D12_ROOT_SIGNATURE_DESC1 Desc_1_1;
        
        [FieldOffset(0)]
        public D3D12_ROOT_SIGNATURE_DESC2 Desc_1_2;
    }
    
    public D3D_ROOT_SIGNATURE_VERSION Version;
    public _Anonymous_e__Union Anonymous;
}
