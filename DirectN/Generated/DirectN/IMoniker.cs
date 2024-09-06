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
    HRESULT BindToObject(IBindCtx pbc, IMoniker? pmkToLeft, in Guid riidResult, out nint /* void */ ppvResult);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-bindtostorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindToStorage(IBindCtx pbc, IMoniker? pmkToLeft, in Guid riid, out nint /* void */ ppvObj);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-reduce
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reduce(IBindCtx pbc, uint dwReduceHowFar, ref IMoniker ppmkToLeft, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmkReduced);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-composewith
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ComposeWith(IMoniker pmkRight, BOOL fOnlyIfNotGeneric, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmkComposite);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-enum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enum(BOOL fForward, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumMoniker>))] out IEnumMoniker ppenumMoniker);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-isequal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqual(IMoniker pmkOtherMoniker);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-hash
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Hash(out uint pdwHash);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-isrunning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsRunning(IBindCtx pbc, IMoniker pmkToLeft, IMoniker pmkNewlyRunning);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-gettimeoflastchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimeOfLastChange(IBindCtx pbc, IMoniker pmkToLeft, out FILETIME pFileTime);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-inverse
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Inverse([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmk);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-commonprefixwith
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommonPrefixWith(IMoniker pmkOther, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmkPrefix);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-relativepathto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RelativePathTo(IMoniker pmkOther, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmkRelPath);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-getdisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayName(IBindCtx pbc, IMoniker pmkToLeft, out PWSTR ppszDisplayName);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-parsedisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParseDisplayName(IBindCtx pbc, IMoniker pmkToLeft, PWSTR pszDisplayName, out uint pchEaten, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmkOut);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imoniker-issystemmoniker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSystemMoniker(out uint pdwMksys);
}
