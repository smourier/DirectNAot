#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSGOP_USERDATA
{
    public uint sc;
    public uint reserved1;
    public byte cFields;
    public InlineArrayCHAR3 l21Data;
}
