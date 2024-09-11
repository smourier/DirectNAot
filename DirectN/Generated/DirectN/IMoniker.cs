#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-imoniker
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000000f-0000-0000-c000-000000000046")]
public partial interface IMoniker : IPersistStream
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-bindtoobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindToObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker?>))] IMoniker? pmkToLeft, in Guid riidResult, out nint /* void */ ppvResult);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-bindtostorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindToStorage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker?>))] IMoniker? pmkToLeft, in Guid riid, out nint /* void */ ppvObj);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-reduce
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reduce([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, uint dwReduceHowFar, ref IMoniker ppmkToLeft, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmkReduced);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-composewith
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ComposeWith([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pmkRight, BOOL fOnlyIfNotGeneric, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmkComposite);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-enum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enum(BOOL fForward, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumMoniker>))] out IEnumMoniker ppenumMoniker);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-isequal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqual([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pmkOtherMoniker);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-hash
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Hash(out uint pdwHash);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-isrunning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsRunning([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pmkToLeft, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pmkNewlyRunning);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-gettimeoflastchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimeOfLastChange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pmkToLeft, out FILETIME pFileTime);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-inverse
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Inverse([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmk);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-commonprefixwith
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommonPrefixWith([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pmkOther, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmkPrefix);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-relativepathto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RelativePathTo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pmkOther, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmkRelPath);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-getdisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayName([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pmkToLeft, out PWSTR ppszDisplayName);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-parsedisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParseDisplayName([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pmkToLeft, PWSTR pszDisplayName, out uint pchEaten, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmkOut);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-issystemmoniker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSystemMoniker(out uint pdwMksys);
}
