#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ienumtuningspaces
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("8b8eb248-fc2b-11d2-9d8c-00c04f72d980")]
public partial interface IEnumTuningSpaces
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ienumtuningspaces-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] ITuningSpace[] rgelt, out uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ienumtuningspaces-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ienumtuningspaces-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ienumtuningspaces-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumTuningSpaces>))] out IEnumTuningSpaces ppEnum);
}
