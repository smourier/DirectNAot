#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("0626b328-3478-467d-a0b3-d0853b93dda3")]
public partial interface ISpeechPhraseElements : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseElement>))] out ISpeechPhraseElement Element);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint EnumVARIANT);
}
