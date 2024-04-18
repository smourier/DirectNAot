namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-gradient_rect
[StructLayout(LayoutKind.Sequential)]
public partial struct GRADIENT_RECT
{
    public uint UpperLeft;
    public uint LowerRight;
}
