#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/medparam/nn-medparam-imediaparaminfo
[GeneratedComInterface, Guid("6d6cbb60-a223-44aa-842f-a2f06750be6d")]
public partial interface IMediaParamInfo
{
    // https://learn.microsoft.com/windows/win32/api/medparam/nf-medparam-imediaparaminfo-getparamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParamCount(out uint pdwParams);
    
    // https://learn.microsoft.com/windows/win32/api/medparam/nf-medparam-imediaparaminfo-getparaminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParamInfo(uint dwParamIndex, out MP_PARAMINFO pInfo);
    
    // https://learn.microsoft.com/windows/win32/api/medparam/nf-medparam-imediaparaminfo-getparamtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParamText(uint dwParamIndex, out nint ppwchText);
    
    // https://learn.microsoft.com/windows/win32/api/medparam/nf-medparam-imediaparaminfo-getnumtimeformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumTimeFormats(out uint pdwNumTimeFormats);
    
    // https://learn.microsoft.com/windows/win32/api/medparam/nf-medparam-imediaparaminfo-getsupportedtimeformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedTimeFormat(uint dwFormatIndex, out Guid pguidTimeFormat);
    
    // https://learn.microsoft.com/windows/win32/api/medparam/nf-medparam-imediaparaminfo-getcurrenttimeformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentTimeFormat(out Guid pguidTimeFormat, out uint pTimeData);
}
