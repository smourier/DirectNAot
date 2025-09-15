#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-iinitializewithstream
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("b824b49d-22ac-4161-ac8a-9916e8fa3f7f")]
public partial interface IInitializeWithStream
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-iinitializewithstream-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pstream, uint grfMode);
}
