namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_mux
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("942aafec-4c05-4c74-b8eb-8706c2a4943f")]
public partial interface IBDA_MUX
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_mux-setpidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPidList(uint ulPidListCount, [MarshalUsing(CountElementName = nameof(ulPidListCount))] in BDA_MUX_PIDLISTITEM[] pbPidListBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_mux-getpidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPidList(ref uint pulPidListCount, ref BDA_MUX_PIDLISTITEM pbPidListBuffer);
}
