#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfcameraconfigurationmanager
[GeneratedComInterface, Guid("a624f617-4704-4206-8a6d-ebda4a093985")]
public partial interface IMFCameraConfigurationManager
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameraconfigurationmanager-loaddefaults
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadDefaults(IMFAttributes cameraAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCameraControlDefaultsCollection>))] out IMFCameraControlDefaultsCollection configurations);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameraconfigurationmanager-savedefaults
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveDefaults(IMFCameraControlDefaultsCollection configurations);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameraconfigurationmanager-shutdown
    [PreserveSig]
    void Shutdown();
}
