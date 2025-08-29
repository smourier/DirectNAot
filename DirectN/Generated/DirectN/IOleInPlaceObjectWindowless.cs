#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ioleinplaceobjectwindowless
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("1c2056cc-5ef4-101b-8bc8-00aa003e3b29")]
public partial interface IOleInPlaceObjectWindowless : IOleInPlaceObject
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplaceobjectwindowless-onwindowmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnWindowMessage(uint msg, WPARAM wParam, LPARAM lParam, out LRESULT plResult);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplaceobjectwindowless-getdroptarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDropTarget([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDropTarget>))] out IDropTarget ppDropTarget);
}
