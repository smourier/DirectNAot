namespace DirectN;

[GeneratedComInterface, Guid("8ba5fb08-5195-40e2-ac58-0d989c3a0102")]
public partial interface ID3DBlob
{
    [PreserveSig]
    public void GetBufferPointer();
    
    [PreserveSig]
    public nuint GetBufferSize();
}
