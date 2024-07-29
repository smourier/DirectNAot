#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iencoderapi
[GeneratedComInterface, Guid("70423839-6acc-4b23-b079-21dbf08156a5")]
public partial interface IEncoderAPI
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iencoderapi-issupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSupported(in Guid Api);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iencoderapi-isavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsAvailable(in Guid Api);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iencoderapi-getparameterrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParameterRange(in Guid Api, out VARIANT ValueMin, out VARIANT ValueMax, out VARIANT SteppingDelta);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iencoderapi-getparametervalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParameterValues(in Guid Api, out nint Values, out uint ValuesCount);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iencoderapi-getdefaultvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultValue(in Guid Api, out VARIANT Value);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iencoderapi-getvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValue(in Guid Api, out VARIANT Value);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iencoderapi-setvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetValue(in Guid Api, in VARIANT Value);
}
