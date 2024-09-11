#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f8e690f0-39cb-4843-b8d7-c84696e1119d")]
public partial interface ISpTokenUI
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUISupported(PWSTR pszTypeOfUI, nint pvExtraData, uint cbExtraData, nint punkObject, out BOOL pfSupported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayUI(HWND hwndParent, PWSTR pszTitle, PWSTR pszTypeOfUI, nint pvExtraData, uint cbExtraData, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpObjectToken>))] ISpObjectToken pToken, nint punkObject);
}
