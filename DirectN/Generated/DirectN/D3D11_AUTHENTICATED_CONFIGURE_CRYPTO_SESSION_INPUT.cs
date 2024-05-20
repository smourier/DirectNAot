#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_configure_crypto_session_input
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_AUTHENTICATED_CONFIGURE_CRYPTO_SESSION_INPUT
{
    public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;
    public HANDLE DecoderHandle;
    public HANDLE CryptoSessionHandle;
    public HANDLE DeviceHandle;
}
