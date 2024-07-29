#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e539cd90-a8b4-11d1-8189-00a0c9062802")]
public partial interface IKsPinPipe
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsGetPinFramingCache(out nint FramingEx, out FRAMING_PROP FramingProp, FRAMING_CACHE_OPS Option);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsSetPinFramingCache(in KSALLOCATOR_FRAMING_EX FramingEx, in FRAMING_PROP FramingProp, FRAMING_CACHE_OPS Option);
    
    [PreserveSig]
    [return: MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPin>))]
    IPin KsGetConnectedPin();
    
    [PreserveSig]
    [return: MarshalUsing(typeof(UniqueComInterfaceMarshaller<IKsAllocatorEx>))]
    IKsAllocatorEx KsGetPipe(KSPEEKOPERATION Operation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsSetPipe(IKsAllocatorEx KsAllocator);
    
    [PreserveSig]
    uint KsGetPipeAllocatorFlag();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsSetPipeAllocatorFlag(uint Flag);
    
    [PreserveSig]
    Guid KsGetPinBusCache();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsSetPinBusCache(Guid Bus);
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    PWSTR KsGetPinName();
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    PWSTR KsGetFilterName();
}
