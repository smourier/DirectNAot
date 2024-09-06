#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidinputdevice
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("37b0353d-a4c8-11d2-b634-00c04f79498e")]
public partial interface IMSVidInputDevice : IMSVidDevice
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidinputdevice-isviewable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsViewable(in VARIANT v, out VARIANT_BOOL pfViewable);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidinputdevice-view
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT View(in VARIANT v);
}
