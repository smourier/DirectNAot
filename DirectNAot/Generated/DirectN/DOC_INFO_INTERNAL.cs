namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DOC_INFO_INTERNAL
{
    public nint pDocName;
    public nint pOutputFile;
    public nint pDatatype;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bLowILJob;
    public HANDLE hTokenLowIL;
}
