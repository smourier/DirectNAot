namespace DirectN;

[GeneratedComInterface, Guid("7bb38260-d19c-11d2-b38a-00a0c95ec22e")]
public partial interface IKsPinEx : IKsPin
{
    [PreserveSig]
    void KsNotifyError(IMediaSample Sample, HRESULT hr);
}
