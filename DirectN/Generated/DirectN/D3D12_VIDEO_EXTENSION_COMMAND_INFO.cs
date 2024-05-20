﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_extension_command_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_EXTENSION_COMMAND_INFO
{
    public Guid CommandId;
    public PWSTR Name;
    public D3D12_COMMAND_LIST_SUPPORT_FLAGS CommandListSupportFlags;
}
