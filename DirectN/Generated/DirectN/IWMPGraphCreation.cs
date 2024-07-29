#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmpservices/nn-wmpservices-iwmpgraphcreation
[GeneratedComInterface, Guid("bfb377e5-c594-4369-a970-de896d5ece74")]
public partial interface IWMPGraphCreation
{
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpgraphcreation-graphcreationprerender
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GraphCreationPreRender(nint pFilterGraph, nint pReserved);
    
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpgraphcreation-graphcreationpostrender
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GraphCreationPostRender(nint pFilterGraph);
    
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpgraphcreation-getgraphcreationflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGraphCreationFlags(ref uint pdwFlags);
}
