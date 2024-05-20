#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionmatrixtransform3d
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("4b3363f0-643b-41b7-b6e0-ccf22d34467c")]
public partial interface IDCompositionMatrixTransform3D : IDCompositionTransform3D
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionmatrixtransform3d-setmatrix
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMatrix(in D3DMATRIX matrix);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionmatrixtransform3d-setmatrixelement(int_int_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMatrixElement(int row, int column, IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionmatrixtransform3d-setmatrixelement(int_int_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMatrixElement(int row, int column, float value);
}
