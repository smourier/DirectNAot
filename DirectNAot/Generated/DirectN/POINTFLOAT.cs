namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-pointfloat
[StructLayout(LayoutKind.Sequential)]
public partial struct POINTFLOAT
{
    public float x;
    public float y;
}
