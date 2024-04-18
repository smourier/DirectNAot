namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationframeinfoprovider
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("fb759dba-6f4c-4c01-874e-19c8a05907f9")]
public partial interface IDirectManipulationFrameInfoProvider
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationframeinfoprovider-getnextframeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetNextFrameInfo(out ulong time, out ulong processTime, out ulong compositionTime);
}
