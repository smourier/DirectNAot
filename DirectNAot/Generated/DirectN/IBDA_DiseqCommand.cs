namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_diseqcommand
[GeneratedComInterface, Guid("f84e2ab0-3c6b-45e3-a0fc-8669d4b81f11")]
public partial interface IBDA_DiseqCommand
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_diseqcommand-put_enablediseqcommands
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EnableDiseqCommands(BOOLEAN bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_diseqcommand-put_diseqlnbsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DiseqLNBSource(uint ulLNBSource);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_diseqcommand-put_disequsetoneburst
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DiseqUseToneBurst(BOOLEAN bUseToneBurst);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_diseqcommand-put_diseqrepeats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DiseqRepeats(uint ulRepeats);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_diseqcommand-put_diseqsendcommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DiseqSendCommand(uint ulRequestId, uint ulcbCommandLen, nint /* byte array */ pbCommand);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_diseqcommand-get_diseqresponse
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DiseqResponse(uint ulRequestId, ref uint pulcbResponseLen, nint /* byte array */ pbResponse);
}
