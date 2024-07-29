#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwriteasyncresult
[GeneratedComInterface, Guid("ce25f8fd-863b-4d13-9651-c1f88dc73fe2")]
public partial interface IDWriteAsyncResult
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwriteasyncresult-getwaithandle
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    HANDLE GetWaitHandle();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwriteasyncresult-getresult
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResult();
}
