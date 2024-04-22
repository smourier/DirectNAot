namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-pointer_info
[StructLayout(LayoutKind.Sequential)]
public partial struct POINTER_INFO
{
    public POINTER_INPUT_TYPE pointerType;
    public uint pointerId;
    public uint frameId;
    public POINTER_FLAGS pointerFlags;
    public HANDLE sourceDevice;
    public HWND hwndTarget;
    public nint ptPixelLocation;
    public nint ptHimetricLocation;
    public nint ptPixelLocationRaw;
    public nint ptHimetricLocationRaw;
    public uint dwTime;
    public uint historyCount;
    public int InputData;
    public uint dwKeyStates;
    public ulong PerformanceCount;
    public POINTER_BUTTON_CHANGE_TYPE ButtonChangeType;
}
