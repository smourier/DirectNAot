#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPTRANSITIONENTRY
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _Anonymous1_e__Struct
    {
        public uint fHasProperty;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous1_e__Struct
        {
            public SPSTATEHANDLE hRuleInitialState;
            public SPRULEHANDLE hRule;
            public nint pvClientRuleContext;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous2_e__Struct
        {
            public SPWORDHANDLE hWord;
            public nint pvClientWordContext;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous3_e__Struct
        {
            public static readonly _Anonymous3_e__Struct Null = new();
            
            public nint pvGrammarCookie;
            
            public override readonly bool Equals(object? obj) => obj is _Anonymous3_e__Struct value && Equals(value);
            public readonly bool Equals(_Anonymous3_e__Struct other) => other.pvGrammarCookie == pvGrammarCookie;
            public override readonly int GetHashCode() => pvGrammarCookie.GetHashCode();
            public static bool operator ==(_Anonymous3_e__Struct left, _Anonymous3_e__Struct right) => left.Equals(right);
            public static bool operator !=(_Anonymous3_e__Struct left, _Anonymous3_e__Struct right) => !left.Equals(right);
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
