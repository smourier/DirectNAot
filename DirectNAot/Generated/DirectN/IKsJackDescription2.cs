namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iksjackdescription2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("478f3a9b-e0c9-4827-9228-6f5505ffe76a")]
public partial interface IKsJackDescription2
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iksjackdescription2-getjackcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetJackCount(out uint pcJacks);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iksjackdescription2-getjackdescription2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetJackDescription2(uint nJack, out KSJACK_DESCRIPTION2 pDescription2);
}
