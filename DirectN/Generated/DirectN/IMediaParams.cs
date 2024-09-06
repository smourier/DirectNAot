#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/medparam/nn-medparam-imediaparams
[GeneratedComInterface, Guid("6d6cbb61-a223-44aa-842f-a2f06750be6e")]
public partial interface IMediaParams
{
    // https://learn.microsoft.com/windows/win32/api/medparam/nf-medparam-imediaparams-getparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParam(uint dwParamIndex, out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/medparam/nf-medparam-imediaparams-setparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetParam(uint dwParamIndex, float value);
    
    // https://learn.microsoft.com/windows/win32/api/medparam/nf-medparam-imediaparams-addenvelope
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEnvelope(uint dwParamIndex, uint cSegments, in MP_ENVELOPE_SEGMENT pEnvelopeSegments);
    
    // https://learn.microsoft.com/windows/win32/api/medparam/nf-medparam-imediaparams-flushenvelope
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FlushEnvelope(uint dwParamIndex, long refTimeStart, long refTimeEnd);
    
    // https://learn.microsoft.com/windows/win32/api/medparam/nf-medparam-imediaparams-settimeformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTimeFormat(Guid guidTimeFormat, uint mpTimeData);
}
