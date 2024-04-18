namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_query_accessibility_encryption_guid_input
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_INPUT
{
    public D3D11_AUTHENTICATED_QUERY_INPUT Input;
    public uint EncryptionGuidIndex;
}
