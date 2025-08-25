#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("aaa74ef9-8ee7-4659-88d9-f8c504da73cc")]
public partial interface IBindStatusCallbackEx : IBindStatusCallback
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBindInfoEx(out uint grfBINDF, ref BINDINFO pbindinfo, out uint grfBINDF2, out uint pdwReserved);
}
