#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamstreamconfig
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("c6e13340-30ac-11d0-a18c-00a0c9118956")]
public partial interface IAMStreamConfig
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamstreamconfig-setformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormat(in AM_MEDIA_TYPE pmt);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamstreamconfig-getformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(out nint ppmt);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamstreamconfig-getnumberofcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfCapabilities(out int piCount, out int piSize);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamstreamconfig-getstreamcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamCaps(int iIndex, out nint ppmt, nint /* byte array */ pSCC);
}
