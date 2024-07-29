#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamanalogvideoencoder
[GeneratedComInterface, Guid("c6e133b0-30ac-11d0-a18c-00a0c9118956")]
public partial interface IAMAnalogVideoEncoder
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideoencoder-get_availabletvformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AvailableTVFormats(out int lAnalogVideoStandard);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideoencoder-put_tvformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TVFormat(int lAnalogVideoStandard);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideoencoder-get_tvformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TVFormat(out int plAnalogVideoStandard);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideoencoder-put_copyprotection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CopyProtection(int lVideoCopyProtection);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideoencoder-get_copyprotection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CopyProtection(out int lVideoCopyProtection);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideoencoder-put_ccenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CCEnable(int lCCEnable);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideoencoder-get_ccenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CCEnable(out int lCCEnable);
}
