namespace DirectN
{
    public static partial class Constants
    {
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT S_OK = 0;
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT S_FALSE = 1;
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT E_FAIL = unchecked((int)0x80004005);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT E_NOINTERFACE = unchecked((int)0x80004002);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT E_INVALIDARG = unchecked((int)0x80070057);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT E_ACCESSDENIED = unchecked((int)0x80070005);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT E_NOTIMPL = unchecked((int)0x80004001);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT E_NOT_VALID_STATE = unchecked((int)0x8007139F);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT E_UNEXPECTED = unchecked((int)0x8000FFFF);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT E_NOT_SUFFICIENT_BUFFER = unchecked((int)0x8007007A);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT E_BOUNDS = unchecked((int)0x8000000B);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT E_POINTER = unchecked((int)0x80004003);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT ERROR_CANCELLED = unchecked((int)0x800704C7);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT ERROR_INTERNAL_ERROR = unchecked((int)0x8007054F);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT ERROR_INVALID_DATA = unchecked((int)0x8007000D);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT ERROR_INVALID_OPERATION = unchecked((int)0x800710DD);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT ERROR_INVALID_NAME = unchecked((int)0x8007007B);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT ERROR_INVALID_HANDLE = unchecked((int)0x80070006);
        [MarshalAs(UnmanagedType.Error)] public static readonly HRESULT DISP_E_EXCEPTION = unchecked((int)0x80020009);
    }
}
