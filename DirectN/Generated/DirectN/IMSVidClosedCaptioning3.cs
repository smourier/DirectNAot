#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidclosedcaptioning3
[GeneratedComInterface, Guid("c8638e8a-7625-4c51-9366-2f40a9831fc0")]
public partial interface IMSVidClosedCaptioning3 : IMSVidClosedCaptioning2
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidclosedcaptioning3-get_teletextfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TeleTextFilter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint punkTTFilter);
}
