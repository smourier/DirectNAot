namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vptype/ns-vptype-amvpsize
[StructLayout(LayoutKind.Sequential)]
public partial struct AMVPSIZE
{
    public uint dwWidth;
    public uint dwHeight;
}
