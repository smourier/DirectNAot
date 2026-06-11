namespace DirectN;

[GeneratedComInterface, Guid("040AB731-08F1-469F-9BF9-5B1160F27224")]
public partial interface ICanvasSwapChainFactoryNative: IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateForHwnd(nint resourceCreator,
                        HWND hwnd,
                        uint  width,
                        uint height,
                        float dpi,
                        int format,
                        int bufferCount,
                        out nint canvasSwapChain);
}
