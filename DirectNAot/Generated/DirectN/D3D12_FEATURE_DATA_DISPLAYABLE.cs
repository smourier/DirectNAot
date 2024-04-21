﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_displayable
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_DISPLAYABLE
{
    [MarshalAs(UnmanagedType.U4)]
    public bool DisplayableTexture;
    public D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER SharedResourceCompatibilityTier;
}