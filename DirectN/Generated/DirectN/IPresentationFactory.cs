#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentation/nn-presentation-ipresentationfactory
[GeneratedComInterface, Guid("8fb37b58-1d74-4f64-a49c-1f97a80a2ec0")]
public partial interface IPresentationFactory
{
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationfactory-ispresentationsupported
    [PreserveSig]
    byte IsPresentationSupported();
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationfactory-ispresentationsupportedwithindependentflip
    [PreserveSig]
    byte IsPresentationSupportedWithIndependentFlip();
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationfactory-createpresentationmanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePresentationManager([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPresentationManager>))] out IPresentationManager ppPresentationManager);
}
