namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vptype/ns-vptype-amvpdiminfo
[StructLayout(LayoutKind.Sequential)]
public partial struct AMVPDIMINFO
{
    public uint dwFieldWidth;
    public uint dwFieldHeight;
    public uint dwVBIWidth;
    public uint dwVBIHeight;
    public RECT rcValidRegion;
}
