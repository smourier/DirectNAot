namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct NOTIFICATION_CONFIG_1
{
    public uint cbSize;
    public uint fdwFlags;
    public nint pfnNotifyCallback;
    public nint pContext;
}
