#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-ibindctx
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000000e-0000-0000-c000-000000000046")]
public partial interface IBindCtx
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ibindctx-registerobjectbound
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterObjectBound(nint punk);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ibindctx-revokeobjectbound
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RevokeObjectBound(nint punk);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ibindctx-releaseboundobjects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseBoundObjects();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ibindctx-setbindoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBindOptions(in BIND_OPTS pbindopts);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ibindctx-getbindoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBindOptions(ref BIND_OPTS pbindopts);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ibindctx-getrunningobjecttable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRunningObjectTable(out IRunningObjectTable pprot);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ibindctx-registerobjectparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterObjectParam(PWSTR pszKey, nint punk);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ibindctx-getobjectparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectParam(PWSTR pszKey, out nint ppunk);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ibindctx-enumobjectparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumObjectParam(out IEnumString ppenum);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ibindctx-revokeobjectparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RevokeObjectParam(PWSTR pszKey);
}
