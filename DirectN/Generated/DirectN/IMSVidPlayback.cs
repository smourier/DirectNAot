#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidplayback
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("37b03538-a4c8-11d2-b634-00c04f79498e")]
public partial interface IMSVidPlayback : IMSVidInputDevice
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-get_enableresetonstop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EnableResetOnStop(out VARIANT_BOOL pVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-put_enableresetonstop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EnableResetOnStop(VARIANT_BOOL newVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-run
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Run();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-get_canstep
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CanStep(VARIANT_BOOL fBackwards, out VARIANT_BOOL pfCan);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-step
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Step(int lStep);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-put_rate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Rate(double plRate);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-get_rate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Rate(out double plRate);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-put_currentposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CurrentPosition(int lPosition);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-get_currentposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentPosition(out int lPosition);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-put_positionmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PositionMode(PositionModeList lPositionMode);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-get_positionmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PositionMode(out PositionModeList lPositionMode);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplayback-get_length
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Length(out int lLength);
}
