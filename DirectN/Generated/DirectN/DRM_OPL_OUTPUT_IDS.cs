﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-drm_opl_output_ids
public partial struct DRM_OPL_OUTPUT_IDS
{
    public ushort cIds;
    public nint rgIds;
}
