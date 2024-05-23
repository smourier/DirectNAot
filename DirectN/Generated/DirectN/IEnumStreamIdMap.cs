#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ienumstreamidmap
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("945c1566-6202-46fc-96c7-d87f289c6534")]
public partial interface IEnumStreamIdMap
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumstreamidmap-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cRequest, [In][Out][MarshalUsing(CountElementName = nameof(cRequest))] STREAM_ID_MAP[] pStreamIdMap, nint /* optional uint* */ pcReceived);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumstreamidmap-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cRecords);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumstreamidmap-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumstreamidmap-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumStreamIdMap>))] out IEnumStreamIdMap ppIEnumStreamIdMap);
}
