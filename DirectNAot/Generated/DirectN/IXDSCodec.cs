namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/encdec/nn-encdec-ixdscodec
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c4c4c4b3-0049-4e2b-98fb-9537f6ce516d")]
public partial interface IXDSCodec
{
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ixdscodec-get_xdstoratobjok
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_XDSToRatObjOK(out HRESULT pHrCoCreateRetVal);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ixdscodec-put_ccsubstreamservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CCSubstreamService(int SubstreamMask);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ixdscodec-get_ccsubstreamservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CCSubstreamService(out int pSubstreamMask);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ixdscodec-getcontentadvisoryrating
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContentAdvisoryRating(out int pRat, out int pPktSeqID, out int pCallSeqID, out long pTimeStart, out long pTimeEnd);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ixdscodec-getxdspacket
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXDSPacket(out int pXDSClassPkt, out int pXDSTypePkt, out BSTR pBstrXDSPkt, out int pPktSeqID, out int pCallSeqID, out long pTimeStart, out long pTimeEnd);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ixdscodec-getcurrlicenseexpdate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrLicenseExpDate(in ProtType protType, out int lpDateTime);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ixdscodec-getlasterrorcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastErrorCode();
}
