namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentation/nn-presentation-iindependentflipframepresentstatistics
[GeneratedComInterface, Guid("8c93be27-ad94-4da0-8fd4-2413132d124e")]
public partial interface IIndependentFlipFramePresentStatistics : IPresentStatistics
{
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-iindependentflipframepresentstatistics-getoutputadapterluid
    [PreserveSig]
    public LUID GetOutputAdapterLUID();
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-iindependentflipframepresentstatistics-getoutputvidpnsourceid
    [PreserveSig]
    public uint GetOutputVidPnSourceId();
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-iindependentflipframepresentstatistics-getcontenttag
    [PreserveSig]
    public nuint GetContentTag();
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-iindependentflipframepresentstatistics-getdisplayedtime
    [PreserveSig]
    public SystemInterruptTime GetDisplayedTime();
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-iindependentflipframepresentstatistics-getpresentduration
    [PreserveSig]
    public SystemInterruptTime GetPresentDuration();
}
