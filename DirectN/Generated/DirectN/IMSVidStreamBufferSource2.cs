#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambuffersource2
[GeneratedComInterface, Guid("e4ba9059-b1ce-40d8-b9a0-d4ea4a9989d3")]
public partial interface IMSVidStreamBufferSource2 : IMSVidStreamBufferSource
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersource2-put_rateex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RateEx(double dwRate, uint dwFramesPerSecond);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersource2-get_audiocounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioCounter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersource2-get_videocounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VideoCounter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersource2-get_cccounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CCCounter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersource2-get_wstcounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WSTCounter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppUnk);
}
