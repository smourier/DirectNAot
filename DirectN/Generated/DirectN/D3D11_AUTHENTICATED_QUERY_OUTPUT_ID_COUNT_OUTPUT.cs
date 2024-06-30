#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_query_output_id_count_output
public partial struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT
{
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    public HANDLE DeviceHandle;
    public HANDLE CryptoSessionHandle;
    public uint OutputIDCount;
}
