#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-query-input
public partial struct D3DAUTHENTICATEDCHANNEL_QUERY_INPUT
{
    public Guid QueryType;
    public HANDLE hChannel;
    public uint SequenceNumber;
}
