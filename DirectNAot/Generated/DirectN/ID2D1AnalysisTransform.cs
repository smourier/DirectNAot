namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1analysistransform
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("0359dc30-95e6-4568-9055-27720d130e93")]
public partial interface ID2D1AnalysisTransform
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1analysistransform-processanalysisresults
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ProcessAnalysisResults(nint /* byte array */ analysisData, uint analysisDataCount);
}
