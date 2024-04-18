﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefontfile
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("739d886a-cef5-47dc-8769-1a8b41bebbb0")]
public partial interface IDWriteFontFile
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfile-getreferencekey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetReferenceKey(out nint fontFileReferenceKey, out uint fontFileReferenceKeySize);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfile-getloader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetLoader(out IDWriteFontFileLoader fontFileLoader);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfile-analyze
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Analyze([MarshalAs(UnmanagedType.U4)] out bool isSupportedFontType, out DWRITE_FONT_FILE_TYPE fontFileType, nint /* DWRITE_FONT_FACE_TYPE */ fontFaceType, out uint numberOfFaces);
}
