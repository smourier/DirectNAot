#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("38bc662f-2257-4525-959e-2069d2596c05")]
public partial interface ISpeechPhraseReplacements : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseReplacement>))] out ISpeechPhraseReplacement Reps);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint EnumVARIANT);
}
