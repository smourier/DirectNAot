#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ifont
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("bef6e002-a874-101a-8bba-00aa00300cab")]
public partial interface IFont
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-get_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR pName);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-put_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Name(BSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-get_size
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Size(out CY pSize);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-put_size
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Size(CY size);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-get_bold
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Bold(out BOOL pBold);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-put_bold
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Bold(BOOL bold);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-get_italic
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Italic(out BOOL pItalic);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-put_italic
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Italic(BOOL italic);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-get_underline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Underline(out BOOL pUnderline);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-put_underline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Underline(BOOL underline);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-get_strikethrough
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Strikethrough(out BOOL pStrikethrough);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-put_strikethrough
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Strikethrough(BOOL strikethrough);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-get_weight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Weight(out short pWeight);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-put_weight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Weight(short weight);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-get_charset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Charset(out short pCharset);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-put_charset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Charset(short charset);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-get_hfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_hFont(out HFONT phFont);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFont>))] out IFont ppFont);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-isequal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqual([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFont>))] IFont pFontOther);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-setratio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRatio(int cyLogical, int cyHimetric);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-querytextmetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryTextMetrics(out TEXTMETRICW pTM);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-addrefhfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRefHfont(HFONT hFont);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-releasehfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseHfont(HFONT hFont);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ifont-sethdc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHdc(HDC hDC);
}
