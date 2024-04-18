﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/ne-d3d12sdklayers-d3d12_message_category
public enum D3D12_MESSAGE_CATEGORY
{
    D3D12_MESSAGE_CATEGORY_APPLICATION_DEFINED = 0,
    D3D12_MESSAGE_CATEGORY_MISCELLANEOUS = 1,
    D3D12_MESSAGE_CATEGORY_INITIALIZATION = 2,
    D3D12_MESSAGE_CATEGORY_CLEANUP = 3,
    D3D12_MESSAGE_CATEGORY_COMPILATION = 4,
    D3D12_MESSAGE_CATEGORY_STATE_CREATION = 5,
    D3D12_MESSAGE_CATEGORY_STATE_SETTING = 6,
    D3D12_MESSAGE_CATEGORY_STATE_GETTING = 7,
    D3D12_MESSAGE_CATEGORY_RESOURCE_MANIPULATION = 8,
    D3D12_MESSAGE_CATEGORY_EXECUTION = 9,
    D3D12_MESSAGE_CATEGORY_SHADER = 10,
}
