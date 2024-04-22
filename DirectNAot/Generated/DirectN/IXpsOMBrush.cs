namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsombrush
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("56a3f80c-ea4c-4187-a57b-a2a473b2b42b")]
public partial interface IXpsOMBrush : IXpsOMShareable
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsombrush-getopacity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOpacity(out float opacity);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsombrush-setopacity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOpacity(float opacity);
}
