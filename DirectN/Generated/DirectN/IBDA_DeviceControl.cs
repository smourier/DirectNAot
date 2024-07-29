#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_devicecontrol
[GeneratedComInterface, Guid("fd0a5af3-b41d-11d2-9c95-00c04f7971e0")]
public partial interface IBDA_DeviceControl
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_devicecontrol-startchanges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartChanges();
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_devicecontrol-checkchanges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckChanges();
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_devicecontrol-commitchanges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitChanges();
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_devicecontrol-getchangestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChangeState(ref uint pState);
}
