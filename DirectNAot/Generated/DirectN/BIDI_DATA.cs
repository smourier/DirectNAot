namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BIDI_DATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _u_e__Union
    {
        [MarshalAs(UnmanagedType.U4)]
        [FieldOffset(0)]
        public bool bData;
        
        [FieldOffset(0)]
        public int iData;
        
        [FieldOffset(0)]
        public PWSTR sData;
        
        [FieldOffset(0)]
        public float fData;
        
        [FieldOffset(0)]
        public BINARY_CONTAINER biData;
    }
    
    public uint dwBidiType;
    public _u_e__Union u;
}
