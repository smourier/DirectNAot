namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mediaobj/nn-mediaobj-idmovideooutputoptimizations
[GeneratedComInterface, Guid("be8f4f4e-5b16-4d29-b350-7f6b5d9298ac")]
public partial interface IDMOVideoOutputOptimizations
{
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-idmovideooutputoptimizations-queryoperationmodepreferences
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryOperationModePreferences(uint ulOutputStreamIndex, out uint pdwRequestedCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-idmovideooutputoptimizations-setoperationmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOperationMode(uint ulOutputStreamIndex, uint dwEnabledFeatures);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-idmovideooutputoptimizations-getcurrentoperationmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentOperationMode(uint ulOutputStreamIndex, out uint pdwEnabledFeatures);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-idmovideooutputoptimizations-getcurrentsamplerequirements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentSampleRequirements(uint ulOutputStreamIndex, out uint pdwRequestedFeatures);
}
