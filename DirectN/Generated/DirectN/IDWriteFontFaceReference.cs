#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontfacereference
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("5e7fa7ca-dde3-424c-89f0-9fcd6fed58cd")]
public partial interface IDWriteFontFaceReference
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-createfontface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace3>))] out IDWriteFontFace3 fontFace);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-createfontfacewithsimulations
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFaceWithSimulations(DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace3>))] out IDWriteFontFace3 fontFace);
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL Equals([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFaceReference>))] IDWriteFontFaceReference fontFaceReference);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getfontfaceindex
    [PreserveSig]
    uint GetFontFaceIndex();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getsimulations
    [PreserveSig]
    DWRITE_FONT_SIMULATIONS GetSimulations();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getfontfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFile>))] out IDWriteFontFile fontFile);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getlocalfilesize
    [PreserveSig]
    ulong GetLocalFileSize();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getfilesize
    [PreserveSig]
    ulong GetFileSize();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getfiletime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileTime(out FILETIME lastWriteTime);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getlocality
    [PreserveSig]
    DWRITE_LOCALITY GetLocality();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-enqueuefontdownloadrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnqueueFontDownloadRequest();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-enqueuecharacterdownloadrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnqueueCharacterDownloadRequest([MarshalUsing(CountElementName = nameof(characterCount))] PWSTR characters, uint characterCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-enqueueglyphdownloadrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnqueueGlyphDownloadRequest([In][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] glyphIndices, uint glyphCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-enqueuefilefragmentdownloadrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnqueueFileFragmentDownloadRequest(ulong fileOffset, ulong fragmentSize);
}
