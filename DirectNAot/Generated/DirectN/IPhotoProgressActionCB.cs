namespace DirectN;

[GeneratedComInterface, Guid("00f242d0-b206-4e7d-b4c1-4755bcbb9c9f")]
public partial interface IPhotoProgressActionCB
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoAction(HWND hWndParent);
}
