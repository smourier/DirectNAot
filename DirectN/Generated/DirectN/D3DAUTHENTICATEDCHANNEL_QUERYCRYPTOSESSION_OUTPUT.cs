#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-querycryptosession-output
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYCRYPTOSESSION_OUTPUT
{
    public D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT Output;
    public HANDLE DXVA2DecodeHandle;
    public HANDLE CryptoSessionHandle;
    public HANDLE DeviceHandle;
}
