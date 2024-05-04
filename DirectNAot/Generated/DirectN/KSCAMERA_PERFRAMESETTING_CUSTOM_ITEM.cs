#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_PERFRAMESETTING_CUSTOM_ITEM
{
    public uint Size;
    public uint Reserved;
    public Guid Id;
}
