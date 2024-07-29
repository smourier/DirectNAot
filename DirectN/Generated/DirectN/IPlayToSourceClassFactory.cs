#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfsharingengine/nn-mfsharingengine-iplaytosourceclassfactory
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("842b32a3-9b9b-4d1c-b3f3-49193248a554")]
public partial interface IPlayToSourceClassFactory
{
    // https://learn.microsoft.com/windows/win32/api/mfsharingengine/nf-mfsharingengine-iplaytosourceclassfactory-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance(uint dwFlags, IPlayToControl pControl, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IInspectable>))] out IInspectable ppSource);
}
