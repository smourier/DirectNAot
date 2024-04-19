namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCOMPONENTID
{
    public Guid Manufacturer;
    public Guid Product;
    public Guid Component;
    public Guid Name;
    public uint Version;
    public uint Revision;
}
