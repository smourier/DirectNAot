namespace DirectN;

// https://learn.microsoft.com/windows/win32/gdi/colorref
[StructLayout(LayoutKind.Sequential)]
public partial struct COLORREF
{
    public uint Value;
}
