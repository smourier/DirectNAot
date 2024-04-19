namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentation/nn-presentation-ipresentstatistics
[GeneratedComInterface, Guid("b44b8bda-7282-495d-9dd7-ceadd8b4bb86")]
public partial interface IPresentStatistics
{
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentstatistics-getpresentid
    [PreserveSig]
    ulong GetPresentId();
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentstatistics-getkind
    [PreserveSig]
    PresentStatisticsKind GetKind();
}
