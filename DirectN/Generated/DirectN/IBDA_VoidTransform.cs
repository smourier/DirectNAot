#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_voidtransform
[GeneratedComInterface, Guid("71985f46-1ca1-11d3-9cc8-00c04f7971e0")]
public partial interface IBDA_VoidTransform
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_voidtransform-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start();
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_voidtransform-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
}
