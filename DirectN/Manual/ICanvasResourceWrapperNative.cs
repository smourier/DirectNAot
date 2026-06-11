namespace DirectN;

[GeneratedComInterface, Guid("5F10688D-EA55-4D55-A3B0-4DDB55C0C20A")]
public partial interface ICanvasResourceWrapperNative
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNativeResource(nint device, float dpi, in Guid iid, out nint resource);
}
