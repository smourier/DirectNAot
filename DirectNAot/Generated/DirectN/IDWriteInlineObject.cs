namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwriteinlineobject
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("8339fde3-106f-47ab-8373-1c6295eb10b3")]
public partial interface IDWriteInlineObject
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwriteinlineobject-draw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Draw(nint /* optional void */ clientDrawingContext, IDWriteTextRenderer renderer, float originX, float originY, [MarshalAs(UnmanagedType.U4)] bool isSideways, [MarshalAs(UnmanagedType.U4)] bool isRightToLeft, nint clientDrawingEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwriteinlineobject-getmetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetrics(out DWRITE_INLINE_OBJECT_METRICS metrics);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwriteinlineobject-getoverhangmetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOverhangMetrics(out DWRITE_OVERHANG_METRICS overhangs);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwriteinlineobject-getbreakconditions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBreakConditions(out DWRITE_BREAK_CONDITION breakConditionBefore, out DWRITE_BREAK_CONDITION breakConditionAfter);
}
