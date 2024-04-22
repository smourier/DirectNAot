namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-labcolor
[StructLayout(LayoutKind.Sequential)]
public partial struct LabCOLOR
{
    public ushort L;
    public ushort a;
    public ushort b;
}
