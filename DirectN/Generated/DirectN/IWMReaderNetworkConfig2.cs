#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreadernetworkconfig2
[GeneratedComInterface, Guid("d979a853-042b-4050-8387-c939db22013f")]
public partial interface IWMReaderNetworkConfig2 : IWMReaderNetworkConfig
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig2-getenablecontentcaching
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnableContentCaching(out BOOL pfEnableContentCaching);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig2-setenablecontentcaching
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnableContentCaching(BOOL fEnableContentCaching);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig2-getenablefastcache
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnableFastCache(out BOOL pfEnableFastCache);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig2-setenablefastcache
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnableFastCache(BOOL fEnableFastCache);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig2-getacceleratedstreamingduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAcceleratedStreamingDuration(out ulong pcnsAccelDuration);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig2-setacceleratedstreamingduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAcceleratedStreamingDuration(ulong cnsAccelDuration);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig2-getautoreconnectlimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAutoReconnectLimit(out uint pdwAutoReconnectLimit);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig2-setautoreconnectlimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAutoReconnectLimit(uint dwAutoReconnectLimit);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig2-getenableresends
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnableResends(out BOOL pfEnableResends);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig2-setenableresends
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnableResends(BOOL fEnableResends);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig2-getenablethinning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnableThinning(out BOOL pfEnableThinning);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig2-setenablethinning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnableThinning(BOOL fEnableThinning);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig2-getmaxnetpacketsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxNetPacketSize(out uint pdwMaxNetPacketSize);
}
