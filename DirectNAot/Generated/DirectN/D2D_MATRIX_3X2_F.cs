namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcommon/ns-dcommon-d2d_matrix_3x2_f
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D_MATRIX_3X2_F
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous1_e__Struct
        {
            public float m11;
            public float m12;
            public float m21;
            public float m22;
            public float dx;
            public float dy;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous2_e__Struct
        {
            public float _11;
            public float _12;
            public float _21;
            public float _22;
            public float _31;
            public float _32;
        }
        
        [FieldOffset(0)]
        public _Anonymous1_e__Struct Anonymous1;
        
        [FieldOffset(0)]
        public _Anonymous2_e__Struct Anonymous2;
        
        [FieldOffset(0)]
        public InlineArraySingle6 m;
    }
    
    public _Anonymous_e__Union Anonymous;
}
