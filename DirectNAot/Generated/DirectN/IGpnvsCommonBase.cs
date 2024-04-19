namespace DirectN;

[GeneratedComInterface, Guid("907e0b5c-e42d-4f04-91f0-26f401f36907")]
public partial interface IGpnvsCommonBase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueUpdateName(out BSTR pbstrName);
}
