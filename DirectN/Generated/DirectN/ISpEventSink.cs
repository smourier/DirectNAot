#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("be7a9cc9-5f9e-11d2-960f-00c04f8ee628")]
public partial interface ISpEventSink
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEvents(in SPEVENT pEventArray, uint ulCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEventInterest(ref ulong pullEventInterest);
}
