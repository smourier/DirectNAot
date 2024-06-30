#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdmrights
public partial struct WMDMRIGHTS
{
    public uint cbSize;
    public uint dwContentType;
    public uint fuFlags;
    public uint fuRights;
    public uint dwAppSec;
    public uint dwPlaybackCount;
    public WMDMDATETIME ExpirationDate;
}
