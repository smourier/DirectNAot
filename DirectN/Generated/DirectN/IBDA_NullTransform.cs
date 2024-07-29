#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_nulltransform
[GeneratedComInterface, Guid("ddf15b0d-bd25-11d2-9ca0-00c04f7971e0")]
public partial interface IBDA_NullTransform
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_nulltransform-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start();
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_nulltransform-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
}
