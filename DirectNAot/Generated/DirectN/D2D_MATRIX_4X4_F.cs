namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcommon/ns-dcommon-d2d_matrix_4x4_f
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D_MATRIX_4X4_F
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
            public float _14;
            public float _21;
            public float _22;
            public float _23;
            public float _24;
            public float _31;
            public float _32;
            public float _33;
            public float _34;
            public float _41;
            public float _42;
            public float _43;
            public float _44;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public InlineArraySingle16 m;
    }
    
    public _Anonymous_e__Union Anonymous;
}
