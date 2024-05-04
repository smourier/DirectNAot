#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VFW_FILTERLIST
{
    public uint cFilters;
    public InlineArrayGuid1 aClsId; // variable-length array placeholder
}
