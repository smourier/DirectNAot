#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-ioleclientsite
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000118-0000-0000-c000-000000000046")]
public partial interface IOleClientSite
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleclientsite-saveobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveObject();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleclientsite-getmoniker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMoniker(uint dwAssign, uint dwWhichMoniker, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmk);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleclientsite-getcontainer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleContainer>))] out IOleContainer ppContainer);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleclientsite-showobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowObject();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleclientsite-onshowwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnShowWindow(BOOL fShow);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleclientsite-requestnewobjectlayout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RequestNewObjectLayout();
}
