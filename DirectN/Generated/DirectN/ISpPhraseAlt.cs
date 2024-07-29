#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8fcebc98-4e49-4067-9c6c-d86a0e092e3d")]
public partial interface ISpPhraseAlt : ISpPhrase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAltInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpPhrase>))] out ISpPhrase ppParent, ref uint pulStartElementInParent, ref uint pcElementsInParent, ref uint pcElementsInAlt);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit();
}
