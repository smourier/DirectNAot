namespace DirectN;

[GeneratedComInterface, Guid("f1b5be2a-62dd-4327-a1c2-42ac1e1e78e6")]
public partial interface IDxcLinker
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterLibrary(PWSTR pLibName, IDxcBlob pLib);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Link(PWSTR pEntryName, PWSTR pTargetProfile, in PWSTR pLibNames, uint libCount, nint/* nint */ pArguments, uint argCount, out IDxcOperationResult ppResult);
}
