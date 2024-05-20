#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvbdatabroadcastiddescriptor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5f26f518-65c8-4048-91f2-9290f59f7b90")]
public partial interface IDvbDataBroadcastIDDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbdatabroadcastiddescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbdatabroadcastiddescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbdatabroadcastiddescriptor-getdatabroadcastid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataBroadcastID(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbdatabroadcastiddescriptor-getidselectorbytes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIDSelectorBytes(nint /* byte array */ pbLen, nint /* byte array */ pbVal);
}
