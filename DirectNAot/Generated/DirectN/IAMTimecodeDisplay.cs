namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamtimecodedisplay
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("9b496ce2-811b-11cf-8c77-00aa006b6814")]
public partial interface IAMTimecodeDisplay
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodedisplay-gettcdisplayenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTCDisplayEnable(out int pState);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodedisplay-settcdisplayenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTCDisplayEnable(int State);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodedisplay-gettcdisplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTCDisplay(int Param, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtimecodedisplay-settcdisplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTCDisplay(int Param, int Value);
}
