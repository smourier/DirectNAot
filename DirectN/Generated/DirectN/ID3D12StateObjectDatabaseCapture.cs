#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("d67447bc-4d6c-4ca5-a2a8-deeea4c145c4")]
public partial interface ID3D12StateObjectDatabaseCapture
{
    [PreserveSig]
    void EnableCapture(BOOL Enable, PWSTR pDatabaseFile);
}
