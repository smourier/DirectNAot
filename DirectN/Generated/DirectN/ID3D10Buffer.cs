﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10buffer
[GeneratedComInterface, Guid("9b7e4c02-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10Buffer : ID3D10Resource
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10buffer-map
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Map(D3D10_MAP MapType, uint MapFlags, out nint ppData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10buffer-unmap
    [PreserveSig]
    void Unmap();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10buffer-getdesc
    [PreserveSig]
    void GetDesc(out D3D10_BUFFER_DESC pDesc);
}
