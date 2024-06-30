#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-safearraybound
public partial struct SAFEARRAYBOUND
{
    public uint cElements;
    public int lLbound;
}
