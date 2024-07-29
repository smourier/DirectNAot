#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomradialgradientbrush
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("75f207e5-08bf-413c-96b1-b82b4064176b")]
public partial interface IXpsOMRadialGradientBrush : IXpsOMGradientBrush
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomradialgradientbrush-getcenter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCenter(out XPS_POINT center);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomradialgradientbrush-setcenter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCenter(in XPS_POINT center);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomradialgradientbrush-getradiisizes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRadiiSizes(out XPS_SIZE radiiSizes);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomradialgradientbrush-setradiisizes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRadiiSizes(in XPS_SIZE radiiSizes);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomradialgradientbrush-getgradientorigin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGradientOrigin(out XPS_POINT origin);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomradialgradientbrush-setgradientorigin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGradientOrigin(in XPS_POINT origin);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomradialgradientbrush-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMRadialGradientBrush>))] out IXpsOMRadialGradientBrush radialGradientBrush);
}
