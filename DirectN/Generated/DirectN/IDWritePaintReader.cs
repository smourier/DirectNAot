#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8128e912-3b97-42a5-ab6c-24aad3a86e54")]
public partial interface IDWritePaintReader
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentGlyph(uint glyphIndex, out DWRITE_PAINT_ELEMENT paintElement, uint structSize, out D2D_RECT_F clipBox, nint /* optional DWRITE_PAINT_ATTRIBUTES* */ glyphAttributes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTextColor(in DWRITE_COLOR_F textColor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorPaletteIndex(uint colorPaletteIndex);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCustomColorPalette([In][MarshalUsing(CountElementName = nameof(paletteEntryCount))] DWRITE_COLOR_F[] paletteEntries, uint paletteEntryCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveToFirstChild(out DWRITE_PAINT_ELEMENT paintElement, uint structSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveToNextSibling(out DWRITE_PAINT_ELEMENT paintElement, uint structSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveToParent();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGradientStops(uint firstGradientStopIndex, uint gradientStopCount, [In][Out][MarshalUsing(CountElementName = nameof(gradientStopCount))] D2D1_GRADIENT_STOP[] gradientStops);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGradientStopColors(uint firstGradientStopIndex, uint gradientStopCount, [In][Out][MarshalUsing(CountElementName = nameof(gradientStopCount))] DWRITE_PAINT_COLOR[] gradientStopColors);
}
