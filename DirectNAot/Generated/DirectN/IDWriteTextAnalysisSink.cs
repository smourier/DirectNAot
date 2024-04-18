namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritetextanalysissink
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5810cd44-0ca0-4701-b3fa-bec5182ae4f6")]
public partial interface IDWriteTextAnalysisSink
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalysissink-setscriptanalysis
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetScriptAnalysis(uint textPosition, uint textLength, in DWRITE_SCRIPT_ANALYSIS scriptAnalysis);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalysissink-setlinebreakpoints
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetLineBreakpoints(uint textPosition, uint textLength, in DWRITE_LINE_BREAKPOINT lineBreakpoints);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalysissink-setbidilevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBidiLevel(uint textPosition, uint textLength, byte explicitLevel, byte resolvedLevel);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalysissink-setnumbersubstitution
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetNumberSubstitution(uint textPosition, uint textLength, IDWriteNumberSubstitution numberSubstitution);
}
