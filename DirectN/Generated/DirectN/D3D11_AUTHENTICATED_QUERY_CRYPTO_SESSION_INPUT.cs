﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_query_crypto_session_input
public partial struct D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION_INPUT
{
    public D3D11_AUTHENTICATED_QUERY_INPUT Input;
    public HANDLE DecoderHandle;
}
