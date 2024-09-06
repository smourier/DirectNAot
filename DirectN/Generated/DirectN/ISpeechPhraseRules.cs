#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("9047d593-01dd-4b72-81a3-e4a0ca69f407")]
public partial interface ISpeechPhraseRules : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseRule>))] out ISpeechPhraseRule Rule);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint EnumVARIANT);
}
