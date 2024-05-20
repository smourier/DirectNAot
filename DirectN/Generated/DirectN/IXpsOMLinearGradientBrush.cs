#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomlineargradientbrush
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("005e279f-c30d-40ff-93ec-1950d3c528db")]
public partial interface IXpsOMLinearGradientBrush : IXpsOMGradientBrush
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomlineargradientbrush-getstartpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStartPoint(out XPS_POINT startPoint);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomlineargradientbrush-setstartpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStartPoint(in XPS_POINT startPoint);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomlineargradientbrush-getendpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEndPoint(out XPS_POINT endPoint);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomlineargradientbrush-setendpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEndPoint(in XPS_POINT endPoint);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomlineargradientbrush-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IXpsOMLinearGradientBrush linearGradientBrush);
}
