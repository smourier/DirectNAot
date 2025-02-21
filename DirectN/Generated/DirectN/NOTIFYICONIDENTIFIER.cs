#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-notifyiconidentifier
public partial struct NOTIFYICONIDENTIFIER
{
    public uint cbSize;
    public HWND hWnd;
    public uint uID;
    public Guid guidItem;
}
