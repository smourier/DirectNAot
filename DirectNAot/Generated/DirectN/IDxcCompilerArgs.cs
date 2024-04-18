namespace DirectN;

[GeneratedComInterface, Guid("73effe2a-70dc-45f8-9690-eff64c02429d")]
public partial interface IDxcCompilerArgs
{
    [PreserveSig]
    public PWSTR GetArguments();
    
    [PreserveSig]
    public uint GetCount();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddArguments(nint/* nint */ pArguments, uint argCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddArgumentsUTF8(nint/* nint */ pArguments, uint argCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddDefines(in DxcDefine pDefines, uint defineCount);
}
