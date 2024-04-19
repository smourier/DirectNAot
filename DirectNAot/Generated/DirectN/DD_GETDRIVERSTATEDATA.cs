namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getdriverstatedata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_GETDRIVERSTATEDATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint lpDD;
        
        [FieldOffset(0)]
        public nuint dwhContext;
    }
    
    public uint dwFlags;
    public _Anonymous_e__Union Anonymous;
    public nint lpdwStates;
    public uint dwLength;
    public HRESULT ddRVal;
}
