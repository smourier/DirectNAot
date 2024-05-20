#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-itunerequest
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("07ddc146-fc3d-11d2-9d8c-00c04f72d980")]
public partial interface ITuneRequest : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-itunerequest-get_tuningspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TuningSpace(out ITuningSpace TuningSpace);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-itunerequest-get_components
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Components(out IComponents Components);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-itunerequest-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out ITuneRequest NewTuneRequest);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-itunerequest-get_locator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Locator(out ILocator Locator);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-itunerequest-put_locator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Locator(ILocator Locator);
}
