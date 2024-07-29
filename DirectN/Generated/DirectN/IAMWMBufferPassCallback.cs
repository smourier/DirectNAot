#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dshowasf/nn-dshowasf-iamwmbufferpasscallback
[GeneratedComInterface, Guid("b25b8372-d2d2-44b2-8653-1b8dae332489")]
public partial interface IAMWMBufferPassCallback
{
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iamwmbufferpasscallback-notify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Notify(INSSBuffer3 pNSSBuffer3, IPin pPin, in long prtStart, in long prtEnd);
}
