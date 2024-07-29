#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaenginesrcelements
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("7a5e5354-b114-4c72-b991-3131d75032ea")]
public partial interface IMFMediaEngineSrcElements
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginesrcelements-getlength
    [PreserveSig]
    uint GetLength();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginesrcelements-geturl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetURL(uint index, out BSTR pURL);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginesrcelements-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(uint index, out BSTR pType);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginesrcelements-getmedia
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMedia(uint index, out BSTR pMedia);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginesrcelements-addelement
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddElement(BSTR pURL, BSTR pType, BSTR pMedia);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaenginesrcelements-removeallelements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllElements();
}
