namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1offsettransform
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("3fe6adea-7643-4f53-bd14-a0ce63f24042")]
public partial interface ID2D1OffsetTransform : ID2D1TransformNode
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1offsettransform-setoffset
    [PreserveSig]
    public void SetOffset(in FoundationPOINT offset);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1offsettransform-getoffset
    [PreserveSig]
    public FoundationPOINT GetOffset();
}
