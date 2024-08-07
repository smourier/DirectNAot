﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvbsiparser
[GeneratedComInterface, Guid("b758a7bd-14dc-449d-b828-35909acb3b1e")]
public partial interface IDvbSiParser
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(nint punkMpeg2Data);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-getpat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPAT([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPAT>))] out IPAT ppPAT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-getcat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCAT(uint dwTimeout, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICAT>))] out ICAT ppCAT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-getpmt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPMT(ushort pid, nint /* optional ushort* */ pwProgramNumber, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPMT>))] out IPMT ppPMT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-gettsdt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTSDT([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITSDT>))] out ITSDT ppTSDT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-getnit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNIT(byte tableId, nint /* optional ushort* */ pwNetworkId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDVB_NIT>))] out IDVB_NIT ppNIT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-getsdt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSDT(byte tableId, nint /* optional ushort* */ pwTransportStreamId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDVB_SDT>))] out IDVB_SDT ppSDT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-geteit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEIT(byte tableId, nint /* optional ushort* */ pwServiceId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDVB_EIT>))] out IDVB_EIT ppEIT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-getbat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBAT(nint /* optional ushort* */ pwBouquetId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDVB_BAT>))] out IDVB_BAT ppBAT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-getrst
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRST(uint dwTimeout, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDVB_RST>))] out IDVB_RST ppRST);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-getst
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetST(ushort pid, uint dwTimeout, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDVB_ST>))] out IDVB_ST ppST);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-gettdt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTDT([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDVB_TDT>))] out IDVB_TDT ppTDT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-gettot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTOT([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDVB_TOT>))] out IDVB_TOT ppTOT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-getdit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDIT(uint dwTimeout, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDVB_DIT>))] out IDVB_DIT ppDIT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbsiparser-getsit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSIT(uint dwTimeout, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDVB_SIT>))] out IDVB_SIT ppSIT);
}
