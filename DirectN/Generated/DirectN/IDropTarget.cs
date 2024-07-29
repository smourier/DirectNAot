#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-idroptarget
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000122-0000-0000-c000-000000000046")]
public partial interface IDropTarget
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-idroptarget-dragenter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DragEnter(IDataObject pDataObj, MODIFIERKEYS_FLAGS grfKeyState, POINTL pt, ref DROPEFFECT pdwEffect);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-idroptarget-dragover
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DragOver(MODIFIERKEYS_FLAGS grfKeyState, POINTL pt, ref DROPEFFECT pdwEffect);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-idroptarget-dragleave
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DragLeave();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-idroptarget-drop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Drop(IDataObject pDataObj, MODIFIERKEYS_FLAGS grfKeyState, POINTL pt, ref DROPEFFECT pdwEffect);
}
