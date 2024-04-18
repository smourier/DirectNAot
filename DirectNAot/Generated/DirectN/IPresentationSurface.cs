namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentation/nn-presentation-ipresentationsurface
[GeneratedComInterface, Guid("956710fb-ea40-4eba-a3eb-4375a0eb4edc")]
public partial interface IPresentationSurface : IPresentationContent
{
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationsurface-setbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBuffer(IPresentationBuffer presentationBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationsurface-setcolorspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationsurface-setalphamode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAlphaMode(DXGI_ALPHA_MODE alphaMode);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationsurface-setsourcerect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSourceRect(FoundationRECT sourceRect);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationsurface-settransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTransform(in PresentationTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationsurface-restricttooutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RestrictToOutput(nint output);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationsurface-setdisablereadback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetDisableReadback(byte value);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationsurface-setletterboxingmargins
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetLetterboxingMargins(float leftLetterboxSize, float topLetterboxSize, float rightLetterboxSize, float bottomLetterboxSize);
}
