#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-configurecryptosession
public partial struct D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION
{
    public D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT Parameters;
    public HANDLE DXVA2DecodeHandle;
    public HANDLE CryptoSessionHandle;
    public HANDLE DeviceHandle;
}
