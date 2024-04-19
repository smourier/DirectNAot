namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/nn-d3d11shadertracing-id3d11shadertrace
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("36b013e6-2811-4845-baa7-d623fe0df104")]
public partial interface ID3D11ShaderTrace
{
    // https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/nf-d3d11shadertracing-id3d11shadertrace-traceready
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TraceReady(nint/* nint */ pTestCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/nf-d3d11shadertracing-id3d11shadertrace-resettrace
    [PreserveSig]
    void ResetTrace();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/nf-d3d11shadertracing-id3d11shadertrace-gettracestats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTraceStats(out D3D11_TRACE_STATS pTraceStats);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/nf-d3d11shadertracing-id3d11shadertrace-psselectstamp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PSSelectStamp(uint stampIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/nf-d3d11shadertracing-id3d11shadertrace-getinitialregistercontents
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInitialRegisterContents(in D3D11_TRACE_REGISTER pRegister, out D3D11_TRACE_VALUE pValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/nf-d3d11shadertracing-id3d11shadertrace-getstep
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStep(uint stepIndex, out D3D11_TRACE_STEP pTraceStep);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/nf-d3d11shadertracing-id3d11shadertrace-getwrittenregister
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, out D3D11_TRACE_REGISTER pRegister, out D3D11_TRACE_VALUE pValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/nf-d3d11shadertracing-id3d11shadertrace-getreadregister
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReadRegister(uint stepIndex, uint readRegisterIndex, out D3D11_TRACE_REGISTER pRegister, out D3D11_TRACE_VALUE pValue);
}
