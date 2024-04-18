namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsompart
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("74eb2f0b-a91e-4486-afac-0fabeca3dfc6")]
public partial interface IXpsOMPart
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompart-getpartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPartName(out IOpcPartUri partUri);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompart-setpartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPartName(IOpcPartUri partUri);
}
