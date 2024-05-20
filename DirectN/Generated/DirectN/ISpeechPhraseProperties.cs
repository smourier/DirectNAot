#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("08166b47-102e-4b23-a599-bdb98dbfd1f4")]
public partial interface ISpeechPhraseProperties : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int Index, out ISpeechPhraseProperty Property);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint EnumVARIANT);
}
