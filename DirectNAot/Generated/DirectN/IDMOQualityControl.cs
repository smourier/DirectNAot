#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mediaobj/nn-mediaobj-idmoqualitycontrol
[GeneratedComInterface, Guid("65abea96-cf36-453f-af8a-705e98f16260")]
public partial interface IDMOQualityControl
{
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-idmoqualitycontrol-setnow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNow(long rtNow);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-idmoqualitycontrol-setstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStatus(uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-idmoqualitycontrol-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out uint pdwFlags);
}
