namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-queryoutputid-input
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT
{
    public D3DAUTHENTICATEDCHANNEL_QUERY_INPUT Input;
    public HANDLE DeviceHandle;
    public HANDLE CryptoSessionHandle;
    public uint OutputIDIndex;
}
