namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsompagereferencecollection
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ca16ba4d-e7b9-45c5-958b-f98022473745")]
public partial interface IXpsOMPageReferenceCollection
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereferencecollection-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCount(out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereferencecollection-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAt(uint index, out IXpsOMPageReference pageReference);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereferencecollection-insertat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT InsertAt(uint index, IXpsOMPageReference pageReference);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereferencecollection-removeat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RemoveAt(uint index);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereferencecollection-setat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAt(uint index, IXpsOMPageReference pageReference);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereferencecollection-append
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Append(IXpsOMPageReference pageReference);
}
