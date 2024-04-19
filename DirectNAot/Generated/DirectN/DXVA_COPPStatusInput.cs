namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_COPPStatusInput
{
    public Guid rApp;
    public Guid guidStatusRequestID;
    public uint dwSequence;
    public uint cbSizeData;
    public InlineArrayByte4056 StatusData;
}
