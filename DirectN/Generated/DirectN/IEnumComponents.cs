#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ienumcomponents
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("2a6e2939-2595-11d3-b64c-00c04f79498e")]
public partial interface IEnumComponents
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ienumcomponents-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] nint[] rgelt, out uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ienumcomponents-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ienumcomponents-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ienumcomponents-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumComponents>))] out IEnumComponents ppEnum);
}
