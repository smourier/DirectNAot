namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-excepinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct EXCEPINFO
{
    public ushort wCode;
    public ushort wReserved;
    public BSTR bstrSource;
    public BSTR bstrDescription;
    public BSTR bstrHelpFile;
    public uint dwHelpContext;
    public nint pvReserved;
    public nint pfnDeferredFillIn;
    public int scode;
}
