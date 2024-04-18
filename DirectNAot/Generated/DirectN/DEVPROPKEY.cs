namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DEVPROPKEY
{
    public Guid fmtid;
    public uint pid;
}
