#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_NODE
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_SHADER_NODE Shader;
    }
    
    public D3D12_NODE_TYPE NodeType;
    public _Anonymous_e__Union Anonymous;
}
