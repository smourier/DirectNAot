﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options13
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS13
{
    public BOOL UnrestrictedBufferTextureCopyPitchSupported;
    public BOOL UnrestrictedVertexElementAlignmentSupported;
    public BOOL InvertedViewportHeightFlipsYSupported;
    public BOOL InvertedViewportDepthFlipsZSupported;
    public BOOL TextureCopyBetweenDimensionsSupported;
    public BOOL AlphaBlendFactorSupported;
}
