﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msopc/ne-msopc-opc_signature_time_format
public enum OPC_SIGNATURE_TIME_FORMAT
{
    OPC_SIGNATURE_TIME_FORMAT_MILLISECONDS = 0,
    OPC_SIGNATURE_TIME_FORMAT_SECONDS = 1,
    OPC_SIGNATURE_TIME_FORMAT_MINUTES = 2,
    OPC_SIGNATURE_TIME_FORMAT_DAYS = 3,
    OPC_SIGNATURE_TIME_FORMAT_MONTHS = 4,
    OPC_SIGNATURE_TIME_FORMAT_YEARS = 5,
}
