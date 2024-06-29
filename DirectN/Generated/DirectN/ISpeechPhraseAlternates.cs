#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b238b6d5-f276-4c3d-a6c1-2974801c3cc2")]
public partial interface ISpeechPhraseAlternates : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseAlternate>))] out ISpeechPhraseAlternate PhraseAlternate);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint EnumVARIANT);
}
