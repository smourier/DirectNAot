namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PROPBAG2
{
    public uint dwType;
    public VARENUM vt;
    public ushort cfType;
    public uint dwHint;
    public PWSTR pstrName;
    public Guid clsid;
}
