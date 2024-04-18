namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ImgErrorInfo
{
    public BSTR description;
    public Guid guid;
    public uint helpContext;
    public BSTR helpFile;
    public BSTR source;
    public BSTR devDescription;
    public Guid errorID;
    public uint cUserParameters;
    public nint aUserParameters;
    public BSTR userFallback;
    public uint exceptionID;
}
