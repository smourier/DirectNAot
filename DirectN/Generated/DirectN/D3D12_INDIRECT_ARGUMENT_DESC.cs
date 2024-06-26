﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_indirect_argument_desc
public partial struct D3D12_INDIRECT_ARGUMENT_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _VertexBuffer_e__Struct
        {
            public uint Slot;
        }
        
        public struct _Constant_e__Struct
        {
            public uint RootParameterIndex;
            public uint DestOffsetIn32BitValues;
            public uint Num32BitValuesToSet;
        }
        
        public struct _ConstantBufferView_e__Struct
        {
            public uint RootParameterIndex;
        }
        
        public struct _ShaderResourceView_e__Struct
        {
            public uint RootParameterIndex;
        }
        
        public struct _UnorderedAccessView_e__Struct
        {
            public uint RootParameterIndex;
        }
        
        public struct _IncrementingConstant_e__Struct
        {
            public uint RootParameterIndex;
            public uint DestOffsetIn32BitValues;
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
        
        [FieldOffset(0)]
        public _IncrementingConstant_e__Struct IncrementingConstant;
    }
    
    public D3D12_INDIRECT_ARGUMENT_TYPE Type;
    public _Anonymous_e__Union Anonymous;
}
