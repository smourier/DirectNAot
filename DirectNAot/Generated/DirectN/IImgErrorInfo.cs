namespace DirectN;

[GeneratedComInterface, Guid("2bce4ece-d30e-445a-9423-6829be945ad8")]
public partial interface IImgErrorInfo : IErrorInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDeveloperDescription(out BSTR pbstrDevDescription);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetUserErrorId(out Guid pErrorId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetUserParameterCount(out uint pcUserParams);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetUserParameter(uint cParam, out BSTR pbstrParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetUserFallback(out BSTR pbstrFallback);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetExceptionId(out uint pExceptionId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DetachErrorInfo(out ImgErrorInfo pErrorInfo);
}
