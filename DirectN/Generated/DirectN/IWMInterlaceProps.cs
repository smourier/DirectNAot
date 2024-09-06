#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("7b12e5d1-bd22-48ea-bc06-98e893221c89")]
public partial interface IWMInterlaceProps
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProcessType(int iProcessType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInitInverseTeleCinePattern(int iInitPattern);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLastFrame();
}
