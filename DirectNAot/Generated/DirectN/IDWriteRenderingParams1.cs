namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/nn-dwrite_1-idwriterenderingparams1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("94413cf4-a6fc-4248-8b50-6674348fcad3")]
public partial interface IDWriteRenderingParams1 : IDWriteRenderingParams
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwriterenderingparams1-getgrayscaleenhancedcontrast
    [PreserveSig]
    public float GetGrayscaleEnhancedContrast();
}
