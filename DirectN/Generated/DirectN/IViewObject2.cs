#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-iviewobject2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000127-0000-0000-c000-000000000046")]
public partial interface IViewObject2 : IViewObject
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iviewobject2-getextent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExtent(DVASPECT dwDrawAspect, int lindex, in DVTARGETDEVICE ptd, out SIZE lpsizel);
}
