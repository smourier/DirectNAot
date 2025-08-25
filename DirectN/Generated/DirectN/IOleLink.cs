#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-iolelink
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000011d-0000-0000-c000-000000000046")]
public partial interface IOleLink
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolelink-setupdateoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUpdateOptions(uint dwUpdateOpt);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolelink-getupdateoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUpdateOptions(out uint pdwUpdateOpt);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolelink-setsourcemoniker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourceMoniker([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pmk, in Guid rclsid);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolelink-getsourcemoniker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceMoniker([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmk);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolelink-setsourcedisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourceDisplayName(PWSTR pszStatusText);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolelink-getsourcedisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceDisplayName(out PWSTR ppszDisplayName);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolelink-bindtosource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindToSource(uint bindflags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolelink-bindifrunning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindIfRunning();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolelink-getboundsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBoundSource(out nint ppunk);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolelink-unbindsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnbindSource();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolelink-update
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Update([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc);
}
