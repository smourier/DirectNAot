#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_root_parameter1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_ROOT_PARAMETER1
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_ROOT_DESCRIPTOR_TABLE1 DescriptorTable;
        
        [FieldOffset(0)]
        public D3D12_ROOT_CONSTANTS Constants;
        
        [FieldOffset(0)]
        public D3D12_ROOT_DESCRIPTOR1 Descriptor;
    }
    
    public D3D12_ROOT_PARAMETER_TYPE ParameterType;
    public _Anonymous_e__Union Anonymous;
    public D3D12_SHADER_VISIBILITY ShaderVisibility;
}
