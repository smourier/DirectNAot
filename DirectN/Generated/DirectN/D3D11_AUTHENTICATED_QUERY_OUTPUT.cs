﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_query_output
public partial struct D3D11_AUTHENTICATED_QUERY_OUTPUT
{
    public D3D11_OMAC omac;
    public Guid QueryType;
    public HANDLE hChannel;
    public uint SequenceNumber;
    public HRESULT ReturnCode;
}
