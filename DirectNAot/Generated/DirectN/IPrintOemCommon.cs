namespace DirectN;

[GeneratedComInterface, Guid("7f42285e-91d5-11d1-8820-00c04fb961ec")]
public partial interface IPrintOemCommon
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetInfo(uint dwMode, nint pBuffer, uint cbSize, out uint pcbNeeded);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DevMode(uint dwMode, ref OEMDMPARAM pOemDMParam);
}
