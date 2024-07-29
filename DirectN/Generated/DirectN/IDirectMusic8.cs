#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("2d3629f7-813d-4939-8508-f05c6b75fd97")]
public partial interface IDirectMusic8 : IDirectMusic
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetExternalMasterClock(IReferenceClock pClock);
}
