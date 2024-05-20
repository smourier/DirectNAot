﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iddrawexclmodevideo
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("153acc21-d83b-11d1-82bf-00a0c9696c8f")]
public partial interface IDDrawExclModeVideo
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iddrawexclmodevideo-setddrawobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDDrawObject(IDirectDraw pDDrawObject);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iddrawexclmodevideo-getddrawobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDDrawObject(out IDirectDraw ppDDrawObject, [MarshalAs(UnmanagedType.U4)] out bool pbUsingExternal);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iddrawexclmodevideo-setddrawsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDDrawSurface(IDirectDrawSurface pDDrawSurface);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iddrawexclmodevideo-getddrawsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDDrawSurface(out IDirectDrawSurface ppDDrawSurface, [MarshalAs(UnmanagedType.U4)] out bool pbUsingExternal);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iddrawexclmodevideo-setdrawparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDrawParameters(in RECT prcSource, in RECT prcTarget);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iddrawexclmodevideo-getnativevideoprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNativeVideoProps(out uint pdwVideoWidth, out uint pdwVideoHeight, out uint pdwPictAspectRatioX, out uint pdwPictAspectRatioY);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iddrawexclmodevideo-setcallbackinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCallbackInterface(IDDrawExclModeVideoCallback pCallback, uint dwFlags);
}
