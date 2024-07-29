#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nn-audioenginebaseapo-iaudiodevicemodulesclient
[GeneratedComInterface, Guid("98f37dac-d0b6-49f5-896a-aa4d169a4c48")]
public partial interface IAudioDeviceModulesClient
{
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudiodevicemodulesclient-setaudiodevicemodulesmanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAudioDeviceModulesManager(nint pAudioDeviceModulesManager);
}
