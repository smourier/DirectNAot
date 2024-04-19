namespace DirectN;

[GeneratedComInterface, Guid("25740e2e-9cba-401b-9119-4fb42f39f270")]
public partial interface IDxcOptimizer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailablePassCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailablePass(uint index, out IDxcOptimizerPass ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RunOptimizer(IDxcBlob pBlob, in PWSTR ppOptions, uint optionCount, out IDxcBlob pOutputModule, nint/* nint */ ppOutputText);
}
