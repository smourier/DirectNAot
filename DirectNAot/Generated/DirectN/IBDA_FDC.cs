namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_fdc
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("138adc7e-58ae-437f-b0b4-c9fe19d5b4ac")]
public partial interface IBDA_FDC
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_fdc-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out uint CurrentBitrate, [MarshalAs(UnmanagedType.U4)] out bool CarrierLock, out uint CurrentFrequency, [MarshalAs(UnmanagedType.U4)] out bool CurrentSpectrumInversion, out BSTR CurrentPIDList, out BSTR CurrentTIDList, [MarshalAs(UnmanagedType.U4)] out bool Overflow);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_fdc-requesttables
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RequestTables(BSTR TableIDs);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_fdc-addpid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPid(BSTR PidsToAdd, out uint RemainingFilterEntries);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_fdc-removepid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemovePid(BSTR PidsToRemove);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_fdc-addtid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTid(BSTR TidsToAdd, out BSTR CurrentTidList);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_fdc-removetid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveTid(BSTR TidsToRemove);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_fdc-gettablesection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableSection(out uint Pid, uint MaxBufferSize, out uint ActualSize, nint /* byte array */ SecBuffer);
}
