#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iksjackdescription
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("4509f757-2d46-4637-8e62-ce7db944f57b")]
public partial interface IKsJackDescription
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iksjackdescription-getjackcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetJackCount(out uint pcJacks);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iksjackdescription-getjackdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetJackDescription(uint nJack, out KSJACK_DESCRIPTION pDescription);
}
