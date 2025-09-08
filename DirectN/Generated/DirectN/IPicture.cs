#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ipicture
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("7bf80980-bf32-101a-8bbb-00aa00300cab")]
public partial interface IPicture
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-get_handle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Handle(out OLE_HANDLE pHandle);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-get_hpal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_hPal(out OLE_HANDLE phPal);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-get_type
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Type(out PICTYPE pType);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-get_width
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Width(out int pWidth);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-get_height
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Height(out int pHeight);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-render
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Render(HDC hDC, int x, int y, int cx, int cy, int xSrc, int ySrc, int cxSrc, int cySrc, in RECT pRcWBounds);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-set_hpal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT set_hPal(OLE_HANDLE hPal);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-get_curdc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurDC(out HDC phDC);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-selectpicture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectPicture(HDC hDCIn, out HDC phDCOut, out OLE_HANDLE phBmpOut);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-get_keeporiginalformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_KeepOriginalFormat(out BOOL pKeep);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-put_keeporiginalformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_KeepOriginalFormat(BOOL keep);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-picturechanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PictureChanged();
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-saveasfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveAsFile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pStream, BOOL fSaveMemCopy, out int pCbSize);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipicture-get_attributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Attributes(out uint pDwAttr);
}
