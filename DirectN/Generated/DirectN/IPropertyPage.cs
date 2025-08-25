#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ipropertypage
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b196b28d-bab4-101a-b69c-00aa00341d07")]
public partial interface IPropertyPage
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypage-setpagesite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPageSite([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyPageSite>))] IPropertyPageSite pPageSite);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypage-activate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Activate(HWND hWndParent, in RECT pRect, BOOL bModal);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypage-deactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Deactivate();
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypage-getpageinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPageInfo(out PROPPAGEINFO pPageInfo);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypage-setobjects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetObjects(uint cObjects, [In][Out][MarshalUsing(CountElementName = nameof(cObjects))] nint[] ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypage-show
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Show(uint nCmdShow);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypage-move
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Move(in RECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypage-ispagedirty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsPageDirty();
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypage-apply
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Apply();
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypage-help
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Help(PWSTR pszHelpDir);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypage-translateaccelerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateAccelerator(in MSG pMsg);
}
