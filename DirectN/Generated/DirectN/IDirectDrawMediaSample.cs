#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amstream/nn-amstream-idirectdrawmediasample
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("ab6b4afe-f6e4-11d0-900d-00c04fd9189d")]
public partial interface IDirectDrawMediaSample
{
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-idirectdrawmediasample-getsurfaceandreleaselock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSurfaceAndReleaseLock([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawSurface>))] out IDirectDrawSurface ppDirectDrawSurface, out RECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-idirectdrawmediasample-lockmediasamplepointer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockMediaSamplePointer();
}
