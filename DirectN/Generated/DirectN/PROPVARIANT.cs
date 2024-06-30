#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propidlbase/ns-propidlbase-propvariant
public partial struct PROPVARIANT
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Anonymous_e__Struct
        {
            [StructLayout(LayoutKind.Explicit)]
            public struct _Anonymous_e__Union
            {
                [FieldOffset(0)]
                public CHAR cVal;
                
                [FieldOffset(0)]
                public byte bVal;
                
                [FieldOffset(0)]
                public short iVal;
                
                [FieldOffset(0)]
                public ushort uiVal;
                
                [FieldOffset(0)]
                public int lVal;
                
                [FieldOffset(0)]
                public uint ulVal;
                
                [FieldOffset(0)]
                public int intVal;
                
                [FieldOffset(0)]
                public uint uintVal;
                
                [FieldOffset(0)]
                public long hVal;
                
                [FieldOffset(0)]
                public ulong uhVal;
                
                [FieldOffset(0)]
                public float fltVal;
                
                [FieldOffset(0)]
                public double dblVal;
                
                [FieldOffset(0)]
                public VARIANT_BOOL boolVal;
                
                [FieldOffset(0)]
                public VARIANT_BOOL __OBSOLETE__VARIANT_BOOL;
                
                [FieldOffset(0)]
                public int scode;
                
                [FieldOffset(0)]
                public CY cyVal;
                
                [FieldOffset(0)]
                public double date;
                
                [FieldOffset(0)]
                public FILETIME filetime;
                
                [FieldOffset(0)]
                public nint puuid;
                
                [FieldOffset(0)]
                public nint pclipdata;
                
                [FieldOffset(0)]
                public BSTR bstrVal;
                
                [FieldOffset(0)]
                public BSTRBLOB bstrblobVal;
                
                [FieldOffset(0)]
                public BLOB blob;
                
                [FieldOffset(0)]
                public PSTR pszVal;
                
                [FieldOffset(0)]
                public PWSTR pwszVal;
                
                [FieldOffset(0)]
                public nint punkVal;
                
                [FieldOffset(0)]
                public nint pdispVal;
                
                [FieldOffset(0)]
                public nint pStream;
                
                [FieldOffset(0)]
                public nint pStorage;
                
                [FieldOffset(0)]
                public nint pVersionedStream;
                
                [FieldOffset(0)]
                public nint parray;
                
                [FieldOffset(0)]
                public CAC cac;
                
                [FieldOffset(0)]
                public CAUB caub;
                
                [FieldOffset(0)]
                public CAI cai;
                
                [FieldOffset(0)]
                public CAUI caui;
                
                [FieldOffset(0)]
                public CAL cal;
                
                [FieldOffset(0)]
                public CAUL caul;
                
                [FieldOffset(0)]
                public CAH cah;
                
                [FieldOffset(0)]
                public CAUH cauh;
                
                [FieldOffset(0)]
                public CAFLT caflt;
                
                [FieldOffset(0)]
                public CADBL cadbl;
                
                [FieldOffset(0)]
                public CABOOL cabool;
                
                [FieldOffset(0)]
                public CASCODE cascode;
                
                [FieldOffset(0)]
                public CACY cacy;
                
                [FieldOffset(0)]
                public CADATE cadate;
                
                [FieldOffset(0)]
                public CAFILETIME cafiletime;
                
                [FieldOffset(0)]
                public CACLSID cauuid;
                
                [FieldOffset(0)]
                public CACLIPDATA caclipdata;
                
                [FieldOffset(0)]
                public CABSTR cabstr;
                
                [FieldOffset(0)]
                public CABSTRBLOB cabstrblob;
                
                [FieldOffset(0)]
                public CALPSTR calpstr;
                
                [FieldOffset(0)]
                public CALPWSTR calpwstr;
                
                [FieldOffset(0)]
                public CAPROPVARIANT capropvar;
                
                [FieldOffset(0)]
                public PSTR pcVal;
                
                [FieldOffset(0)]
                public nint pbVal;
                
                [FieldOffset(0)]
                public nint piVal;
                
                [FieldOffset(0)]
                public nint puiVal;
                
                [FieldOffset(0)]
                public nint plVal;
                
                [FieldOffset(0)]
                public nint pulVal;
                
                [FieldOffset(0)]
                public nint pintVal;
                
                [FieldOffset(0)]
                public nint puintVal;
                
                [FieldOffset(0)]
                public nint pfltVal;
                
                [FieldOffset(0)]
                public nint pdblVal;
                
                [FieldOffset(0)]
                public nint pboolVal;
                
                [FieldOffset(0)]
                public nint pdecVal;
                
                [FieldOffset(0)]
                public nint pscode;
                
                [FieldOffset(0)]
                public nint pcyVal;
                
                [FieldOffset(0)]
                public nint pdate;
                
                [FieldOffset(0)]
                public nint pbstrVal;
                
                [FieldOffset(0)]
                public nint ppunkVal;
                
                [FieldOffset(0)]
                public nint ppdispVal;
                
                [FieldOffset(0)]
                public nint pparray;
                
                [FieldOffset(0)]
                public nint pvarVal;
            }
            
            public VARENUM vt;
            public ushort wReserved1;
            public ushort wReserved2;
            public ushort wReserved3;
            public _Anonymous_e__Union Anonymous;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public decimal decVal;
    }
    
    public _Anonymous_e__Union Anonymous;
}
