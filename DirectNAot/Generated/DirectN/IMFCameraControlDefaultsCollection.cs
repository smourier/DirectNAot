namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfcameracontroldefaultscollection
[GeneratedComInterface, Guid("92d43d0f-54a8-4bae-96da-356d259a5c26")]
public partial interface IMFCameraControlDefaultsCollection : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontroldefaultscollection-getcontrolcount
    [PreserveSig]
    uint GetControlCount();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontroldefaultscollection-getcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetControl(uint index, out IMFCameraControlDefaults configuration);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontroldefaultscollection-getoraddextendedcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOrAddExtendedControl(MF_CAMERA_CONTROL_CONFIGURATION_TYPE configType, uint constrolId, uint streamId, uint dataSize, out IMFCameraControlDefaults defaults);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontroldefaultscollection-getoraddcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOrAddControl(MF_CAMERA_CONTROL_CONFIGURATION_TYPE configType, in Guid controlSet, uint constrolId, uint controlSize, uint dataSize, out IMFCameraControlDefaults defaults);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontroldefaultscollection-removecontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveControl(in Guid controlSet, uint constrolId);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontroldefaultscollection-removeallcontrols
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllControls();
}
