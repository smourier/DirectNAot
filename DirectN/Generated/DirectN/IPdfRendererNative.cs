#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.data.pdf.interop/nn-windows-data-pdf-interop-ipdfrenderernative
[GeneratedComInterface, Guid("7d9dcd91-d277-4947-8527-07a0daeda94a")]
public partial interface IPdfRendererNative
{
    // https://learn.microsoft.com/windows/win32/api/windows.data.pdf.interop/nf-windows-data-pdf-interop-ipdfrenderernative-renderpagetosurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenderPageToSurface(nint pdfPage, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGISurface>))] IDXGISurface pSurface, POINT offset, nint /* optional PDF_RENDER_PARAMS* */ pRenderParams);
    
    // https://learn.microsoft.com/windows/win32/api/windows.data.pdf.interop/nf-windows-data-pdf-interop-ipdfrenderernative-renderpagetodevicecontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenderPageToDeviceContext(nint pdfPage, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1DeviceContext>))] ID2D1DeviceContext pD2DDeviceContext, nint /* optional PDF_RENDER_PARAMS* */ pRenderParams);
}
