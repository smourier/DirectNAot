﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefontfile
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("739d886a-cef5-47dc-8769-1a8b41bebbb0")]
public partial interface IDWriteFontFile
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfile-getreferencekey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReferenceKey(out nint fontFileReferenceKey, out uint fontFileReferenceKeySize);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfile-getloader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLoader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFileLoader>))] out IDWriteFontFileLoader fontFileLoader);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfile-analyze
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Analyze(out BOOL isSupportedFontType, out DWRITE_FONT_FILE_TYPE fontFileType, nint /* optional DWRITE_FONT_FACE_TYPE* */ fontFaceType, out uint numberOfFaces);
}
