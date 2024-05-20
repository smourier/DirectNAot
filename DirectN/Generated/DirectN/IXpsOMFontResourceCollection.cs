#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomfontresourcecollection
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("70b4a6bb-88d4-4fa8-aaf9-6d9c596fdbad")]
public partial interface IXpsOMFontResourceCollection
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomfontresourcecollection-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomfontresourcecollection-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint index, out IXpsOMFontResource value);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomfontresourcecollection-setat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAt(uint index, IXpsOMFontResource value);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomfontresourcecollection-insertat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertAt(uint index, IXpsOMFontResource value);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomfontresourcecollection-append
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Append(IXpsOMFontResource value);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomfontresourcecollection-removeat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAt(uint index);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomfontresourcecollection-getbypartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetByPartName(IOpcPartUri partName, out IXpsOMFontResource part);
}
