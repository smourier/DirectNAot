#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("be7a9cce-5f9e-11d2-960f-00c04f8ee628")]
public partial interface ISpEventSource : ISpNotifySource
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInterest(ulong ullEventInterest, ulong ullQueuedInterest);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEvents(uint ulCount, ref SPEVENT pEventArray, ref uint pulFetched);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInfo(ref SPEVENTSOURCEINFO pInfo);
}
