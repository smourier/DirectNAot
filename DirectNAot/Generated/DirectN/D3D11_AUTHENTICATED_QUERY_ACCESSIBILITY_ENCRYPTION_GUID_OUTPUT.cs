namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_query_accessibility_encryption_guid_output
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_OUTPUT
{
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    public uint EncryptionGuidIndex;
    public Guid EncryptionGuid;
}
