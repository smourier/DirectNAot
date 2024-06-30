#nullable enable
namespace DirectN;

public partial struct DXVA_COPPCommand
{
    public Guid macKDI;
    public Guid guidCommandID;
    public uint dwSequence;
    public uint cbSizeData;
    public InlineArrayByte_4056 CommandData;
}
