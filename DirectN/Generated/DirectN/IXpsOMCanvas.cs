#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomcanvas
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("221d1452-331e-47c6-87e9-6ccefb9b5ba3")]
public partial interface IXpsOMCanvas : IXpsOMVisual
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcanvas-getvisuals
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVisuals(out IXpsOMVisualCollection visuals);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcanvas-getusealiasededgemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUseAliasedEdgeMode([MarshalAs(UnmanagedType.U4)] out bool useAliasedEdgeMode);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcanvas-setusealiasededgemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUseAliasedEdgeMode([MarshalAs(UnmanagedType.U4)] bool useAliasedEdgeMode);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcanvas-getaccessibilityshortdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAccessibilityShortDescription(out PWSTR shortDescription);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcanvas-setaccessibilityshortdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAccessibilityShortDescription(PWSTR shortDescription);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcanvas-getaccessibilitylongdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAccessibilityLongDescription(out PWSTR longDescription);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcanvas-setaccessibilitylongdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAccessibilityLongDescription(PWSTR longDescription);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcanvas-getdictionary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDictionary(out IXpsOMDictionary resourceDictionary);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcanvas-getdictionarylocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDictionaryLocal(out IXpsOMDictionary resourceDictionary);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcanvas-setdictionarylocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDictionaryLocal(IXpsOMDictionary resourceDictionary);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcanvas-getdictionaryresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDictionaryResource(out IXpsOMRemoteDictionaryResource remoteDictionaryResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcanvas-setdictionaryresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDictionaryResource(IXpsOMRemoteDictionaryResource remoteDictionaryResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcanvas-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IXpsOMCanvas canvas);
}
