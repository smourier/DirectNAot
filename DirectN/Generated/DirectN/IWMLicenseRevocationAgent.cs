#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmlicenserevocationagent
[GeneratedComInterface, Guid("6967f2c9-4e26-4b57-8894-799880f7ac7b")]
public partial interface IWMLicenseRevocationAgent
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmlicenserevocationagent-getlrbchallenge
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLRBChallenge(nint /* byte array */ pMachineID, uint dwMachineIDLength, nint /* byte array */ pChallenge, uint dwChallengeLength, nint /* byte array */ pChallengeOutput, out uint pdwChallengeOutputLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmlicenserevocationagent-processlrb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessLRB(nint /* byte array */ pSignedLRB, uint dwSignedLRBLength, nint /* byte array */ pSignedACK, out uint pdwSignedACKLength);
}
