namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-paramdescex
[StructLayout(LayoutKind.Sequential)]
public partial struct PARAMDESCEX
{
    public uint cBytes;
    public VARIANT varDefaultValue;
}
