﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options9
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS9
{
    public BOOL MeshShaderPipelineStatsSupported;
    public BOOL MeshShaderSupportsFullRangeRenderTargetArrayIndex;
    public BOOL AtomicInt64OnTypedResourceSupported;
    public BOOL AtomicInt64OnGroupSharedSupported;
    public BOOL DerivativesInMeshAndAmplificationShadersSupported;
    public D3D12_WAVE_MMA_TIER WaveMMATier;
}
