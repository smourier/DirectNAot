#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmpservices/nn-wmpservices-iwmpservices
[GeneratedComInterface, Guid("afb6b76b-1e20-4198-83b3-191db6e0b149")]
public partial interface IWMPServices
{
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpservices-getstreamtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamTime(ref long prt);
    
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpservices-getstreamstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamState(ref WMPServices_StreamState pState);
}
