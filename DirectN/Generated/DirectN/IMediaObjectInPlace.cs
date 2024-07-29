#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mediaobj/nn-mediaobj-imediaobjectinplace
[GeneratedComInterface, Guid("651b9ad0-0fc7-4aa9-9538-d89931010741")]
public partial interface IMediaObjectInPlace
{
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobjectinplace-process
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Process(uint ulSize, nint /* byte array */ pData, long refTimeStart, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobjectinplace-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMediaObjectInPlace>))] out IMediaObjectInPlace ppMediaObject);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediaobjectinplace-getlatency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLatency(out long pLatencyTime);
}
