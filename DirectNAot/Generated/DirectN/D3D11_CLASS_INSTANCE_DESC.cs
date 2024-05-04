#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_class_instance_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_CLASS_INSTANCE_DESC
{
    public uint InstanceId;
    public uint InstanceIndex;
    public uint TypeId;
    public uint ConstantBuffer;
    public uint BaseConstantBufferOffset;
    public uint BaseTexture;
    public uint BaseSampler;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Created;
}
