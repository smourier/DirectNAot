#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPRECOCONTEXTSTATUS
{
    public SPINTERFERENCE eInterference;
    public InlineArrayChar_255 szRequestTypeOfUI;
    public uint dwReserved1;
    public uint dwReserved2;
}
