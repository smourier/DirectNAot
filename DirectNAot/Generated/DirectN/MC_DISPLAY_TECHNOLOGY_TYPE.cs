namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/ne-highlevelmonitorconfigurationapi-mc_display_technology_type
public enum MC_DISPLAY_TECHNOLOGY_TYPE
{
    MC_SHADOW_MASK_CATHODE_RAY_TUBE = 0,
    MC_APERTURE_GRILL_CATHODE_RAY_TUBE = 1,
    MC_THIN_FILM_TRANSISTOR = 2,
    MC_LIQUID_CRYSTAL_ON_SILICON = 3,
    MC_PLASMA = 4,
    MC_ORGANIC_LIGHT_EMITTING_DIODE = 5,
    MC_ELECTROLUMINESCENT = 6,
    MC_MICROELECTROMECHANICAL = 7,
    MC_FIELD_EMISSION_DEVICE = 8,
}
