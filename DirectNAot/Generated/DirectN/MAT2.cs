namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-mat2
[StructLayout(LayoutKind.Sequential)]
public partial struct MAT2
{
    public FIXED eM11;
    public FIXED eM12;
    public FIXED eM21;
    public FIXED eM22;
}
