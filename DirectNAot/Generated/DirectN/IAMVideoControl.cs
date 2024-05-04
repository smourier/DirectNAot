﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamvideocontrol
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("6a2e0670-28e4-11d0-a18c-00a0c9118956")]
public partial interface IAMVideoControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocontrol-getcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(IPin pPin, out int pCapsFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocontrol-setmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMode(IPin pPin, int Mode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocontrol-getmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMode(IPin pPin, out int Mode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocontrol-getcurrentactualframerate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentActualFrameRate(IPin pPin, out long ActualFrameRate);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocontrol-getmaxavailableframerate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxAvailableFrameRate(IPin pPin, int iIndex, SIZE Dimensions, out long MaxAvailableFrameRate);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideocontrol-getframeratelist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrameRateList(IPin pPin, int iIndex, SIZE Dimensions, out int ListSize, out nint FrameRates);
}
