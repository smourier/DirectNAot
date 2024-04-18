namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-dispparams
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPPARAMS
{
    public nint rgvarg;
    public nint rgdispidNamedArgs;
    public uint cArgs;
    public uint cNamedArgs;
}
