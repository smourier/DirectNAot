#nullable enable
namespace DirectN;

public partial struct DXVA_COPPStatusInput
{
    public Guid rApp;
    public Guid guidStatusRequestID;
    public uint dwSequence;
    public uint cbSizeData;
    public InlineArrayByte_4056 StatusData;
}
