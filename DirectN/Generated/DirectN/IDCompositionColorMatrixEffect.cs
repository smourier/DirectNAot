#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositioncolormatrixeffect
[GeneratedComInterface, Guid("c1170a22-3ce2-4966-90d4-55408bfc84c4")]
public partial interface IDCompositionColorMatrixEffect : IDCompositionFilterEffect
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositioncolormatrixeffect-setmatrix
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMatrix(in D2D_MATRIX_5X4_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositioncolormatrixeffect-setmatrixelement(int_int_float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMatrixElement(int row, int column, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositioncolormatrixeffect-setmatrixelement(int_int_float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMatrixElement(int row, int column, float value);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositioncolormatrixeffect-setalphamode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaMode(D2D1_COLORMATRIX_ALPHA_MODE mode);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositioncolormatrixeffect-setclampoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClampOutput(BOOL clamp);
}
