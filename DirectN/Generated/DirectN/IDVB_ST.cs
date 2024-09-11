#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvb_st
[GeneratedComInterface, Guid("4d5b9f23-2a02-45de-bcda-5d5dbfbfbe62")]
public partial interface IDVB_ST
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_st-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISectionList>))] ISectionList pSectionList);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_st-getdatalength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataLength(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvb_st-getdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(out nint /* byte array */ ppData);
}
