#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/nn-evr-imfdesiredsample
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("56c294d0-753e-4260-8d61-a3d8820b1d54")]
public partial interface IMFDesiredSample
{
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfdesiredsample-getdesiredsampletimeandduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesiredSampleTimeAndDuration(out long phnsSampleTime, out long phnsSampleDuration);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfdesiredsample-setdesiredsampletimeandduration
    [PreserveSig]
    void SetDesiredSampleTimeAndDuration(long hnsSampleTime, long hnsSampleDuration);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfdesiredsample-clear
    [PreserveSig]
    void Clear();
}
