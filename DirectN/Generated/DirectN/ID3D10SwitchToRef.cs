#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nn-d3d10sdklayers-id3d10switchtoref
[GeneratedComInterface, Guid("9b7e4e02-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10SwitchToRef
{
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10switchtoref-setuseref
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL SetUseRef(BOOL UseRef);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10switchtoref-getuseref
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL GetUseRef();
}
