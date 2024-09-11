#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nn-audioengineendpoint-ihardwareaudioenginebase
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("eddce3e4-f3c1-453a-b461-223563cbd886")]
public partial interface IHardwareAudioEngineBase
{
    // https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nf-audioengineendpoint-ihardwareaudioenginebase-getavailableoffloadconnectorcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailableOffloadConnectorCount(PWSTR _pwstrDeviceId, uint _uConnectorId, out uint _pAvailableConnectorInstanceCount);
    
    // https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nf-audioengineendpoint-ihardwareaudioenginebase-getengineformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEngineFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMMDevice>))] IMMDevice pDevice, BOOL _bRequestDeviceFormat, ref WAVEFORMATEX _ppwfxFormat);
    
    // https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nf-audioengineendpoint-ihardwareaudioenginebase-setenginedeviceformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEngineDeviceFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMMDevice>))] IMMDevice pDevice, ref WAVEFORMATEX _pwfxFormat);
    
    // https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nf-audioengineendpoint-ihardwareaudioenginebase-setgfxstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGfxState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMMDevice>))] IMMDevice pDevice, BOOL _bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nf-audioengineendpoint-ihardwareaudioenginebase-getgfxstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGfxState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMMDevice>))] IMMDevice pDevice, out BOOL _pbEnable);
}
