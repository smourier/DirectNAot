﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentation/nn-presentation-ipresentstatuspresentstatistics
[GeneratedComInterface, Guid("c9ed2a41-79cb-435e-964e-c8553055420c")]
public partial interface IPresentStatusPresentStatistics : IPresentStatistics
{
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentstatuspresentstatistics-getcompositionframeid
    [PreserveSig]
    public ulong GetCompositionFrameId();
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentstatuspresentstatistics-getpresentstatus
    [PreserveSig]
    public PresentStatus GetPresentStatus();
}
