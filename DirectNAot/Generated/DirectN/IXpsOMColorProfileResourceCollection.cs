namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomcolorprofileresourcecollection
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("12759630-5fba-4283-8f7d-cca849809edb")]
public partial interface IXpsOMColorProfileResourceCollection
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcolorprofileresourcecollection-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCount(out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcolorprofileresourcecollection-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAt(uint index, out IXpsOMColorProfileResource @object);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcolorprofileresourcecollection-insertat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT InsertAt(uint index, IXpsOMColorProfileResource @object);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcolorprofileresourcecollection-removeat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RemoveAt(uint index);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcolorprofileresourcecollection-setat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAt(uint index, IXpsOMColorProfileResource @object);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcolorprofileresourcecollection-append
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Append(IXpsOMColorProfileResource @object);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcolorprofileresourcecollection-getbypartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetByPartName(IOpcPartUri partName, out IXpsOMColorProfileResource part);
}
