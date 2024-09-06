#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("25740e2e-9cba-401b-9119-4fb42f39f270")]
public partial interface IDxcOptimizer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailablePassCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailablePass(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcOptimizerPass>))] out IDxcOptimizerPass ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RunOptimizer(IDxcBlob pBlob, [In][MarshalUsing(CountElementName = nameof(optionCount))] PWSTR[] ppOptions, uint optionCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] out IDxcBlob pOutputModule, nint /* optional IDxcBlobEncoding* */ ppOutputText);
}
