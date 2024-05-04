#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1svg/nn-d2d1svg-id2d1svgattribute
[GeneratedComInterface, Guid("c9cdb0dd-f8c9-4e70-b7c2-301c80292c5e")]
public partial interface ID2D1SvgAttribute : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgattribute-getelement
    [PreserveSig]
    void GetElement(out ID2D1SvgElement element);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgattribute-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out ID2D1SvgAttribute attribute);
}
