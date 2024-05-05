#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f8e690f0-39cb-4843-b8d7-c84696e1119d")]
public partial interface ISpTokenUI
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUISupported(PWSTR pszTypeOfUI, nint pvExtraData, uint cbExtraData, nint punkObject, [MarshalAs(UnmanagedType.U4)] out bool pfSupported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayUI(HWND hwndParent, PWSTR pszTitle, PWSTR pszTypeOfUI, nint pvExtraData, uint cbExtraData, ISpObjectToken pToken, nint punkObject);
}
