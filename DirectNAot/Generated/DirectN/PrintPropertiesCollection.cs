namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PrintPropertiesCollection
{
    public uint numberOfProperties;
    public nint propertiesCollection;
}
