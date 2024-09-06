#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iatsclocator
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("bf8d986f-8c2b-4131-94d7-4d3d9fcc21ef")]
public partial interface IATSCLocator : IDigitalLocator
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsclocator-get_physicalchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PhysicalChannel(out int PhysicalChannel);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsclocator-put_physicalchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PhysicalChannel(int PhysicalChannel);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsclocator-get_tsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TSID(out int TSID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsclocator-put_tsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TSID(int TSID);
}
