#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-idvbtuningspace
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ada0b268-3b19-4e5b-acc4-49f852be13ba")]
public partial interface IDVBTuningSpace : ITuningSpace
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtuningspace-get_systemtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SystemType(out DVBSystemType SysType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtuningspace-put_systemtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SystemType(DVBSystemType SysType);
}
