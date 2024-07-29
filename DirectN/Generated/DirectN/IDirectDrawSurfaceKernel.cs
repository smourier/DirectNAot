#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddkernel/nn-ddkernel-idirectdrawsurfacekernel
[GeneratedComInterface, Guid("60755da0-6a40-11d0-9b06-00a0c903a3b8")]
public partial interface IDirectDrawSurfaceKernel
{
    // https://learn.microsoft.com/windows/win32/api/ddkernel/nf-ddkernel-idirectdrawsurfacekernel-getkernelhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKernelHandle(ref nuint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddkernel/nf-ddkernel-idirectdrawsurfacekernel-releasekernelhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseKernelHandle();
}
