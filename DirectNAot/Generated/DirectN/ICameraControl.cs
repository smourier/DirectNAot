namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vidcap/nn-vidcap-icameracontrol
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("2ba1785d-4d1b-44ef-85e8-c7f1d3f20184")]
public partial interface ICameraControl
{
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_exposure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Exposure(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_exposure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Exposure(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_exposure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Exposure(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_focus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Focus(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_focus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Focus(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_focus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Focus(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_iris
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Iris(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_iris
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Iris(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_iris
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Iris(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_zoom
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Zoom(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_zoom
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Zoom(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_zoom
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Zoom(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_focallengths
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FocalLengths(out int plOcularFocalLength, out int plObjectiveFocalLengthMin, out int plObjectiveFocalLengthMax);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_pan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Pan(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_pan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Pan(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_pan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Pan(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_tilt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Tilt(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_tilt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Tilt(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_tilt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Tilt(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_pantilt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PanTilt(out int pPanValue, out int pTiltValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_pantilt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PanTilt(int PanValue, int TiltValue, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_roll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Roll(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_roll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Roll(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_roll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Roll(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_exposurerelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ExposureRelative(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_exposurerelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ExposureRelative(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_exposurerelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_ExposureRelative(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_focusrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FocusRelative(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_focusrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FocusRelative(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_focusrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_FocusRelative(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_irisrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IrisRelative(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_irisrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IrisRelative(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_irisrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_IrisRelative(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_zoomrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ZoomRelative(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_zoomrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ZoomRelative(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_zoomrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_ZoomRelative(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_panrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PanRelative(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_panrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PanRelative(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_tiltrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TiltRelative(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_tiltrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TiltRelative(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_tiltrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_TiltRelative(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_pantiltrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PanTiltRelative(out int pPanValue, out int pTiltValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_pantiltrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PanTiltRelative(int PanValue, int TiltValue, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_panrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_PanRelative(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_rollrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RollRelative(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_rollrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RollRelative(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-getrange_rollrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_RollRelative(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_scanmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ScanMode(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_scanmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ScanMode(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-get_privacymode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PrivacyMode(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-icameracontrol-put_privacymode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PrivacyMode(int Value, int Flags);
}
