#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT
{
    public D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT Output;
    public HANDLE DeviceHandle;
    public HANDLE CryptoSessionHandle;
    public uint OutputIDIndex;
    public ulong OutputID;
}
