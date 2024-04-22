namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.data.pdf.interop/nn-windows-data-pdf-interop-ipdfrenderernative
[GeneratedComInterface, Guid("7d9dcd91-d277-4947-8527-07a0daeda94a")]
public partial interface IPdfRendererNative
{
    // https://learn.microsoft.com/windows/win32/api/windows.data.pdf.interop/nf-windows-data-pdf-interop-ipdfrenderernative-renderpagetosurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenderPageToSurface(nint pdfPage, IDXGISurface pSurface, in FoundationPOINT offset, nint /* optional PDF_RENDER_PARAMS */ pRenderParams);
    
    // https://learn.microsoft.com/windows/win32/api/windows.data.pdf.interop/nf-windows-data-pdf-interop-ipdfrenderernative-renderpagetodevicecontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenderPageToDeviceContext(nint pdfPage, ID2D1DeviceContext pD2DDeviceContext, nint /* optional PDF_RENDER_PARAMS */ pRenderParams);
}
