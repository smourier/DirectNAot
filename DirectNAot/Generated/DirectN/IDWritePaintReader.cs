﻿namespace DirectN;

[GeneratedComInterface, Guid("8128e912-3b97-42a5-ab6c-24aad3a86e54")]
public partial interface IDWritePaintReader
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCurrentGlyph(uint glyphIndex, out DWRITE_PAINT_ELEMENT paintElement, uint structSize, out D2D_RECT_F clipBox, nint/* nint */ glyphAttributes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTextColor(in DWRITE_COLOR_F textColor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetColorPaletteIndex(uint colorPaletteIndex);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCustomColorPalette(in DWRITE_COLOR_F paletteEntries, uint paletteEntryCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT MoveToFirstChild(out DWRITE_PAINT_ELEMENT paintElement, uint structSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT MoveToNextSibling(out DWRITE_PAINT_ELEMENT paintElement, uint structSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT MoveToParent();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGradientStops(uint firstGradientStopIndex, uint gradientStopCount, out D2D1_GRADIENT_STOP gradientStops);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGradientStopColors(uint firstGradientStopIndex, uint gradientStopCount, out DWRITE_PAINT_COLOR gradientStopColors);
}
