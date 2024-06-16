#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-paintstruct
[StructLayout(LayoutKind.Sequential)]
public partial struct PAINTSTRUCT
{
    public HDC hdc;
    public BOOL fErase;
    public RECT rcPaint;
    public BOOL fRestore;
    public BOOL fIncUpdate;
    public InlineArrayByte_32 rgbReserved;
}
