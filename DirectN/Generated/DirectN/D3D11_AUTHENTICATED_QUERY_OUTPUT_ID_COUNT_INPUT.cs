﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_query_output_id_count_input
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_INPUT
{
    public D3D11_AUTHENTICATED_QUERY_INPUT Input;
    public HANDLE DeviceHandle;
    public HANDLE CryptoSessionHandle;
}