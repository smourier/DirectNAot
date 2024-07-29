#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f264da52-e457-4696-b856-a737b717af79")]
public partial interface ISpPhrase2 : ISpPhrase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXMLResult(out PWSTR ppszCoMemXMLResult, SPXMLRESULTOPTIONS Options);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXMLErrorInfo(ref SPSEMANTICERRORINFO pSemanticErrorInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudio(uint ulStartElement, uint cElements, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpStreamFormat>))] out ISpStreamFormat ppStream);
}
