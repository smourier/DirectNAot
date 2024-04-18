namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentation/nn-presentation-ipresentationcontent
[GeneratedComInterface, Guid("5668bb79-3d8e-415c-b215-f38020f2d252")]
public partial interface IPresentationContent
{
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationcontent-settag
    [PreserveSig]
    public void SetTag(nuint tag);
}
