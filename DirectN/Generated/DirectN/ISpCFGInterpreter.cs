#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f3d3f926-11fc-11d3-bb97-00c04f8ee6c0")]
public partial interface ISpCFGInterpreter
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitGrammar(PWSTR pszGrammarName, out nint pvGrammarData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Interpret([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpPhraseBuilder>))] ISpPhraseBuilder pPhrase, uint ulFirstElement, uint ulCountOfElements, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpCFGInterpreterSite>))] ISpCFGInterpreterSite pSite);
}
