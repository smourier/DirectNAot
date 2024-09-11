#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomsolidcolorbrush
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a06f9f05-3be9-4763-98a8-094fc672e488")]
public partial interface IXpsOMSolidColorBrush : IXpsOMBrush
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomsolidcolorbrush-getcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColor(out XPS_COLOR color, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMColorProfileResource>))] out IXpsOMColorProfileResource colorProfile);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomsolidcolorbrush-setcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColor(in XPS_COLOR color, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMColorProfileResource>))] IXpsOMColorProfileResource colorProfile);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomsolidcolorbrush-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMSolidColorBrush>))] out IXpsOMSolidColorBrush solidColorBrush);
}
