#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-safearraybound
[StructLayout(LayoutKind.Sequential)]
public partial struct SAFEARRAYBOUND
{
    public uint cElements;
    public int lLbound;
}
