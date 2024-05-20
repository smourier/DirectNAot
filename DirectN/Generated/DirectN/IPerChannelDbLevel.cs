#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iperchanneldblevel
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("c2f8e001-f205-4bc9-99bc-c13b1e048ccb")]
public partial interface IPerChannelDbLevel
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iperchanneldblevel-getchannelcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelCount(out uint pcChannels);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iperchanneldblevel-getlevelrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLevelRange(uint nChannel, out float pfMinLevelDB, out float pfMaxLevelDB, out float pfStepping);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iperchanneldblevel-getlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLevel(uint nChannel, out float pfLevelDB);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iperchanneldblevel-setlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLevel(uint nChannel, float fLevelDB, nint /* optional Guid* */ pguidEventContext);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iperchanneldblevel-setleveluniform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLevelUniform(float fLevelDB, nint /* optional Guid* */ pguidEventContext);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iperchanneldblevel-setlevelallchannels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLevelAllChannels([In][MarshalUsing(CountElementName = nameof(cChannels))] float[] aLevelsDB, uint cChannels, nint /* optional Guid* */ pguidEventContext);
}
