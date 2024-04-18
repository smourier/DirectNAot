namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/ns-d3d11_3-d3d11_query_desc1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_QUERY_DESC1
{
    public D3D11_QUERY Query;
    public uint MiscFlags;
    public D3D11_CONTEXT_TYPE ContextType;
}
