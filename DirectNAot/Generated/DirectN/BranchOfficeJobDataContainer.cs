namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BranchOfficeJobDataContainer
{
    public uint cJobDataEntries;
    public InlineArrayBranchOfficeJobData1 JobData; // variable-length array placeholder
}
