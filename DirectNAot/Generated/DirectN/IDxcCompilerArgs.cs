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
    HRESULT AddArguments(nint /* optional PWSTR* */ pArguments, uint argCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddArgumentsUTF8(nint /* optional PSTR* */ pArguments, uint argCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddDefines([MarshalUsing(CountElementName = nameof(defineCount))] in DxcDefine[] pDefines, uint defineCount);
}
