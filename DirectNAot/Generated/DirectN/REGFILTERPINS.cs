namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-regfilterpins
[StructLayout(LayoutKind.Sequential)]
public partial struct REGFILTERPINS
{
    public PWSTR strName;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bRendered;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bOutput;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bZero;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bMany;
    public nint clsConnectsToFilter;
    public PWSTR strConnectsToPin;
    public uint nMediaTypes;
    public nint lpMediaType;
}
