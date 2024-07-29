#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("fb6904c4-42f0-4b62-9c46-983af7da7c83")]
public partial interface IDxcVersionInfo2 : IDxcVersionInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCommitInfo(out uint pCommitCount, out nint pCommitHash);
}
