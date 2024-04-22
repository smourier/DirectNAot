namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-rgbcolor
[StructLayout(LayoutKind.Sequential)]
public partial struct RGBCOLOR
{
    public ushort red;
    public ushort green;
    public ushort blue;
}
