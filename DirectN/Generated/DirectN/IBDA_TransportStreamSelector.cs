#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("1dcfafe9-b45e-41b3-bb2a-561eb129ae98")]
public partial interface IBDA_TransportStreamSelector
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTSID(ushort usTSID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTSInformation(ref uint pulTSInformationBufferLen, nint /* byte array */ pbTSInformationBuffer);
}
