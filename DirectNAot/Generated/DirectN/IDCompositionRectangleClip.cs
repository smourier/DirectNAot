namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionrectangleclip
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("9842ad7d-d9cf-4908-aed7-48b51da5e7c2")]
public partial interface IDCompositionRectangleClip : IDCompositionClip
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-setleft(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetLeft(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-setleft(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetLeft(float left);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-settop(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTop(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-settop(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTop(float top);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-setright(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRight(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-setright(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRight(float right);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-setbottom(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBottom(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-setbottom(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBottom(float bottom);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settopleftradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTopLeftRadiusX(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settopleftradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTopLeftRadiusX(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settopleftradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTopLeftRadiusY(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settopleftradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTopLeftRadiusY(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settoprightradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTopRightRadiusX(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settoprightradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTopRightRadiusX(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settoprightradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTopRightRadiusY(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settoprightradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTopRightRadiusY(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomleftradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBottomLeftRadiusX(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomleftradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBottomLeftRadiusX(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomleftradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBottomLeftRadiusY(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomleftradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBottomLeftRadiusY(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomrightradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBottomRightRadiusX(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomrightradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBottomRightRadiusX(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomrightradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBottomRightRadiusY(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomrightradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBottomRightRadiusY(float radius);
}
