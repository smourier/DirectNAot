namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddcolorkey
[StructLayout(LayoutKind.Sequential)]
public partial struct DDCOLORKEY
{
    public uint dwColorSpaceLowValue;
    public uint dwColorSpaceHighValue;
}
