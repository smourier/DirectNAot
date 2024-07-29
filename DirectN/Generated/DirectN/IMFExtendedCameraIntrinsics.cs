#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("687f6dac-6987-4750-a16a-734d1e7a10fe")]
public partial interface IMFExtendedCameraIntrinsics
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromBuffer(nint /* byte array */ pbBuffer, uint dwBufferSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferSize(out uint pdwBufferSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SerializeToBuffer(nint /* byte array */ pbBuffer, ref uint pdwBufferSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIntrinsicModelCount(out uint pdwCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIntrinsicModelByIndex(uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFExtendedCameraIntrinsicModel>))] out IMFExtendedCameraIntrinsicModel ppIntrinsicModel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddIntrinsicModel(IMFExtendedCameraIntrinsicModel pIntrinsicModel);
}
