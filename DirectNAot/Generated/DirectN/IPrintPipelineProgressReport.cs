namespace DirectN;

[GeneratedComInterface, Guid("edc12c7c-ed40-4ea5-96a6-5e4397497a61")]
public partial interface IPrintPipelineProgressReport
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ReportProgress(EXpsJobConsumption update);
}
