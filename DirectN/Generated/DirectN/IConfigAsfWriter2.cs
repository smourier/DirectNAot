#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dshowasf/nn-dshowasf-iconfigasfwriter2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("7989ccaa-53f0-44f0-884a-f3b03f6ae066")]
public partial interface IConfigAsfWriter2 : IConfigAsfWriter
{
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iconfigasfwriter2-streamnumfrompin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StreamNumFromPin(IPin pPin, out ushort pwStreamNum);
    
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iconfigasfwriter2-setparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetParam(uint dwParam, uint dwParam1, uint dwParam2);
    
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iconfigasfwriter2-getparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParam(uint dwParam, out uint pdwParam1, out uint pdwParam2);
    
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iconfigasfwriter2-resetmultipassstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetMultiPassState();
}
