#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomdashcollection
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("081613f4-74eb-48f2-83b3-37a9ce2d7dc6")]
public partial interface IXpsOMDashCollection
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdashcollection-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdashcollection-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint index, out XPS_DASH dash);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdashcollection-insertat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertAt(uint index, in XPS_DASH dash);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdashcollection-removeat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAt(uint index);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdashcollection-setat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAt(uint index, in XPS_DASH dash);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdashcollection-append
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Append(in XPS_DASH dash);
}
