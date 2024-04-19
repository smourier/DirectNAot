namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-istreambufferdatacounters
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9d2a2563-31ab-402e-9a6b-adb903489440")]
public partial interface IStreamBufferDataCounters
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferdatacounters-getdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(out SBE_PIN_DATA pPinData);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferdatacounters-resetdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetData();
}
