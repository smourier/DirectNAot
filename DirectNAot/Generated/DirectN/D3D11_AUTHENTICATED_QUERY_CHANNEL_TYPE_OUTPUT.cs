namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_query_channel_type_output
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE_OUTPUT
{
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    public D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType;
}
