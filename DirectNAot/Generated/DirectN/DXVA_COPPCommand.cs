namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_COPPCommand
{
    public Guid macKDI;
    public Guid guidCommandID;
    public uint dwSequence;
    public uint cbSizeData;
    public InlineArrayByte4056 CommandData;
}
