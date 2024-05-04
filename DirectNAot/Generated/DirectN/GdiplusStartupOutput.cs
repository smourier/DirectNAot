#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GdiplusStartupOutput
{
    public nint NotificationHook;
    public nint NotificationUnhook;
}
