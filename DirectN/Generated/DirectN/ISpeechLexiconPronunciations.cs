#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("72829128-5682-4704-a0d4-3e2bb6f2ead3")]
public partial interface ISpeechLexiconPronunciations : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechLexiconPronunciation>))] out ISpeechLexiconPronunciation Pronunciation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint EnumVARIANT);
}
