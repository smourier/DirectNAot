namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-ierrorlog
[GeneratedComInterface, Guid("3127ca40-446e-11ce-8135-00aa004bb851")]
public partial interface IErrorLog
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-ierrorlog-adderror
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddError(PWSTR pszPropName, in EXCEPINFO pExcepInfo);
}
