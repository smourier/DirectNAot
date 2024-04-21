﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/ne-d3d11sdklayers-d3d11_shader_tracking_resource_type
public enum D3D11_SHADER_TRACKING_RESOURCE_TYPE
{
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_NONE = 0,
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_UAV_DEVICEMEMORY = 1,
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_NON_UAV_DEVICEMEMORY = 2,
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL_DEVICEMEMORY = 3,
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_GROUPSHARED_MEMORY = 4,
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL_SHARED_MEMORY = 5,
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_GROUPSHARED_NON_UAV = 6,
    D3D11_SHADER_TRACKING_RESOURCE_TYPE_ALL = 7,
}