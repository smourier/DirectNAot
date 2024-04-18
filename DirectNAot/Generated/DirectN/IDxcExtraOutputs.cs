namespace DirectN;

[GeneratedComInterface, Guid("319b37a2-a5c2-494a-a5de-4801b2faf989")]
public partial interface IDxcExtraOutputs
{
    [PreserveSig]
    public uint GetOutputCount();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOutput(uint uIndex, in Guid iid, nint/* nint */ ppvObject, nint/* nint */ ppOutputType, nint/* nint */ ppOutputName);
}
