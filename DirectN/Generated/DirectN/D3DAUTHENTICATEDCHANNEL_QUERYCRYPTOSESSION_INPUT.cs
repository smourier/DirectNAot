#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-querycryptosession-input
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYCRYPTOSESSION_INPUT
{
    public D3DAUTHENTICATEDCHANNEL_QUERY_INPUT Input;
    public HANDLE DXVA2DecodeHandle;
}
