namespace DirectN;

[GeneratedComInterface, Guid("73effe2a-70dc-45f8-9690-eff64c02429d")]
public partial interface IDxcCompilerArgs
{
    [PreserveSig]
    PWSTR GetArguments();
    
    [PreserveSig]
    uint GetCount();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddArguments(nint/* nint */ pArguments, uint argCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddArgumentsUTF8(nint/* nint */ pArguments, uint argCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddDefines(in DxcDefine pDefines, uint defineCount);
}
