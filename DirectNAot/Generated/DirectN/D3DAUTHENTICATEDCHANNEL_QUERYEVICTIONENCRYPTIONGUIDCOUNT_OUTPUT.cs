namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-queryevictionencryptionguidcount-output
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYEVICTIONENCRYPTIONGUIDCOUNT_OUTPUT
{
    public D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT Output;
    public uint NumEncryptionGuids;
}
