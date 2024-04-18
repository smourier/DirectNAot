namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionmatrixtransform
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("16cdff07-c503-419c-83f2-0965c7af1fa6")]
public partial interface IDCompositionMatrixTransform : IDCompositionTransform
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionmatrixtransform-setmatrix
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetMatrix(in D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionmatrixtransform-setmatrixelement(int_int_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetMatrixElement(int row, int column, IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionmatrixtransform-setmatrixelement(int_int_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetMatrixElement(int row, int column, float value);
}
