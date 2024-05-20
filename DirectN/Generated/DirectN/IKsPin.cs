#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectShow/ikspin
[GeneratedComInterface, Guid("b61178d1-a2d9-11cf-9e53-00aa00a216a1")]
public partial interface IKsPin
{
    // https://learn.microsoft.com/windows/win32/DirectShow/ikspin-ksquerymediums
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsQueryMediums(out nint MediumList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsQueryInterfaces(out nint InterfaceList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsCreateSinkPinHandle(in KSIDENTIFIER Interface, in KSIDENTIFIER Medium);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsGetCurrentCommunication(nint /* optional KSPIN_COMMUNICATION* */ Communication, nint /* optional KSIDENTIFIER* */ Interface, nint /* optional KSIDENTIFIER* */ Medium);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsPropagateAcquire();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsDeliver(IMediaSample Sample, uint Flags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsMediaSamplesCompleted(in KSSTREAM_SEGMENT StreamSegment);
    
    [PreserveSig]
    IMemAllocator KsPeekAllocator(KSPEEKOPERATION Operation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsReceiveAllocator(IMemAllocator? MemAllocator);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsRenegotiateAllocator();
    
    [PreserveSig]
    int KsIncrementPendingIoCount();
    
    [PreserveSig]
    int KsDecrementPendingIoCount();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsQualityNotify(uint Proportion, long TimeDelta);
}
