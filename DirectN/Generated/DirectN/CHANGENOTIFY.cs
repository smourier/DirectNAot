#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/textserv/ns-textserv-changenotify
public partial struct CHANGENOTIFY
{
    public uint dwChangeType;
    public nint pvCookieData;
}
