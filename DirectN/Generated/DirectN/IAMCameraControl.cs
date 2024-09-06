#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamcameracontrol
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("c6e13370-30ac-11d0-a18c-00a0c9118956")]
public partial interface IAMCameraControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamcameracontrol-getrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRange(int Property, out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamcameracontrol-set
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Set(int Property, int lValue, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamcameracontrol-get
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Get(int Property, out int lValue, out int Flags);
}
