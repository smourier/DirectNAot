namespace DirectN;

[GeneratedComInterface, Guid("8d199862-415e-47d5-ac4f-faa608b424e6")]
public partial interface ISpeechLexiconWords : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int Index, out ISpeechLexiconWord Word);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint EnumVARIANT);
}
