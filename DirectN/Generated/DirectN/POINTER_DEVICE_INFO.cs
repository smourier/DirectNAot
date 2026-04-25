#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-pointer_device_info
public partial struct POINTER_DEVICE_INFO
{
    public uint displayOrientation;
    public HANDLE device;
    public POINTER_DEVICE_TYPE pointerDeviceType;
    public HMONITOR monitor;
    public uint startingCursorId;
    public ushort maxActiveContacts;
    public InlineArrayChar_520 productString;
}
