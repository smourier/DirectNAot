namespace DirectN;

[GeneratedComInterface, Guid("9e184d15-cdb7-4f86-b49e-566689f4a601")]
public partial interface IMFMediaEngineEMENotify
{
    [PreserveSig]
    void Encrypted(nint /* byte array */ pbInitData, uint cb, BSTR bstrInitDataType);
    
    [PreserveSig]
    void WaitingForKey();
}
