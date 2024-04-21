namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionvisual3
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("2775f462-b6c1-4015-b0be-b3e7d6a4976d")]
public partial interface IDCompositionVisual3 : IDCompositionVisualDebug
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual3-setdepthmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDepthMode(DCOMPOSITION_DEPTH_MODE mode);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual3-setoffsetz(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOffsetZ(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual3-setoffsetz(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOffsetZ(float offsetZ);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual3-setopacity(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOpacity(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual3-setopacity(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOpacity(float opacity);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual3-settransform(constd2d_matrix_4x4_f_)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransform(IDCompositionTransform3D? transform);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual3-settransform(constd2d_matrix_4x4_f_)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransform(in D2D_MATRIX_4X4_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual3-setvisible
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVisible([MarshalAs(UnmanagedType.U4)] bool visible);
}
