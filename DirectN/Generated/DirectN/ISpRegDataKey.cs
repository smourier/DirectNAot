#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("92a66e2b-c830-4149-83df-6fc2ba1e7a5b")]
public partial interface ISpRegDataKey : ISpDataKey
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetKey(HKEY hkey, [MarshalAs(UnmanagedType.U4)] bool fReadOnly);
}
