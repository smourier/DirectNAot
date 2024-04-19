namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iatsccomponenttype
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("fc189e4d-7bd4-4125-b3b3-3a76a332cc96")]
public partial interface IATSCComponentType : IMPEG2ComponentType
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsccomponenttype-get_flags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Flags(out int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsccomponenttype-put_flags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Flags(int flags);
}
