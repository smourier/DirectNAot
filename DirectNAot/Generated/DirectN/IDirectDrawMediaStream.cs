﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddstream/nn-ddstream-idirectdrawmediastream
[GeneratedComInterface, Guid("f4104fce-9a70-11d0-8fde-00c04fd9189d")]
public partial interface IDirectDrawMediaStream : IMediaStream
{
    // https://learn.microsoft.com/windows/win32/api/ddstream/nf-ddstream-idirectdrawmediastream-getformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(out DDSURFACEDESC pDDSDCurrent, out IDirectDrawPalette ppDirectDrawPalette, out DDSURFACEDESC pDDSDDesired, out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/ddstream/nf-ddstream-idirectdrawmediastream-setformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormat(in DDSURFACEDESC pDDSurfaceDesc, IDirectDrawPalette pDirectDrawPalette);
    
    // https://learn.microsoft.com/windows/win32/api/ddstream/nf-ddstream-idirectdrawmediastream-getdirectdraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDirectDraw(out IDirectDraw ppDirectDraw);
    
    // https://learn.microsoft.com/windows/win32/api/ddstream/nf-ddstream-idirectdrawmediastream-setdirectdraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDirectDraw(IDirectDraw pDirectDraw);
    
    // https://learn.microsoft.com/windows/win32/api/ddstream/nf-ddstream-idirectdrawmediastream-createsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSample(IDirectDrawSurface pSurface, in RECT pRect, uint dwFlags, out IDirectDrawStreamSample ppSample);
    
    // https://learn.microsoft.com/windows/win32/api/ddstream/nf-ddstream-idirectdrawmediastream-gettimeperframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimePerFrame(out long pFrameTime);
}
