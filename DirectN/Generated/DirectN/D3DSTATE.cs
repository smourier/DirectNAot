#nullable enable
namespace DirectN;

public partial struct D3DSTATE
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public D3DLIGHTSTATETYPE dlstLightStateType;
        
        [FieldOffset(0)]
        public D3DRENDERSTATETYPE drstRenderStateType;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public InlineArrayUInt32_1 dwArg;
        
        [FieldOffset(0)]
        public InlineArraySingle_1 dvArg; // variable-length array placeholder
    }
    
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
}
