#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_indirect_argument_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_INDIRECT_ARGUMENT_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _VertexBuffer_e__Struct
        {
            public uint Slot;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _Constant_e__Struct
        {
            public uint RootParameterIndex;
            public uint DestOffsetIn32BitValues;
            public uint Num32BitValuesToSet;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _ConstantBufferView_e__Struct
        {
            public uint RootParameterIndex;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _ShaderResourceView_e__Struct
        {
            public uint RootParameterIndex;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _UnorderedAccessView_e__Struct
        {
            public uint RootParameterIndex;
        }
        
        [FieldOffset(0)]
        public _VertexBuffer_e__Struct VertexBuffer;
        
        [FieldOffset(0)]
        public _Constant_e__Struct Constant;
        
        [FieldOffset(0)]
        public _ConstantBufferView_e__Struct ConstantBufferView;
        
        [FieldOffset(0)]
        public _ShaderResourceView_e__Struct ShaderResourceView;
        
        [FieldOffset(0)]
        public _UnorderedAccessView_e__Struct UnorderedAccessView;
    }
    
    public D3D12_INDIRECT_ARGUMENT_TYPE Type;
    public _Anonymous_e__Union Anonymous;
}
