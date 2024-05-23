#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/nn-vfw-iavieditstream
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00020024-0000-0000-c000-000000000046")]
public partial interface IAVIEditStream
{
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavieditstream-cut
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cut(ref int plStart, ref int plLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppResult);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavieditstream-copy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Copy(ref int plStart, ref int plLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppResult);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavieditstream-paste
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Paste(ref int plPos, ref int plLength, IAVIStream pstream, int lStart, int lEnd);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavieditstream-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppResult);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavieditstream-setinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInfo(in AVISTREAMINFOW lpInfo, int cbInfo);
}
