#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-impeg2streamidmap
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("d0e04c47-25b8-4369-925a-362a01d95444")]
public partial interface IMPEG2StreamIdMap
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-impeg2streamidmap-mapstreamid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MapStreamId(uint ulStreamId, uint MediaSampleContent, uint ulSubstreamFilterValue, int iDataOffset);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-impeg2streamidmap-unmapstreamid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnmapStreamId(uint culStreamId, [In][MarshalUsing(CountElementName = nameof(culStreamId))] uint[] pulStreamId);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-impeg2streamidmap-enumstreamidmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumStreamIdMap([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumStreamIdMap>))] out IEnumStreamIdMap ppIEnumStreamIdMap);
}
