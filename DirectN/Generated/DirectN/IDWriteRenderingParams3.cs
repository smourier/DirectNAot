#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwriterenderingparams3
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("b7924baa-391b-412a-8c5c-e44cc2d867dc")]
public partial interface IDWriteRenderingParams3 : IDWriteRenderingParams2
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwriterenderingparams3-getrenderingmode1
    [PreserveSig]
    DWRITE_RENDERING_MODE1 GetRenderingMode1();
}
