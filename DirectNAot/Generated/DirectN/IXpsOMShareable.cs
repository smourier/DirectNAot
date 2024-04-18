namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomshareable
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("7137398f-2fc1-454d-8c6a-2c3115a16ece")]
public partial interface IXpsOMShareable
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomshareable-getowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOwner(out nint owner);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomshareable-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetType(out XPS_OBJECT_TYPE type);
}
