#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_query_output_id_output
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT
{
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    public HANDLE DeviceHandle;
    public HANDLE CryptoSessionHandle;
    public uint OutputIDIndex;
    public ulong OutputID;
}
