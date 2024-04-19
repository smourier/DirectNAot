namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentation/nn-presentation-icompositionframepresentstatistics
[GeneratedComInterface, Guid("ab41d127-c101-4c0a-911d-f9f2e9d08e64")]
public partial interface ICompositionFramePresentStatistics : IPresentStatistics
{
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-icompositionframepresentstatistics-getcontenttag
    [PreserveSig]
    nuint GetContentTag();
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-icompositionframepresentstatistics-getcompositionframeid
    [PreserveSig]
    ulong GetCompositionFrameId();
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-icompositionframepresentstatistics-getdisplayinstancearray
    [PreserveSig]
    void GetDisplayInstanceArray(out uint displayInstanceArrayCount, out CompositionFrameDisplayInstance displayInstanceArray);
}
