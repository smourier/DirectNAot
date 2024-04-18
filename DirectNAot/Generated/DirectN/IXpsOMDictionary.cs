namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomdictionary
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("897c86b8-8eaf-4ae3-bdde-56419fcf4236")]
public partial interface IXpsOMDictionary
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdictionary-getowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOwner(out nint owner);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdictionary-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCount(out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdictionary-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAt(uint index, out PWSTR key, out IXpsOMShareable entry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdictionary-getbykey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetByKey(PWSTR key, IXpsOMShareable beforeEntry, out IXpsOMShareable entry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdictionary-getindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetIndex(IXpsOMShareable entry, out uint index);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdictionary-append
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Append(PWSTR key, IXpsOMShareable entry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdictionary-insertat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT InsertAt(uint index, PWSTR key, IXpsOMShareable entry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdictionary-removeat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RemoveAt(uint index);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdictionary-setat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAt(uint index, PWSTR key, IXpsOMShareable entry);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdictionary-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Clone(out IXpsOMDictionary dictionary);
}
