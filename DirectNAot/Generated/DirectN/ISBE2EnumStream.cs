#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-isbe2enumstream
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f7611092-9fbc-46ec-a7c7-548ea78b71a4")]
public partial interface ISBE2EnumStream
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2enumstream-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cRequest, [In][Out][MarshalUsing(CountElementName = nameof(cRequest))] SBE2_STREAM_DESC[] pStreamDesc, out uint pcReceived);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2enumstream-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cRecords);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2enumstream-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2enumstream-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out ISBE2EnumStream ppIEnumStream);
}
