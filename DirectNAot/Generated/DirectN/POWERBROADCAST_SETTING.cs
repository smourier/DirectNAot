namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-powerbroadcast_setting
[StructLayout(LayoutKind.Sequential)]
public partial struct POWERBROADCAST_SETTING
{
    public Guid PowerSetting;
    public uint DataLength;
    public InlineArrayByte1 Data; // variable-length array placeholder
}
