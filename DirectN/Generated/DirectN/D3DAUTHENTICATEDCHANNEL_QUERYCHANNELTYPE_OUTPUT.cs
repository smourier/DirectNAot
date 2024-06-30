#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-querychanneltype-output
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYCHANNELTYPE_OUTPUT
{
    public D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT Output;
    public D3DAUTHENTICATEDCHANNELTYPE ChannelType;
}
