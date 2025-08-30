#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d10/d3d10-d3dmatrix
public partial struct D3DMATRIX
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
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
        public InlineArraySingle_16 m;
    }
    
    public _Anonymous_e__Union Anonymous;
}
