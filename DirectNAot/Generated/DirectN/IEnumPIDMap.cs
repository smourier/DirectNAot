#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ienumpidmap
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("afb6c2a2-2c41-11d3-8a60-0000f81e0e4a")]
public partial interface IEnumPIDMap
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ienumpidmap-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cRequest, [In][Out][MarshalUsing(CountElementName = nameof(cRequest))] PID_MAP[] pPIDMap, out uint pcReceived);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ienumpidmap-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cRecords);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ienumpidmap-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ienumpidmap-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IEnumPIDMap ppIEnumPIDMap);
}
