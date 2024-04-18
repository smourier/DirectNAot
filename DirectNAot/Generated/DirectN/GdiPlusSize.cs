namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.foundation/ns-windows-foundation-size
[StructLayout(LayoutKind.Sequential)]
public partial struct GdiPlusSize
{
    public int Width;
    public int Height;
}
