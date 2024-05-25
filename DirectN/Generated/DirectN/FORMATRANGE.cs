#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-formatrange
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct FORMATRANGE
{
    public HDC hdc;
    public HDC hdcTarget;
    public RECT rc;
    public RECT rcPage;
    public CHARRANGE chrg;
}
