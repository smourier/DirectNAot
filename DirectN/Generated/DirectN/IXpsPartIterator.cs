#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("0021d3cd-af6f-42ab-9999-14bc82a62d2e")]
public partial interface IXpsPartIterator
{
    [PreserveSig]
    void Reset();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Current(out BSTR pUri, out nint ppXpsPart);
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsDone();
    
    [PreserveSig]
    void Next();
}
