namespace DirectN;

[GeneratedComInterface, Guid("11f62cd1-2f9d-42d3-b05f-d6790d9e9f8e")]
public partial interface IVisualInteractionSourceInterop
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryRedirectForManipulation(in POINTER_INFO pointerInfo);
}
