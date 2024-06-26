﻿#nullable enable
namespace DirectN;

public enum DISPID_TUNER
{
    DISPID_TUNER_TS_UNIQUENAME = 1,
    DISPID_TUNER_TS_FRIENDLYNAME = 2,
    DISPID_TUNER_TS_CLSID = 3,
    DISPID_TUNER_TS_NETWORKTYPE = 4,
    DISPID_TUNER_TS__NETWORKTYPE = 5,
    DISPID_TUNER_TS_CREATETUNEREQUEST = 6,
    DISPID_TUNER_TS_ENUMCATEGORYGUIDS = 7,
    DISPID_TUNER_TS_ENUMDEVICEMONIKERS = 8,
    DISPID_TUNER_TS_DEFAULTPREFERREDCOMPONENTTYPES = 9,
    DISPID_TUNER_TS_FREQMAP = 10,
    DISPID_TUNER_TS_DEFLOCATOR = 11,
    DISPID_TUNER_TS_CLONE = 12,
    DISPID_TUNER_TR_TUNINGSPACE = 1,
    DISPID_TUNER_TR_COMPONENTS = 2,
    DISPID_TUNER_TR_CLONE = 3,
    DISPID_TUNER_TR_LOCATOR = 4,
    DISPID_TUNER_CT_CATEGORY = 1,
    DISPID_TUNER_CT_MEDIAMAJORTYPE = 2,
    DISPID_TUNER_CT__MEDIAMAJORTYPE = 3,
    DISPID_TUNER_CT_MEDIASUBTYPE = 4,
    DISPID_TUNER_CT__MEDIASUBTYPE = 5,
    DISPID_TUNER_CT_MEDIAFORMATTYPE = 6,
    DISPID_TUNER_CT__MEDIAFORMATTYPE = 7,
    DISPID_TUNER_CT_MEDIATYPE = 8,
    DISPID_TUNER_CT_CLONE = 9,
    DISPID_TUNER_LCT_LANGID = 100,
    DISPID_TUNER_MP2CT_TYPE = 200,
    DISPID_TUNER_ATSCCT_FLAGS = 300,
    DISPID_TUNER_L_CARRFREQ = 1,
    DISPID_TUNER_L_INNERFECMETHOD = 2,
    DISPID_TUNER_L_INNERFECRATE = 3,
    DISPID_TUNER_L_OUTERFECMETHOD = 4,
    DISPID_TUNER_L_OUTERFECRATE = 5,
    DISPID_TUNER_L_MOD = 6,
    DISPID_TUNER_L_SYMRATE = 7,
    DISPID_TUNER_L_CLONE = 8,
    DISPID_TUNER_L_ATSC_PHYS_CHANNEL = 201,
    DISPID_TUNER_L_ATSC_TSID = 202,
    DISPID_TUNER_L_ATSC_MP2_PROGNO = 203,
    DISPID_TUNER_L_DVBT_BANDWIDTH = 301,
    DISPID_TUNER_L_DVBT_LPINNERFECMETHOD = 302,
    DISPID_TUNER_L_DVBT_LPINNERFECRATE = 303,
    DISPID_TUNER_L_DVBT_GUARDINTERVAL = 304,
    DISPID_TUNER_L_DVBT_HALPHA = 305,
    DISPID_TUNER_L_DVBT_TRANSMISSIONMODE = 306,
    DISPID_TUNER_L_DVBT_INUSE = 307,
    DISPID_TUNER_L_DVBT2_PHYSICALLAYERPIPEID = 351,
    DISPID_TUNER_L_DVBS_POLARISATION = 401,
    DISPID_TUNER_L_DVBS_WEST = 402,
    DISPID_TUNER_L_DVBS_ORBITAL = 403,
    DISPID_TUNER_L_DVBS_AZIMUTH = 404,
    DISPID_TUNER_L_DVBS_ELEVATION = 405,
    DISPID_TUNER_L_DVBS2_DISEQ_LNB_SOURCE = 406,
    DISPID_TUNER_TS_DVBS2_LOW_OSC_FREQ_OVERRIDE = 407,
    DISPID_TUNER_TS_DVBS2_HI_OSC_FREQ_OVERRIDE = 408,
    DISPID_TUNER_TS_DVBS2_LNB_SWITCH_FREQ_OVERRIDE = 409,
    DISPID_TUNER_TS_DVBS2_SPECTRAL_INVERSION_OVERRIDE = 410,
    DISPID_TUNER_L_DVBS2_ROLLOFF = 411,
    DISPID_TUNER_L_DVBS2_PILOT = 412,
    DISPID_TUNER_L_ANALOG_STANDARD = 601,
    DISPID_TUNER_L_DTV_O_MAJOR_CHANNEL = 701,
    DISPID_TUNER_C_TYPE = 1,
    DISPID_TUNER_C_STATUS = 2,
    DISPID_TUNER_C_LANGID = 3,
    DISPID_TUNER_C_DESCRIPTION = 4,
    DISPID_TUNER_C_CLONE = 5,
    DISPID_TUNER_C_MP2_PID = 101,
    DISPID_TUNER_C_MP2_PCRPID = 102,
    DISPID_TUNER_C_MP2_PROGNO = 103,
    DISPID_TUNER_C_ANALOG_AUDIO = 201,
    DISPID_TUNER_TS_DVB_SYSTEMTYPE = 101,
    DISPID_TUNER_TS_DVB2_NETWORK_ID = 102,
    DISPID_TUNER_TS_DVBS_LOW_OSC_FREQ = 1001,
    DISPID_TUNER_TS_DVBS_HI_OSC_FREQ = 1002,
    DISPID_TUNER_TS_DVBS_LNB_SWITCH_FREQ = 1003,
    DISPID_TUNER_TS_DVBS_INPUT_RANGE = 1004,
    DISPID_TUNER_TS_DVBS_SPECTRAL_INVERSION = 1005,
    DISPID_TUNER_TS_AR_MINFREQUENCY = 101,
    DISPID_TUNER_TS_AR_MAXFREQUENCY = 102,
    DISPID_TUNER_TS_AR_STEP = 103,
    DISPID_TUNER_TS_AR_COUNTRYCODE = 104,
    DISPID_TUNER_TS_AUX_COUNTRYCODE = 101,
    DISPID_TUNER_TS_ATV_MINCHANNEL = 101,
    DISPID_TUNER_TS_ATV_MAXCHANNEL = 102,
    DISPID_TUNER_TS_ATV_INPUTTYPE = 103,
    DISPID_TUNER_TS_ATV_COUNTRYCODE = 104,
    DISPID_TUNER_TS_ATSC_MINMINORCHANNEL = 201,
    DISPID_TUNER_TS_ATSC_MAXMINORCHANNEL = 202,
    DISPID_TUNER_TS_ATSC_MINPHYSCHANNEL = 203,
    DISPID_TUNER_TS_ATSC_MAXPHYSCHANNEL = 204,
    DISPID_TUNER_TS_DC_MINMAJORCHANNEL = 301,
    DISPID_TUNER_TS_DC_MAXMAJORCHANNEL = 302,
    DISPID_TUNER_TS_DC_MINSOURCEID = 303,
    DISPID_TUNER_TS_DC_MAXSOURCEID = 304,
    DISPID_CHTUNER_ATVAC_CHANNEL = 101,
    DISPID_CHTUNER_ATVDC_SYSTEM = 101,
    DISPID_CHTUNER_ATVDC_CONTENT = 102,
    DISPID_CHTUNER_CIDTR_CHANNELID = 101,
    DISPID_CHTUNER_CTR_CHANNEL = 101,
    DISPID_CHTUNER_ACTR_MINOR_CHANNEL = 201,
    DISPID_CHTUNER_DCTR_MAJOR_CHANNEL = 301,
    DISPID_CHTUNER_DCTR_SRCID = 302,
    DISPID_DVBTUNER_DVBC_ATTRIBUTESVALID = 101,
    DISPID_DVBTUNER_DVBC_PID = 102,
    DISPID_DVBTUNER_DVBC_TAG = 103,
    DISPID_DVBTUNER_DVBC_COMPONENTTYPE = 104,
    DISPID_DVBTUNER_ONID = 101,
    DISPID_DVBTUNER_TSID = 102,
    DISPID_DVBTUNER_SID = 103,
    DISPID_MP2TUNER_TSID = 101,
    DISPID_MP2TUNER_PROGNO = 102,
    DISPID_MP2TUNERFACTORY_CREATETUNEREQUEST = 1,
}
