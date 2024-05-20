#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSATTRIBUTE
{
    public uint Size;
    public uint Flags;
    public Guid Attribute;
}
