﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_architecture
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_ARCHITECTURE
{
    public uint NodeIndex;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool TileBasedRenderer;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool UMA;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool CacheCoherentUMA;
}
