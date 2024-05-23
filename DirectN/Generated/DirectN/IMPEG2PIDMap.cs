#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-impeg2pidmap
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("afb6c2a1-2c41-11d3-8a60-0000f81e0e4a")]
public partial interface IMPEG2PIDMap
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-impeg2pidmap-mappid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MapPID(uint culPID, in uint pulPID, MEDIA_SAMPLE_CONTENT MediaSampleContent);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-impeg2pidmap-unmappid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnmapPID(uint culPID, in uint pulPID);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-impeg2pidmap-enumpidmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumPIDMap([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumPIDMap>))] out IEnumPIDMap pIEnumPIDMap);
}
