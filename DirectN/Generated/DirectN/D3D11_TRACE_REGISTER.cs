#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/ns-d3d11shadertracing-d3d11_trace_register
public partial struct D3D11_TRACE_REGISTER
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public ushort Index1D;
        
        [FieldOffset(0)]
        public InlineArrayUInt16_2 Index2D;
    }
    
    public D3D11_TRACE_REGISTER_TYPE RegType;
    public _Anonymous_e__Union Anonymous;
    public byte OperandIndex;
    public byte Flags;
}
