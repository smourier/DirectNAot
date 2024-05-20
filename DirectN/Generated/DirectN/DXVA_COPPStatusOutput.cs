#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_COPPStatusOutput
{
    public Guid macKDI;
    public uint cbSizeData;
    public InlineArrayByte_4076 COPPStatus;
}
