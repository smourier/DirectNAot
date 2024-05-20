#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xapofx/ns-xapofx-fxecho_initdata
[StructLayout(LayoutKind.Sequential)]
public partial struct FXECHO_INITDATA
{
    public float MaxDelay;
}
