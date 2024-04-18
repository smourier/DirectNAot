namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionrotatetransform3d
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("d8f5b23f-d429-4a91-b55a-d2f45fd75b18")]
public partial interface IDCompositionRotateTransform3D : IDCompositionTransform3D
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setangle(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAngle(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setangle(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAngle(float angle);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setaxisx(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAxisX(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setaxisx(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAxisX(float axisX);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setaxisy(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAxisY(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setaxisy(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAxisY(float axisY);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setaxisz(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAxisZ(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setaxisz(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAxisZ(float axisZ);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setcenterx(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCenterX(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setcenterx(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCenterX(float centerX);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setcentery(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCenterY(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setcentery(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCenterY(float centerY);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setcenterz(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCenterZ(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrotatetransform3d-setcenterz(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCenterZ(float centerZ);
}
