namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_2/nn-dwrite_2-idwriterenderingparams2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("f9d711c3-9777-40ae-87e8-3e5af9bf0948")]
public partial interface IDWriteRenderingParams2 : IDWriteRenderingParams1
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwriterenderingparams2-getgridfitmode
    [PreserveSig]
    DWRITE_GRID_FIT_MODE GetGridFitMode();
}
