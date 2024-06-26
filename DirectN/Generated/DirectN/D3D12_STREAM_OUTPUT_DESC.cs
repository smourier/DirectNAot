﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_stream_output_desc
public partial struct D3D12_STREAM_OUTPUT_DESC
{
    public nint pSODeclaration;
    public uint NumEntries;
    public nint pBufferStrides;
    public uint NumStrides;
    public uint RasterizedStream;
}
