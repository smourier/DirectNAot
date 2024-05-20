﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options9
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS9
{
    [MarshalAs(UnmanagedType.U4)]
    public bool MeshShaderPipelineStatsSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool MeshShaderSupportsFullRangeRenderTargetArrayIndex;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool AtomicInt64OnTypedResourceSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool AtomicInt64OnGroupSharedSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool DerivativesInMeshAndAmplificationShadersSupported;
    public D3D12_WAVE_MMA_TIER WaveMMATier;
}