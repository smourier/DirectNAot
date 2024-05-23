#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsompage
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("d3e18888-f120-4fee-8c68-35296eae91d4")]
public partial interface IXpsOMPage : IXpsOMPart
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-getowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOwner([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPageReference>))] out IXpsOMPageReference pageReference);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-getvisuals
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVisuals([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMVisualCollection>))] out IXpsOMVisualCollection visuals);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-getpagedimensions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPageDimensions(out XPS_SIZE pageDimensions);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-setpagedimensions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPageDimensions(in XPS_SIZE pageDimensions);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-getcontentbox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContentBox(out XPS_RECT contentBox);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-setcontentbox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContentBox(in XPS_RECT contentBox);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-getbleedbox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBleedBox(out XPS_RECT bleedBox);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-setbleedbox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBleedBox(in XPS_RECT bleedBox);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-getlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguage(out PWSTR language);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-setlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLanguage(PWSTR language);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out PWSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-setname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetName(PWSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-getishyperlinktarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIsHyperlinkTarget([MarshalAs(UnmanagedType.U4)] out bool isHyperlinkTarget);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-setishyperlinktarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIsHyperlinkTarget([MarshalAs(UnmanagedType.U4)] bool isHyperlinkTarget);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-getdictionary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDictionary([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDictionary>))] out IXpsOMDictionary resourceDictionary);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-getdictionarylocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDictionaryLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDictionary>))] out IXpsOMDictionary resourceDictionary);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-setdictionarylocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDictionaryLocal(IXpsOMDictionary resourceDictionary);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-getdictionaryresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDictionaryResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMRemoteDictionaryResource>))] out IXpsOMRemoteDictionaryResource remoteDictionaryResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-setdictionaryresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDictionaryResource(IXpsOMRemoteDictionaryResource remoteDictionaryResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-write
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Write(ISequentialStream stream, [MarshalAs(UnmanagedType.U4)] bool optimizeMarkupSize);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-generateunusedlookupkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateUnusedLookupKey(XPS_OBJECT_TYPE type, out PWSTR key);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompage-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPage>))] out IXpsOMPage page);
}
