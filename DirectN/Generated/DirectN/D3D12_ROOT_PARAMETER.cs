#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_root_parameter
public partial struct D3D12_ROOT_PARAMETER
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_ROOT_DESCRIPTOR_TABLE DescriptorTable;
        
        [FieldOffset(0)]
        public D3D12_ROOT_CONSTANTS Constants;
        
        [FieldOffset(0)]
        public D3D12_ROOT_DESCRIPTOR Descriptor;
    }
    
    public D3D12_ROOT_PARAMETER_TYPE ParameterType;
    public _Anonymous_e__Union Anonymous;
    public D3D12_SHADER_VISIBILITY ShaderVisibility;
}
