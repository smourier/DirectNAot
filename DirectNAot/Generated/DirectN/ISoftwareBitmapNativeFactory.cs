namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.graphics.imaging.interop/nn-windows-graphics-imaging-interop-isoftwarebitmapnativefactory
[GeneratedComInterface, Guid("c3c181ec-2914-4791-af02-02d224a10b43")]
public partial interface ISoftwareBitmapNativeFactory : IInspectable
{
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.imaging.interop/nf-windows-graphics-imaging-interop-isoftwarebitmapnativefactory-createfromwicbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFromWICBitmap(IWICBitmap data, [MarshalAs(UnmanagedType.U4)] bool forceReadOnly, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.imaging.interop/nf-windows-graphics-imaging-interop-isoftwarebitmapnativefactory-createfrommf2dbuffer2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFromMF2DBuffer2(IMF2DBuffer2 data, in Guid subtype, uint width, uint height, [MarshalAs(UnmanagedType.U4)] bool forceReadOnly, nint /* optional MFVideoArea* */ minDisplayAperture, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppv);
}
