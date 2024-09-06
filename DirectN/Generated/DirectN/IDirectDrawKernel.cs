#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddkernel/nn-ddkernel-idirectdrawkernel
[GeneratedComInterface, Guid("8d56c120-6a08-11d0-9b06-00a0c903a3b8")]
public partial interface IDirectDrawKernel
{
    // https://learn.microsoft.com/windows/win32/api/ddkernel/nf-ddkernel-idirectdrawkernel-getcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(ref DDKERNELCAPS param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddkernel/nf-ddkernel-idirectdrawkernel-getkernelhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKernelHandle(ref nuint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddkernel/nf-ddkernel-idirectdrawkernel-releasekernelhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseKernelHandle();
}
