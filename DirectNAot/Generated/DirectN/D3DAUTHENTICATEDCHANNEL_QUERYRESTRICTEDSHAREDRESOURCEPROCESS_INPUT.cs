namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-queryrestrictedsharedresourceprocess-input
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYRESTRICTEDSHAREDRESOURCEPROCESS_INPUT
{
    public D3DAUTHENTICATEDCHANNEL_QUERY_INPUT Input;
    public uint ProcessIndex;
}
