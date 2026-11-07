#nullable enable
namespace DirectN;

public partial struct D3D12_MLIR_PROGRAM_BINDING
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_GPU_VIRTUAL_ADDRESS_RANGE GpuVirtualAddressBinding;
        
        [FieldOffset(0)]
        public D3D12_GPU_DESCRIPTOR_HANDLE GpuDescriptorBinding;
        
        [FieldOffset(0)]
        public D3D12_MLIR_PROGRAM_CPU_BINDING CpuBinding;
    }
    
    public uint BindPointIndex;
    public D3D12_MLIR_PROGRAM_BINDING_FLAGS Flags;
    public D3D12_MLIR_PROGRAM_BINDING_TYPE Type;
    public _Anonymous_e__Union Anonymous;
}
