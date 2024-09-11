#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionrectangleclip
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("9842ad7d-d9cf-4908-aed7-48b51da5e7c2")]
public partial interface IDCompositionRectangleClip : IDCompositionClip
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-setleft(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLeft([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-setleft(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLeft(float left);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-settop(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTop([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-settop(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTop(float top);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-setright(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRight([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-setright(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRight(float right);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-setbottom(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBottom([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionrectangleclip-setbottom(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBottom(float bottom);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settopleftradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTopLeftRadiusX([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settopleftradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTopLeftRadiusX(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settopleftradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTopLeftRadiusY([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settopleftradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTopLeftRadiusY(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settoprightradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTopRightRadiusX([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settoprightradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTopRightRadiusX(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settoprightradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTopRightRadiusY([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-settoprightradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTopRightRadiusY(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomleftradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBottomLeftRadiusX([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomleftradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBottomLeftRadiusX(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomleftradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBottomLeftRadiusY([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomleftradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBottomLeftRadiusY(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomrightradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBottomRightRadiusX([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomrightradiusx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBottomRightRadiusX(float radius);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomrightradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBottomRightRadiusY([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/directcomp/idcompositionrectangleclip-setbottomrightradiusy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBottomRightRadiusY(float radius);
}
