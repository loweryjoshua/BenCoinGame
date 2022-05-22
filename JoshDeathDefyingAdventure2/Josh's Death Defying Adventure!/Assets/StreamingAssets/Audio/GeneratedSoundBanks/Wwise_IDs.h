/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID COIN_PICKUP = 98870701U;
        static const AkUniqueID MAINGAME_MUSIC = 4271964152U;
        static const AkUniqueID RESET = 4017455162U;
        static const AkUniqueID STEP_START = 2266592114U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace MUSIC_REGIONS
        {
            static const AkUniqueID GROUP = 2106907484U;

            namespace STATE
            {
                static const AkUniqueID ENDING = 3966194980U;
                static const AkUniqueID MAINGAME = 1731745708U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace MUSIC_REGIONS

        namespace STARTSTOP
        {
            static const AkUniqueID GROUP = 1092400375U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID START = 1281810935U;
                static const AkUniqueID STOP = 788884573U;
            } // namespace STATE
        } // namespace STARTSTOP

    } // namespace STATES

    namespace SWITCHES
    {
        namespace SURFACE_TYPE
        {
            static const AkUniqueID GROUP = 4064446173U;

            namespace SWITCH
            {
                static const AkUniqueID BLOCK = 4001580976U;
                static const AkUniqueID STAIR = 1164367372U;
            } // namespace SWITCH
        } // namespace SURFACE_TYPE

    } // namespace SWITCHES

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID SFX = 393239870U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
