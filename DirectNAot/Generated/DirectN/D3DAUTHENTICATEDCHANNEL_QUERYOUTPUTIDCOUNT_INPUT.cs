#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-queryoutputidcount-input
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTIDCOUNT_INPUT
{
    public D3DAUTHENTICATEDCHANNEL_QUERY_INPUT Input;
    public HANDLE DeviceHandle;
    public HANDLE CryptoSessionHandle;
}
