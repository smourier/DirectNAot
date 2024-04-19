namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/nn-ddraw-idirectdrawgammacontrol
[GeneratedComInterface, Guid("69c11c3e-b46b-11d1-ad7a-00c04fc29b4e")]
public partial interface IDirectDrawGammaControl
{
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawgammacontrol-getgammaramp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGammaRamp(uint param0, ref DDGAMMARAMP param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawgammacontrol-setgammaramp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGammaRamp(uint param0, ref DDGAMMARAMP param1);
}
