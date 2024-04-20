﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-iisdbsiparser2
[GeneratedComInterface, Guid("900e4bb7-18cd-453f-98be-3be6aa211772")]
public partial interface IIsdbSiParser2 : IDvbSiParser2
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbsiparser2-getsdt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSDT(byte tableId, nint /* optional ushort */ pwTransportStreamId, out IISDB_SDT ppSDT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbsiparser2-getbit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBIT(byte tableId, nint /* optional ushort */ pwOriginalNetworkId, out IISDB_BIT ppBIT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbsiparser2-getnbit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNBIT(byte tableId, nint /* optional ushort */ pwOriginalNetworkId, out IISDB_NBIT ppNBIT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbsiparser2-getldt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLDT(byte tableId, nint /* optional ushort */ pwOriginalServiceId, out IISDB_LDT ppLDT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbsiparser2-getsdtt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSDTT(byte tableId, nint /* optional ushort */ pwTableIdExt, out IISDB_SDTT ppSDTT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbsiparser2-getcdt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCDT(byte tableId, byte bSectionNumber, nint /* optional ushort */ pwDownloadDataId, out IISDB_CDT ppCDT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbsiparser2-getemm
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEMM(ushort pid, ushort wTableIdExt, out IISDB_EMM ppEMM);
}
