namespace DirectN;

[GeneratedComInterface, Guid("58346cda-dde7-4497-9461-6f87af5e0659")]
public partial interface IDxcResult : IDxcOperationResult
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool HasOutput(DXC_OUT_KIND dxcOutKind);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutput(DXC_OUT_KIND dxcOutKind, in Guid iid, nint/* nint */ ppvObject, out IDxcBlobUtf16 ppOutputName);
    
    [PreserveSig]
    uint GetNumOutputs();
    
    [PreserveSig]
    DXC_OUT_KIND GetOutputByIndex(uint Index);
    
    [PreserveSig]
    DXC_OUT_KIND PrimaryOutput();
}
