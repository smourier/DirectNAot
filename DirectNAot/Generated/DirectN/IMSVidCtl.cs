﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msvidctl/nn-msvidctl-imsvidctl
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("b0edf162-910a-11d2-b632-00c04f79498e")]
public partial interface IMSVidCtl : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_autosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AutoSize(out VARIANT_BOOL pbool);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-put_autosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AutoSize(VARIANT_BOOL vbool);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_backcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BackColor(out uint backcolor);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-put_backcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BackColor(uint backcolor);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_enabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Enabled(out VARIANT_BOOL pbool);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-put_enabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Enabled(VARIANT_BOOL vbool);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_tabstop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TabStop(out VARIANT_BOOL pbool);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-put_tabstop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TabStop(VARIANT_BOOL vbool);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_window
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Window(out HWND phwnd);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-refresh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Refresh();
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_displaysize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DisplaySize(out DisplaySizeList CurrentValue);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-put_displaysize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DisplaySize(DisplaySizeList NewValue);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_maintainaspectratio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MaintainAspectRatio(out VARIANT_BOOL CurrentValue);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-put_maintainaspectratio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MaintainAspectRatio(VARIANT_BOOL NewValue);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_colorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ColorKey(out uint CurrentValue);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-put_colorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ColorKey(uint NewValue);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_inputsavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InputsAvailable(BSTR CategoryGuid, out IMSVidInputDevices pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_outputsavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OutputsAvailable(BSTR CategoryGuid, out IMSVidOutputDevices pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get__inputsavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__InputsAvailable(in Guid CategoryGuid, out IMSVidInputDevices pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get__outputsavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__OutputsAvailable(in Guid CategoryGuid, out IMSVidOutputDevices pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_videorenderersavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VideoRenderersAvailable(out IMSVidVideoRendererDevices pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_audiorenderersavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioRenderersAvailable(out IMSVidAudioRendererDevices pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_featuresavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FeaturesAvailable(out IMSVidFeatures pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_inputactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InputActive(out IMSVidInputDevice pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-put_inputactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_InputActive(IMSVidInputDevice pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_outputsactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OutputsActive(out IMSVidOutputDevices pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-put_outputsactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_OutputsActive(IMSVidOutputDevices pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_videorendereractive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VideoRendererActive(out IMSVidVideoRenderer pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-put_videorendereractive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_VideoRendererActive(IMSVidVideoRenderer pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_audiorendereractive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioRendererActive(out IMSVidAudioRenderer pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-put_audiorendereractive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AudioRendererActive(IMSVidAudioRenderer pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_featuresactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FeaturesActive(out IMSVidFeatures pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-put_featuresactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FeaturesActive(IMSVidFeatures pVal);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-get_state
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_State(out MSVidCtlStateList lState);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-view
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT View(in VARIANT v);
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-build
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Build();
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-run
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Run();
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-decompose
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Decompose();
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-disablevideo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisableVideo();
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-disableaudio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisableAudio();
    
    // https://learn.microsoft.com/windows/win32/api/msvidctl/nf-msvidctl-imsvidctl-viewnext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ViewNext(in VARIANT v);
}
