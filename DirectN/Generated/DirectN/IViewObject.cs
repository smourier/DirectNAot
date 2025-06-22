#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-iviewobject
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000010d-0000-0000-c000-000000000046")]
public partial interface IViewObject
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iviewobject-draw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Draw(DVASPECT dwDrawAspect, int lindex, nint pvAspect, nint /* optional DVTARGETDEVICE* */ ptd, HDC hdcTargetDev, HDC hdcDraw, nint /* optional RECTL* */ lprcBounds, nint /* optional RECTL* */ lprcWBounds, nint pfnContinue, nuint dwContinue);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iviewobject-getcolorset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorSet(DVASPECT dwDrawAspect, int lindex, nint pvAspect, nint /* optional DVTARGETDEVICE* */ ptd, HDC hicTargetDev, out nint ppColorSet);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iviewobject-freeze
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Freeze(DVASPECT dwDrawAspect, int lindex, nint pvAspect, out uint pdwFreeze);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iviewobject-unfreeze
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unfreeze(uint dwFreeze);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iviewobject-setadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAdvise(DVASPECT aspects, uint advf, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAdviseSink>))] IAdviseSink pAdvSink);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iviewobject-getadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAdvise(nint /* optional uint* */ pAspects, nint /* optional uint* */ pAdvf, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAdviseSink>))] out IAdviseSink ppAdvSink);
}
