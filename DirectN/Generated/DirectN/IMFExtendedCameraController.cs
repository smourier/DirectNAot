#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfextendedcameracontroller
[GeneratedComInterface, Guid("b91ebfee-ca03-4af4-8a82-a31752f4a0fc")]
public partial interface IMFExtendedCameraController
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfextendedcameracontroller-getextendedcameracontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExtendedCameraControl(uint dwStreamIndex, uint ulPropertyId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFExtendedCameraControl>))] out IMFExtendedCameraControl ppControl);
}
