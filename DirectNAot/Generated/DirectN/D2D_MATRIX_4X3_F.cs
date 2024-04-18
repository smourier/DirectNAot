namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcommon/ns-dcommon-d2d_matrix_4x3_f
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D_MATRIX_4X3_F
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public float _11;
            public float _12;
            public float _13;
            public float _21;
            public float _22;
            public float _23;
            public float _31;
            public float _32;
            public float _33;
            public float _41;
            public float _42;
            public float _43;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public InlineArraySingle12 m;
    }
    
    public _Anonymous_e__Union Anonymous;
}
