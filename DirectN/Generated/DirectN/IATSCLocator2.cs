#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iatsclocator2
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("612aa885-66cf-4090-ba0a-566f5312e4ca")]
public partial interface IATSCLocator2 : IATSCLocator
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsclocator2-get_programnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ProgramNumber(out int ProgramNumber);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsclocator2-put_programnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ProgramNumber(int ProgramNumber);
}
