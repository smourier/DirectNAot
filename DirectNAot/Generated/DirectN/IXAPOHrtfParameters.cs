namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/hrtfapoapi/nn-hrtfapoapi-ixapohrtfparameters
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("15b3cd66-e9de-4464-b6e6-2bc3cf63d455")]
public partial interface IXAPOHrtfParameters
{
    // https://learn.microsoft.com/windows/win32/api/hrtfapoapi/nf-hrtfapoapi-ixapohrtfparameters-setsourceposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourcePosition(in HrtfPosition position);
    
    // https://learn.microsoft.com/windows/win32/api/hrtfapoapi/nf-hrtfapoapi-ixapohrtfparameters-setsourceorientation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourceOrientation(in HrtfOrientation orientation);
    
    // https://learn.microsoft.com/windows/win32/api/hrtfapoapi/nf-hrtfapoapi-ixapohrtfparameters-setsourcegain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourceGain(float gain);
    
    // https://learn.microsoft.com/windows/win32/api/hrtfapoapi/nf-hrtfapoapi-ixapohrtfparameters-setenvironment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnvironment(HrtfEnvironment environment);
}
