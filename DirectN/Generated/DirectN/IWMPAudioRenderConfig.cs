#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmprealestate/nn-wmprealestate-iwmpaudiorenderconfig
[GeneratedComInterface, Guid("e79c6349-5997-4ce4-917c-22a3391ec564")]
public partial interface IWMPAudioRenderConfig
{
    // https://learn.microsoft.com/windows/win32/api/wmprealestate/nf-wmprealestate-iwmpaudiorenderconfig-get_audiooutputdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_audioOutputDevice(ref BSTR pbstrOutputDevice);
    
    // https://learn.microsoft.com/windows/win32/api/wmprealestate/nf-wmprealestate-iwmpaudiorenderconfig-put_audiooutputdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_audioOutputDevice(BSTR bstrOutputDevice);
}
