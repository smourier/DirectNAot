namespace DirectN;

[GeneratedComInterface, Guid("1c55a64c-07cd-4fb5-90f7-b753d91f0c9e")]
public partial interface IImgCreateErrorInfo : ICreateErrorInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AttachToErrorInfo(ref ImgErrorInfo pErrorInfo);
}
