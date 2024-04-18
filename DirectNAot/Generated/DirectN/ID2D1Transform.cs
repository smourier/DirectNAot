﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1transform
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("ef1a287d-342a-4f76-8fdb-da0d6ea9f92b")]
public partial interface ID2D1Transform : ID2D1TransformNode
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapoutputrecttoinputrects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT MapOutputRectToInputRects(in RECT outputRect, out RECT inputRects, uint inputRectsCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapinputrectstooutputrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT MapInputRectsToOutputRect(in RECT inputRects, in RECT inputOpaqueSubRects, uint inputRectCount, out RECT outputRect, out RECT outputOpaqueSubRect);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1transform-mapinvalidrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT MapInvalidRect(uint inputIndex, RECT invalidInputRect, out RECT invalidOutputRect);
}
