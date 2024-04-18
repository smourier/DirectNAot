namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_query_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_QUERY_DESC
{
    public D3D11_QUERY Query;
    public uint MiscFlags;
}
