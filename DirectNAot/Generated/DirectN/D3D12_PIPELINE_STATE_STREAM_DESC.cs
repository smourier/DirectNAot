﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_pipeline_state_stream_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_PIPELINE_STATE_STREAM_DESC
{
    public nuint SizeInBytes;
    public nint pPipelineStateSubobjectStream;
}
