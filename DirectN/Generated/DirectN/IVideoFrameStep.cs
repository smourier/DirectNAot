#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivideoframestep
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("e46a9787-2b71-444d-a4b5-1fab7b708d6a")]
public partial interface IVideoFrameStep
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivideoframestep-step
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Step(uint dwFrames, nint pStepObject);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivideoframestep-canstep
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanStep(int bMultiple, nint pStepObject);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivideoframestep-cancelstep
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelStep();
}
