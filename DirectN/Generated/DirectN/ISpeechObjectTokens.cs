#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("9285b776-2e7b-4bc0-b53e-580eb6fa967f")]
public partial interface ISpeechObjectTokens : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechObjectToken>))] out ISpeechObjectToken Token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint ppEnumVARIANT);
}
