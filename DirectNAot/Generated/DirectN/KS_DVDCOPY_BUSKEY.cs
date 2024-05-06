#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DVDCOPY_BUSKEY
{
    public InlineArrayByte_5 BusKey;
    public InlineArrayByte_1 Reserved; // variable-length array placeholder
}
