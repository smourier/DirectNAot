#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ituningspaces
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("901284e4-33fe-4b69-8d63-634a596f3756")]
public partial interface ITuningSpaces : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspaces-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspaces-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out IEnumVARIANT NewEnum);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspaces-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(VARIANT varIndex, out ITuningSpace TuningSpace);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspaces-get_enumtuningspaces
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EnumTuningSpaces(out IEnumTuningSpaces NewEnum);
}
