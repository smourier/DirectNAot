#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-idvbtuningspace2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("843188b4-ce62-43db-966b-8145a094e040")]
public partial interface IDVBTuningSpace2 : IDVBTuningSpace
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtuningspace2-get_networkid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NetworkID(out int NetworkID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtuningspace2-put_networkid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_NetworkID(int NetworkID);
}
