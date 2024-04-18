namespace DirectN;

[GeneratedComInterface, Guid("b771dab8-1282-41b7-858c-f206e4d20577")]
public partial interface IPrintJob
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_Name(out BSTR pbstrName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_Id(out uint pulID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_PrintedPages(out uint pulPages);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_TotalPages(out uint pulPages);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_Status(out PrintJobStatus pStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_SubmissionTime(out double pSubmissionTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RequestCancel();
}
