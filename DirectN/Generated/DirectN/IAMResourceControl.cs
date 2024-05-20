#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamresourcecontrol
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("8389d2d0-77d7-11d1-abe6-00a0c905f375")]
public partial interface IAMResourceControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamresourcecontrol-reserve
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reserve(uint dwFlags, nint /* optional void* */ pvReserved);
}
