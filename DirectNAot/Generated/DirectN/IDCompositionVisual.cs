namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionvisual
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("4d93059d-097b-4651-9a60-f0f25116e2f3")]
public partial interface IDCompositionVisual
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-setoffsetx(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOffsetX(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-setoffsetx(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOffsetX(float offsetX);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-setoffsety(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOffsetY(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-setoffsety(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOffsetY(float offsetY);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-settransform(constd2d_matrix_3x2_f_)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTransform(IDCompositionTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-settransform(constd2d_matrix_3x2_f_)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTransform(in D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-settransformparent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTransformParent(IDCompositionVisual visual);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-seteffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetEffect(IDCompositionEffect effect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-setbitmapinterpolationmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-setbordermode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBorderMode(DCOMPOSITION_BORDER_MODE borderMode);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-setclip(constd2d_rect_f_)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetClip(IDCompositionClip clip);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-setclip(constd2d_rect_f_)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetClip(in D2D_RECT_F rect);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-setcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetContent(nint content);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-addvisual
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddVisual(IDCompositionVisual visual, [MarshalAs(UnmanagedType.U4)] bool insertAbove, IDCompositionVisual referenceVisual);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-removevisual
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RemoveVisual(IDCompositionVisual visual);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-removeallvisuals
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RemoveAllVisuals();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual-setcompositemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE compositeMode);
}
