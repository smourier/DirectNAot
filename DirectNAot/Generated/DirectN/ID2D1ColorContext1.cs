#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1colorcontext1
[GeneratedComInterface, Guid("1ab42875-c57f-4be9-bd85-9cd78d6f55ee")]
public partial interface ID2D1ColorContext1 : ID2D1ColorContext
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1colorcontext1-getcolorcontexttype
    [PreserveSig]
    D2D1_COLOR_CONTEXT_TYPE GetColorContextType();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1colorcontext1-getdxgicolorspace
    [PreserveSig]
    DXGI_COLOR_SPACE_TYPE GetDXGIColorSpace();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1colorcontext1-getsimplecolorprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSimpleColorProfile(out D2D1_SIMPLE_COLOR_PROFILE simpleProfile);
}
