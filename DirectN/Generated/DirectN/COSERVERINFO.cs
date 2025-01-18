#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidlbase/ns-objidlbase-coserverinfo
public partial struct COSERVERINFO
{
    public uint dwReserved1;
    public PWSTR pwszName;
    public nint pAuthInfo;
    public uint dwReserved2;
}
