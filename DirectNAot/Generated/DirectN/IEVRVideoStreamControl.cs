namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr9/nn-evr9-ievrvideostreamcontrol
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d0cfe38b-93e7-4772-8957-0400c49a4485")]
public partial interface IEVRVideoStreamControl
{
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-ievrvideostreamcontrol-setstreamactivestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamActiveState([MarshalAs(UnmanagedType.U4)] bool fActive);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-ievrvideostreamcontrol-getstreamactivestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamActiveState([MarshalAs(UnmanagedType.U4)] out bool lpfActive);
}
