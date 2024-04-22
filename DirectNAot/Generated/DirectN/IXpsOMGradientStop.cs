namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomgradientstop
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5cf4f5cc-3969-49b5-a70a-5550b618fe49")]
public partial interface IXpsOMGradientStop
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgradientstop-getowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOwner(out IXpsOMGradientBrush owner);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgradientstop-getoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOffset(out float offset);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgradientstop-setoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOffset(float offset);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgradientstop-getcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColor(out XPS_COLOR color, out IXpsOMColorProfileResource colorProfile);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgradientstop-setcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColor(in XPS_COLOR color, IXpsOMColorProfileResource colorProfile);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgradientstop-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IXpsOMGradientStop gradientStop);
}
