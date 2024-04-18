namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-abcfloat
[StructLayout(LayoutKind.Sequential)]
public partial struct ABCFLOAT
{
    public float abcfA;
    public float abcfB;
    public float abcfC;
}
