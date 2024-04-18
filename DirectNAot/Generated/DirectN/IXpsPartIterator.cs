namespace DirectN;

[GeneratedComInterface, Guid("0021d3cd-af6f-42ab-9999-14bc82a62d2e")]
public partial interface IXpsPartIterator
{
    [PreserveSig]
    public void Reset();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Current(out BSTR pUri, out nint ppXpsPart);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsDone();
    
    [PreserveSig]
    public void Next();
}
