#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/atscpsipparser/nn-atscpsipparser-iatscpsipparser
[GeneratedComInterface, Guid("b2c98995-5eb2-4fb1-b406-f3e8e2026a9a")]
public partial interface IAtscPsipParser
{
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatscpsipparser-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(nint punkMpeg2Data);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatscpsipparser-getpat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPAT(out IPAT ppPAT);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatscpsipparser-getcat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCAT(uint dwTimeout, out ICAT ppCAT);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatscpsipparser-getpmt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPMT(ushort pid, in ushort pwProgramNumber, out IPMT ppPMT);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatscpsipparser-gettsdt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTSDT(out ITSDT ppTSDT);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatscpsipparser-getmgt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMGT(out IATSC_MGT ppMGT);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatscpsipparser-getvct
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVCT(byte tableId, [MarshalAs(UnmanagedType.U4)] bool fGetNextTable, out IATSC_VCT ppVCT);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatscpsipparser-geteit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEIT(ushort pid, in ushort pwSourceId, uint dwTimeout, out IATSC_EIT ppEIT);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatscpsipparser-getett
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetETT(ushort pid, in ushort wSourceId, in ushort pwEventId, out IATSC_ETT ppETT);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatscpsipparser-getstt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSTT(out IATSC_STT ppSTT);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatscpsipparser-geteas
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEAS(ushort pid, out ISCTE_EAS ppEAS);
}
