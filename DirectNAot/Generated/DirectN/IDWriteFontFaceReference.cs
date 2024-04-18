namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontfacereference
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("5e7fa7ca-dde3-424c-89f0-9fcd6fed58cd")]
public partial interface IDWriteFontFaceReference
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-createfontface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateFontFace(out IDWriteFontFace3 fontFace);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-createfontfacewithsimulations
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateFontFaceWithSimulations(DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, out IDWriteFontFace3 fontFace);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool Equals(IDWriteFontFaceReference fontFaceReference);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getfontfaceindex
    [PreserveSig]
    public uint GetFontFaceIndex();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getsimulations
    [PreserveSig]
    public DWRITE_FONT_SIMULATIONS GetSimulations();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getfontfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontFile(out IDWriteFontFile fontFile);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getlocalfilesize
    [PreserveSig]
    public ulong GetLocalFileSize();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getfilesize
    [PreserveSig]
    public ulong GetFileSize();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getfiletime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFileTime(out FILETIME lastWriteTime);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-getlocality
    [PreserveSig]
    public DWRITE_LOCALITY GetLocality();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-enqueuefontdownloadrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnqueueFontDownloadRequest();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-enqueuecharacterdownloadrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnqueueCharacterDownloadRequest(PWSTR characters, uint characterCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-enqueueglyphdownloadrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnqueueGlyphDownloadRequest(in ushort glyphIndices, uint glyphCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontfacereference-enqueuefilefragmentdownloadrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnqueueFileFragmentDownloadRequest(ulong fileOffset, ulong fragmentSize);
}
