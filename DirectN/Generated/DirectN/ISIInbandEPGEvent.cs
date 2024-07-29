#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("7e47913a-5a89-423d-9a2b-e15168858934")]
public partial interface ISIInbandEPGEvent
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SIObjectEvent(IDVB_EIT2 pIDVB_EIT, uint dwTable_ID, uint dwService_ID);
}
