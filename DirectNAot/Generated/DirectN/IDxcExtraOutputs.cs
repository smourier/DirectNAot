namespace DirectN;

[GeneratedComInterface, Guid("319b37a2-a5c2-494a-a5de-4801b2faf989")]
public partial interface IDxcExtraOutputs
{
    [PreserveSig]
    uint GetOutputCount();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutput(uint uIndex, in Guid iid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvObject, nint /* optional IDxcBlobUtf16 */ ppOutputType, nint /* optional IDxcBlobUtf16 */ ppOutputName);
}
