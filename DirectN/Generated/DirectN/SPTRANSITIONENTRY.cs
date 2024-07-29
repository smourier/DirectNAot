#nullable enable
namespace DirectN;

public partial struct SPTRANSITIONENTRY
{
    public struct _Anonymous1_e__Struct
    {
        public uint fHasProperty;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        public struct _Anonymous1_e__Struct
        {
            public SPSTATEHANDLE hRuleInitialState;
            public SPRULEHANDLE hRule;
            public nint pvClientRuleContext;
        }
        
        public struct _Anonymous2_e__Struct
        {
            public SPWORDHANDLE hWord;
            public nint pvClientWordContext;
        }
        
        public struct _Anonymous3_e__Struct
        {
            public nint pvGrammarCookie;
        }
        
        [FieldOffset(0)]
        public _Anonymous1_e__Struct Anonymous1;
        
        [FieldOffset(0)]
        public _Anonymous2_e__Struct Anonymous2;
        
        [FieldOffset(0)]
        public _Anonymous3_e__Struct Anonymous3;
    }
    
    public SPTRANSITIONID ID;
    public SPSTATEHANDLE hNextState;
    public byte Type;
    public byte RequiredConfidence;
    public _Anonymous1_e__Struct Anonymous1;
    public float Weight;
    public _Anonymous2_e__Union Anonymous2;
}
