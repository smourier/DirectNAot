namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msopc/ne-msopc-opc_canonicalization_method
public enum OPC_CANONICALIZATION_METHOD
{
    OPC_CANONICALIZATION_NONE = 0,
    OPC_CANONICALIZATION_C14N = 1,
    OPC_CANONICALIZATION_C14N_WITH_COMMENTS = 2,
}
