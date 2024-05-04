#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ced153e7-3606-11d2-b9f9-0000f875ac12")]
public partial interface IDirectMusicThru
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ThruChannel(uint dwSourceChannelGroup, uint dwSourceChannel, uint dwDestinationChannelGroup, uint dwDestinationChannel, IDirectMusicPort pDestinationPort);
}
