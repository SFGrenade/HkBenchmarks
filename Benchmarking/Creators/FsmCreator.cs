using System.Collections.Generic;
using Benchmarking.Utils;
using HutongGames.PlayMaker;
// ReSharper disable StringLiteralTypo
// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable SuggestVarOrType_Elsewhere
// ReSharper disable SuggestVarOrType_BuiltInTypes

namespace Benchmarking.Creators;

public struct FsmEntry
{
    public PlayMakerFSM Fsm;
    public string SearchState;
}
public static class FsmCreator
{
    private static List<FsmEntry> _fsmList = new();

    static FsmCreator()
    {
        
    }

    private static PlayMakerFSM MakePlayMakerFsm(string[] stateNames)
    {
        PlayMakerFSM ret = new PlayMakerFSM();
        Fsm fsm = new Fsm();
        FsmState[] fsmStates = new FsmState[stateNames.Length];
        for (int i = 0; i < stateNames.Length; i++)
        {
            fsmStates[i] = new FsmState(fsm)
            {
                Name = stateNames[i]
            };
        }

        fsm.States = fsmStates;
        ret.SetAttr("fsm", fsm);
        return ret;
    }

    public static string[] CreateFsmStateNameArray()
    {
        return new[]
        {
            "Init",
            "Init",
            " ",
            "Initiliase",
            "WaitForRespawn",
            "RumblingSmall",
            "Init",
            "Idle",
            "Init",
            "Fade In",
            "Init",
            "Init",
            "End",
            "End",
            "End",
            "End",
            "End",
            "End",
            "End",
            "End",
            "Anim 1",
            "Anim 1",
            "Anim 1",
            "Anim 1",
            "Anim 1",
            "Anim 1",
            "Anim 1",
            "Anim 1",
            "Init",
            "Init",
            " ",
            "Initiliase",
            "WaitForRespawn",
            "RumblingSmall",
            "Init",
            "Idle",
            "Init",
            "Fade In",
            "Init",
            "Init",
            "End",
            "End",
            "End",
            "End",
            "End",
            "End",
            "End",
            "End",
            "Anim 1",
            "Anim 1",
            "Anim 1",
            "Anim 1",
            "Anim 1",
            "Anim 1",
            "Anim 1",
            "Anim 1",
            "Idle",
            "Init",
            "Check",
            "Check",
            "Idle",
            "Idle",
            "Init",
            "Cooldown",
            "Held Down",
            "Init",
            "Idle",
            "Idle",
            "Cyclone Start",
            "Check HP",
            "Death",
            "Idle",
            "Focusing",
            "Down",
            "Equipped",
            "Relinquish Control",
            "Equipped",
            "Idle",
            "Idle",
            "Focus Completed",
            "Slash Antic",
            "Idle",
            "Equipped",
            "Idle",
            "Flip",
            "Idle",
            "Idle",
            "Idle",
            "Idle",
            "Down",
            "Ready",
            "Down",
            "Check Equipped",
            "Set Damage",
            "Cancel All",
            "Idle",
            "Check",
            "Idle",
            "Idle",
            "Idle",
            "Idle",
            "Check",
            "Init",
            "Inert",
            "Unequipped",
            "Idle",
            "Idle",
            "Idle",
            "Idle",
            "Check Pause",
            "Leak",
            "Check",
            "Check",
            "Idle",
            "Idle",
            "Playing",
            "Idle",
            "State 1",
            "State 1",
            "Down",
            "State 1",
            "State 1",
            "Follow",
            " ",
            "State 1",
            "State 1",
            "State 1",
            "State 1",
            "State 1",
            "State 1",
            "State 1",
            "Idle",
            "Check Proximity",
            "Init",
            "Init",
            "State 1",
            "Pause",
            "Idle",
            "Turn Right",
            "Idle",
            "State 1",
            "State 1",
            "Follow",
            "State 1",
            "Init",
            "Init",
            "Down",
            "Hide",
            "Idle",
            "Hide",
            "Idle",
            "Init",
            "Init",
            "Init",
            "Not",
            "Not",
            "State 1",
            "Globalise",
            "Empty",
            "Not",
            "Fade In",
            "Hide",
            "Init",
            "Not",
            "Fade In",
            "Down",
            "No Charm",
            "Not",
            "Select Down",
            "Init",
            "Up",
            "Idle",
            "Down",
            "Conversation End",
            "Not",
            "Check",
            "Down",
            "Init",
            "Down",
            "Down",
            "Down",
            "Check",
            "Idle",
            "Down",
            "Not",
            "Down",
            "Not",
            "Check",
            "Get Text",
            "Empty",
            "Box Down",
            "Pause",
            "Init",
            "Not",
            "Globalise",
            "State 1",
            "Not",
            "Init",
            "MP Full",
            "Check",
            "Up To Quarter",
            "Empty",
            "Empty",
            "Down",
            "Select Down",
            "Not",
            "Idle",
            "Equipped?",
            "Down",
            "Down",
            "Not",
            "Down",
            "Not",
            "Down",
            "Not",
            "Up To Quarter",
            "Down",
            "Not",
            "Set",
            "Idle",
            "Down",
            "Not",
            "Idle",
            "Empty",
            "Check Vendor",
            "Down",
            "Idle",
            "Down",
            "Start Small",
            "Not",
            "Not",
            "Down",
            "Down",
            "Down",
            "Drain Pause",
            "Close",
            "Init",
            "Not",
            "Empty",
            "Down",
            "Not",
            "Not",
            "Fade In",
            "Init",
            "Not",
            "Not",
            "Check",
            "Down",
            "Init",
            "Init",
            "Start Under",
            "Down",
            "Idle",
            "Init",
            "Empty",
            "Check",
            "Down",
            "Not",
            "Instantiate",
            "Check",
            "Init",
            "Down",
            "Cancel Existing",
            "Idle",
            "Down",
            "Not",
            "Down",
            "Idle",
            "Up To Quarter",
            "Down",
            "Init",
            "Select Down",
            "Box Down",
            "Not",
            "Down",
            "Empty",
            "Start Small",
            "1",
            "Empty",
            "Init",
            "Lose",
            "Empty",
            "Check",
            "To Zero",
            "Check",
            "Empty",
            "Not",
            "Set",
            "Down",
            "Not",
            "Start Small",
            "Down",
            "Not",
            "Not",
            "Down",
            "Down",
            "Down",
            "Idle",
            "Init",
            "Start Small",
            "Open",
            "Open Map",
            "Set",
            "Down",
            "Not",
            "Idle",
            "Idle",
            "Down",
            "Low Health?",
            "Check",
            "Not",
            "Not",
            "Init",
            "Check",
            "Check",
            "Idle",
            "Box Down",
            "Not",
            "Idle",
            "Init",
            "Idle",
            "Appear Normal",
            "Not",
            "Down",
            "Init",
            "Idle",
            "T Down",
            "Down",
            "Activate",
            "Idle",
            "Down",
            "Activate",
            "Idle",
            "Not",
            "Not",
            "Down",
            "Up To Quarter",
            "Down",
            "Shift?",
            "Check",
            "Not",
            "Down",
            "Not",
            "Page End",
            "Not",
            "Down",
            "Pause",
            "Unselected",
            "Pause",
            "Up",
            "Down",
            "Down",
            "Pause",
            "Down",
            "Pause",
            "Down",
            "Unselected",
            "Pause",
            "Down",
            "Unselected",
            "Unselected",
            "Down",
            "Down",
            "Pause",
            "Pause",
            "Down",
            "Pause",
            "Pause",
            "Unselected",
            "Down",
            "Down",
            "Down",
            "Pause",
            "Down",
            "Down",
            "Pause",
            "Pause",
            "Pause",
            "Down",
            "Down",
            "Pause",
            "Pause",
            "Pause",
            "Pause",
            "Down",
            "Down",
            "Down",
            "Down",
            "Down",
            "Pause",
            "Unselected",
            "Down",
            "Unselected",
            "Unselected",
            "Down",
            "Down",
            "Pause",
            "Down",
            "Down",
            "Down",
            "City",
            "Unselected",
            "Down",
            "Unselected",
            "Down",
            "Down",
            "Unselected",
            "Unselected",
            "Pause",
            "Pause",
            "Down",
            "Down",
            "Pause",
            "Unselected",
            "Down",
            "Unselected",
            "Pause",
            "Down",
            "Unselected",
            "Down",
            "Shift?",
            "Shift?",
            "Shift?",
            "Shift?",
            "Shift?",
            "Init",
            "Down",
            "Attack",
            "Idle",
            "Init",
            "Pause",
            "Go Up",
        };
    }

    public static PlayMakerFSM[] CreateFsmArray()
    {
        return new[]
        {
            MakePlayMakerFsm(new[]
            {
                // Blanker Control
                "Init",
                "Fade In",
                "Fade Out",
                "Idle",
            }),
            MakePlayMakerFsm(new[]
            {
                // Blanker Control
                "Init",
                "Fade In",
                "Fade Out",
                "Idle",
            }),
            MakePlayMakerFsm(new[]
            {
                // PlayMaker Unity 2D
                " ",
            }),
            MakePlayMakerFsm(new[]
            {
                // InitFSM
                "Initiliase",
                "Playing",
            }),
            MakePlayMakerFsm(new[]
            {
                // CameraFade
                "Normal",
                "FadingOut",
                "FadeIn",
                "Done",
                "RespawnFadingOut",
                "WaitForRespawn",
                "HazardFadingOut",
                "WaitForHazardRespawn",
                "Just Fading",
                "Instant Fade",
                "Start Fade",
                "Fade Back",
                "Init",
                "Wait For Fade In",
                "Slow Fade In",
                "White Fade In?",
                "Set Black",
                "Set White",
                "White Fade In? 2",
                "Set White 2",
                "Set Black 2",
                "Instant Fade In",
                "Pause",
                "Pre Fade",
                "Insta Fade Out",
                "Fade Out Instant",
            }),
            MakePlayMakerFsm(new[]
            {
                // CameraShake
                "Normal",
                "ShakingBig",
                "ShakingAverage",
                "ShakingSmall",
                "ShakingKill",
                "RumblingSmall",
                "To Big Shake",
                "To Average Shake",
                "To Kill Shake",
                "To Small Shake",
                "RumblingMed",
                "RumblingFocus",
                "RumblingFall",
                "Init",
                "RumblingFocus 2",
                "To SD Shake",
                "Shaking Super Dash",
                "Tram Shake",
                "New Scene Reset",
                "RumblingBig",
                "Blizzard Shake",
                "RumblingHuge",
                "CancelAllShake",
                "ShakingHuge",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Hero Damaged Effects
                "Idle",
                "To Lowpass",
                "Fade Back",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Blanker Control
                "Init",
                "Fade In",
                "Fade Out",
                "Idle",
                "Hide",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
                "Set",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // Blanker Control
                "Init",
                "Fade In",
                "Fade Out",
                "Idle",
            }),
            MakePlayMakerFsm(new[]
            {
                // Blanker Control
                "Init",
                "Fade In",
                "Fade Out",
                "Idle",
            }),
            MakePlayMakerFsm(new[]
            {
                // PlayMaker Unity 2D
                " ",
            }),
            MakePlayMakerFsm(new[]
            {
                // InitFSM
                "Initiliase",
                "Playing",
            }),
            MakePlayMakerFsm(new[]
            {
                // CameraFade
                "Normal",
                "FadingOut",
                "FadeIn",
                "Done",
                "RespawnFadingOut",
                "WaitForRespawn",
                "HazardFadingOut",
                "WaitForHazardRespawn",
                "Just Fading",
                "Instant Fade",
                "Start Fade",
                "Fade Back",
                "Init",
                "Wait For Fade In",
                "Slow Fade In",
                "White Fade In?",
                "Set Black",
                "Set White",
                "White Fade In? 2",
                "Set White 2",
                "Set Black 2",
                "Instant Fade In",
                "Pause",
                "Pre Fade",
                "Insta Fade Out",
                "Fade Out Instant",
            }),
            MakePlayMakerFsm(new[]
            {
                // CameraShake
                "Normal",
                "ShakingBig",
                "ShakingAverage",
                "ShakingSmall",
                "ShakingKill",
                "RumblingSmall",
                "To Big Shake",
                "To Average Shake",
                "To Kill Shake",
                "To Small Shake",
                "RumblingMed",
                "RumblingFocus",
                "RumblingFall",
                "Init",
                "RumblingFocus 2",
                "To SD Shake",
                "Shaking Super Dash",
                "Tram Shake",
                "New Scene Reset",
                "RumblingBig",
                "Blizzard Shake",
                "RumblingHuge",
                "CancelAllShake",
                "ShakingHuge",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Hero Damaged Effects
                "Idle",
                "To Lowpass",
                "Fade Back",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Blanker Control
                "Init",
                "Fade In",
                "Fade Out",
                "Idle",
                "Hide",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
                "Set",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Strike
                "Effect",
                "End",
                "Reset",
                "Dormant",
                "Vibrate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Choose Anim",
                "Anim 1",
                "Anim 2",
                "Anim",
                "Recycle",
                "Reset",
                "Dormant",
            }),
            MakePlayMakerFsm(new[]
            {
                // damages_enemy
                "Idle",
                "Send Event",
                "Parent",
                "Grandparent",
            }),
            MakePlayMakerFsm(new[]
            {
                // Map Control
                "Inactive",
                "Button Down Check",
                "Open Map",
                "Regain Control",
                "Close Map",
                "Init",
                "Has Map?",
                "Cancel All",
                "Can QuickMap?",
                "Button Still Down?",
                "Double!",
                "Reset Timer",
                "Check Double",
                "Close Doub Check",
                "Double Fail",
                "Map Idle",
                "Walk Left",
                "Walk Right",
                "Quick Cancel",
                "Turn L?",
                "Turn R?",
                "Pause",
                "Get Inventory",
                "No Inv",
                "Extra Check",
            }),
            MakePlayMakerFsm(new[]
            {
                // Enemy Recoil Up
                "Check",
                "Equipped",
                "Init",
                "Unequipped",
            }),
            MakePlayMakerFsm(new[]
            {
                // White Charm
                "Pause",
                "Check",
                "Inactive",
                "Wait",
                "SOUL Check",
                "Soul UP",
            }),
            MakePlayMakerFsm(new[]
            {
                // Play
                "Idle",
                "Play",
                "Replay",
            }),
            MakePlayMakerFsm(new[]
            {
                // Play
                "Idle",
                "Play",
                "Replay",
            }),
            MakePlayMakerFsm(new[]
            {
                // Control
                "Init",
                "Out of Acid",
                "Enter Acid",
            }),
            MakePlayMakerFsm(new[]
            {
                // Spore Cooldown
                "Idle",
                "Cooldown",
                "Reset",
                "Init",
                "Dung",
            }),
            MakePlayMakerFsm(new[]
            {
                // Spell Control
                "Inactive",
                "Button Down",
                "Focus Start",
                "Regain Control",
                "Focus Cancel",
                "Init",
                "Focus",
                "Can Focus?",
                "Focus Heal",
                "Cancel All",
                "Has Fireball?",
                "Fireball 1",
                "Focus Get Finish",
                "Fireball Recoil",
                "Spell End",
                "Fireball Antic",
                "Fireball 2",
                "Can Cast?",
                "Full HP?",
                "Back In?",
                "Held Down",
                "Spell Choice",
                "Has Quake?",
                "Quake Antic",
                "Quake1 Down",
                "Quake1 Land",
                "On Ground?",
                "Q On Ground",
                "Q Off Ground",
                "Quake Finish",
                "Wallside?",
                "Has Scream?",
                "Scream Antic1",
                "Scream Burst 1",
                "Scream End",
                "End Roar",
                "Quake2 Down",
                "Q2 Land",
                "Q2 Pillar",
                "Scream Burst 2",
                "Scream End 2",
                "End Roar 2",
                "FSM Cancel",
                "Level Check",
                "Level Check 2",
                "Set Focus Speed",
                "Level Check 3",
                "Set Full",
                "Grace Check",
                "First Grace Check",
                "Reset Cam Zoom",
                "Focus Start D",
                "Focus Cancel D",
                "Focus D",
                "Keep Focus",
                "Scream Get?",
                "SG Antic",
                "Scream Burst 3",
                "Send Event",
                "Spore Cloud",
                "Set HP Amount",
                "Deep Focus Speed",
                "Dung Cloud",
                "Focus S",
                "Focus Heal 2",
                "Focus Get Finish 2",
                "Full HP? 2",
                "Set Full 2",
                "Grace Check 2",
                "First Grace Check 2",
                "Spore Cloud 2",
                "Set HP Amount 2",
                "Dung Cloud 2",
                "Slug?",
                "Start Slug Anim",
                "Focus Cancel 2",
                "Turn Anim L?",
                "Anim Check",
                "Normal",
                "Focus Left",
                "Turn Anim R?",
                "Slug Speed",
                "Start MP Drain",
                "Focus Right",
                "Speedup?",
                "Blocker",
                "Shroom",
                "Combo",
                "Pause",
                "Scream Antic2",
                "Enter Quake",
                "Can Cast? QC",
                "QC",
                "Dream Focus End",
                "Reset Damage Mode",
                "Q1 Effect",
                "Q2 Effect",
                "Cancel",
            }),
            MakePlayMakerFsm(new[]
            {
                // Control Audio
                "Init",
                "Play",
                "Stop",
            }),
            MakePlayMakerFsm(new[]
            {
                // Play
                "Idle",
                "Play",
                "Replay",
            }),
            MakePlayMakerFsm(new[]
            {
                // superdash_crystal_gen
                "Init",
                "Idle",
                "Charging",
                "No Floor",
                "Reset Pos",
                "Send Cancel",
            }),
            MakePlayMakerFsm(new[]
            {
                // Nail Arts
                "Inactive",
                "Regain Control",
                "Init",
                "Cancel All",
                "Can Nail Art?",
                "Take Control",
                "Move Choice",
                "Cyclone Start",
                "Cyclone Spin",
                "Cyclone Extend",
                "Cyclone End",
                "Cyc Send Msg",
                "Activate Slash",
                "Hover Start",
                "Flash",
                "Wallslide?",
                "Has Cyclone?",
                "Has G Slash?",
                "G Slash",
                "Flash 2",
                "G Slash End",
                "Facing?",
                "Left",
                "Right",
                "Stop Move",
                "Has Dash?",
                "Dash Slash Ready",
                "DSlash Start",
                "Facing? 2",
                "Left 2",
                "Right 2",
                "Dash Slash",
                "D Slash End",
                "DSlash Move End",
                "Play Audio",
            }),
            MakePlayMakerFsm(new[]
            {
                // Fury
                "Init",
                "Idle",
                "Check HP",
                "Activate",
                "Deactivate",
                "Stay Furied",
                "Recheck",
                "Joni Check",
                "Pause",
                "Init Pause",
                "HP Pause",
                "Get Ref",
            }),
            MakePlayMakerFsm(new[]
            {
                // Darkness Control
                "Init",
                "Idle",
                "Damage",
                "Damage Pause",
                "Recover",
                "Death",
                "Pause",
                "Dark Lev Check",
                "Normal",
                "Set",
                "Dark 1",
                "Dark 2",
                "Lantern",
                "Previously Dark?",
                "Dark 1 Start",
                "Lantern Up",
                "Dark 2 Start",
                "Scene Reset",
                "Normal 2",
                "Dark 1 2",
                "Dark 2 2",
                "Lantern 2",
                "Lantern Shrink",
                "Dark -1",
                "Dark -1 2",
                "Scene Reset 2",
                "Spawn Lantern Glow",
                "PAUSE",
            }),
            MakePlayMakerFsm(new[]
            {
                // superdash_crystal_gen
                "Init",
                "Idle",
                "Charging",
                "No Floor",
                "Reset Pos",
                "Send Cancel",
            }),
            MakePlayMakerFsm(new[]
            {
                // Control
                "Init",
                "Unequipped",
                "Check Equipped",
                "Equipped",
                "Focusing",
                "Focus End",
                "Shell Off",
                "Blocker Hit",
                "Shell Up",
                "Hits Left?",
                "Break",
                "Bits",
                "HUD Icon Up",
                "HUD 1",
                "HUD 2",
                "HUD 3",
                "Pause",
                "Unequip Pause",
                "Impact End",
                "Icon Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // color_fader
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Control
                "Check",
                "Equipped",
                "Init",
                "Unequipped",
                "Charms Allowed?",
                "Wait for Hero Pos",
                "Emit Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Superdash
                "Inactive",
                "Regain Control",
                "Init",
                "Can Superdash?",
                "Cancel",
                "Relinquish Control",
                "On Ground?",
                "Ground Charge",
                "Charge Cancel Ground",
                "Ground Charged",
                "Dash Start",
                "Dashing",
                "Direction",
                "Right",
                "Left",
                "Cancelable",
                "Air Cancel",
                "Hit Wall",
                "Wall Charge",
                "Charge Cancel Wall",
                "Wall Charged",
                "Direction Wall",
                "G Right",
                "G Left",
                "Enter Super Dash",
                "Enter L",
                "Enter Velocity",
                "Enter R",
            }),
            MakePlayMakerFsm(new[]
            {
                // Slash Size Modifiers
                "Check Mantis",
                "Equipped",
                "Init",
                "Unequipped",
                "Check Longnail",
                "Equipped 2",
                "Unequipped 2",
            }),
            MakePlayMakerFsm(new[]
            {
                // Spawn
                "Init",
                "Idle",
                "Gen Pause",
                "Gen Init",
                "Gen",
            }),
            MakePlayMakerFsm(new[]
            {
                // Spawn
                "Init",
                "Idle",
                "Gen Pause",
                "Gen Init",
                "Gen",
                "Wall R",
                "Wall L",
            }),
            MakePlayMakerFsm(new[]
            {
                // ProxyFSM
                "Idle",
                "Damaged",
                "Left Ground",
                "Focus Completed",
                "Leaving Scene",
                "Respawn",
                "Landed",
                "Init",
                "Healed Max",
                "Healed",
                "Blocker Hit",
                "Enter Super Dash",
                "End Dash",
                "Flower?",
                "Enter Quake",
                "Broadcast Damaged",
            }),
            MakePlayMakerFsm(new[]
            {
                // Dream Nail
                "Init",
                "Cancel",
                "Inactive",
                "Can Dream Nail?",
                "Take Control",
                "Start",
                "Charge",
                "Charge Cancel",
                "Regain Control",
                "Slash Antic",
                "Slash",
                "End",
                "Dream Convo",
                "Cancelable",
                "Set Jump Cancel",
                "Set Attack Cancel",
                "Cancelable Dash",
                "Set Dash Cancel",
                "Entry Cancel Check",
                "Queuing",
                "Dream Gate?",
                "Set Charge Start",
                "Set Charge",
                "Set Antic",
                "Set",
                "Set Recover",
                "Allow Dream Gate",
                "Set Fail",
                "Can Set?",
                "Spawn Gate",
                "Warp Charge",
                "Can Warp?",
                "Warp Cancel",
                "Warp Charge Start",
                "Warp Effect",
                "Warp End",
                "New Scene",
                "Leave Dream",
                "Leave Type",
                "Warp Fail",
                "Flower?",
                "Show Essence",
                "Idle Anim",
                "Boss?",
                "Set GG Waterways",
                "Check Scene",
                "Fsm Cancel",
            }),
            MakePlayMakerFsm(new[]
            {
                // Play
                "Idle",
                "Play",
                "Replay",
            }),
            MakePlayMakerFsm(new[]
            {
                // Hatchling Spawn
                "Init",
                "Check Equipped",
                "Unequipped",
                "Equipped",
                "Can Hatch?",
                "Check Count",
                "Hatch",
                "Count Remaining",
                "Respawn Check",
                "Respawn",
                "Respawn Pause",
                "Dreamgate Pause",
                "Respawn Check 2",
                "Respawn 2",
                "Charms Allowed?",
                "Wait for Hero",
            }),
            MakePlayMakerFsm(new[]
            {
                // Effect Control
                "Idle",
                "Play",
            }),
            MakePlayMakerFsm(new[]
            {
                // Roar Lock
                "Detect",
                "Lock Start",
                "Flip",
                "Check On Ground",
                "Lock Grounded",
                "Set Push Direction",
                "Regain Control",
                "Init",
                "Cancel Effects",
                "Lock Air",
                "Roar Allowed?",
            }),
            MakePlayMakerFsm(new[]
            {
                // damages_enemy
                "Idle",
                "Send Event",
                "Parent",
                "Grandparent",
            }),
            MakePlayMakerFsm(new[]
            {
                // damages_enemy
                "Idle",
                "Send Event",
                "Parent",
                "Grandparent",
            }),
            MakePlayMakerFsm(new[]
            {
                // Spawn
                "Init",
                "Idle",
                "Gen Pause",
                "Gen Init",
                "Gen",
            }),
            MakePlayMakerFsm(new[]
            {
                // damages_enemy
                "Idle",
                "Send Event",
                "Parent",
                "Grandparent",
            }),
            MakePlayMakerFsm(new[]
            {
                // color_fader
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Dream Return
                "Init",
                "Idle",
                "Check",
                "Prostrate",
                "Pause",
                "Ready",
                "Get Up",
                "Regain Control",
                "Long?",
                "GC Pause",
                "Time Pause",
                "Frame Pause",
                "Position",
                "Gate Fade",
                "Warp In",
                "On Ground?",
                "Land",
                "Ready 2",
                "Get Up 2",
                "Air Regain",
                "Save",
                "Longer Grimm Return?",
                "Prostrate Grimm",
                "Grimm Pause",
                "Abyss Check",
                "GG Return",
                "Wait until after",
                "GG Return?",
            }),
            MakePlayMakerFsm(new[]
            {
                // color_fader
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Thorn Counter
                "Idle",
                "Check Equipped",
                "Counter Start",
                "Init",
                "Counter",
                "Counter End",
                "Set Thorn Scale",
            }),
            MakePlayMakerFsm(new[]
            {
                // Set Slash Damage
                "Init",
                "Set Damage",
                "Idle",
                "Get Damage",
                "Glass Attack Modifier",
                "Set Beam Damage",
            }),
            MakePlayMakerFsm(new[]
            {
                // Surface Water
                "Inactive",
                "Init",
                "Cancel All",
                "Take Control",
                "Enter",
                "Idle",
                "Swim Left",
                "Swim Right",
                "Jump Out",
                "Regain Control",
                "Translate?",
                "Start Swimming?",
                "Frame",
            }),
            MakePlayMakerFsm(new[]
            {
                // superdash_crystal_gen
                "Init",
                "Idle",
                "Charging",
                "No Floor",
                "Reset Pos",
            }),
            MakePlayMakerFsm(new[]
            {
                // Set Spell Cost
                "Init",
                "Check",
                "Normal",
                "Mage",
                "Idle",
            }),
            MakePlayMakerFsm(new[]
            {
                // superdash_crystal_gen
                "Init",
                "Idle",
                "Charging",
                "No Floor",
                "Reset Pos",
            }),
            MakePlayMakerFsm(new[]
            {
                // HeroLight Control
                "Init",
                "Idle",
                "Damage",
                "Damage Pause",
                "Recover",
                "Death",
            }),
            MakePlayMakerFsm(new[]
            {
                // Spawn
                "Init",
                "Idle",
                "Gen Pause",
                "Gen Init",
                "Gen",
                "Wall R",
                "Wall L",
            }),
            MakePlayMakerFsm(new[]
            {
                // damages_enemy
                "Idle",
                "Send Event",
                "Parent",
                "Grandparent",
            }),
            MakePlayMakerFsm(new[]
            {
                // Set Sharp Shadow Damage
                "Init",
                "Check",
                "Base",
                "Master",
                "Idle",
                "Set",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Geo Get
                "Inert",
                "Get 1",
                "Init",
                "Get 2",
            }),
            MakePlayMakerFsm(new[]
            {
                // Spawn Grimmchild
                "Init",
                "Check",
                "Unequipped",
                "Spawn",
                "Spawn Pause",
                "Idle",
                "Nightmare?",
                "No Summon",
                "Charms Allowed?",
                "Normal Spawn",
                "Wait for Hero in Position",
                "Dream?",
                "Dream Appear",
            }),
            MakePlayMakerFsm(new[]
            {
                // nail_cancel_check
                "Idle",
                "Cancel",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // nail_cancel_check
                "Idle",
                "Cancel",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Blessing Control
                "Init",
                "Idle",
                "Blessed?",
                "Blessed Pause",
                "Start Blessing",
                "Fill Soul",
                "Fill Pause",
                "End",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Play
                "Idle",
                "Play",
            }),
            MakePlayMakerFsm(new[]
            {
                // Control Interpolation
                "Idle",
                "Check Pause",
                "Check",
                "Set Interpolate",
                "Set Extrapolate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Knight Damage
                "Gen",
                "Leak",
                "Check Focus Prompt",
                "Blue Effects",
                "Muffle?",
                "Last HP?",
                "Idle",
                "Init",
                "Set Hazard",
            }),
            MakePlayMakerFsm(new[]
            {
                // Weaverling Control
                "Init",
                "Check",
                "Unequipped",
                "Spawn",
                "Spawn Pause",
                "Charms Allowed?",
                "Wait Frame",
            }),
            MakePlayMakerFsm(new[]
            {
                // Spawn Orbit Shield
                "Init",
                "Check",
                "Idle",
                "Spawn",
                "Send Slash Event",
                "Charms Allowed?",
            }),
            MakePlayMakerFsm(new[]
            {
                // nail_cancel_check
                "Idle",
                "Cancel",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // nail_cancel_check
                "Idle",
                "Cancel",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Trail Control
                "Playing",
                "End",
                "Idle",
            }),
            MakePlayMakerFsm(new[]
            {
                // nail_cancel_check
                "Idle",
                "Cancel",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Pool Flukes
                "State 1",
                "Idle",
                "Pool Black",
                "Pool Normal",
            }),
            MakePlayMakerFsm(new[]
            {
                // Pool Flukes
                "State 1",
                "Idle",
                "Pool Black",
                "Pool Normal",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Glow Noise
                "State 1",
                "State 2",
                "State 3",
            }),
            MakePlayMakerFsm(new[]
            {
                // Glow Noise
                "State 1",
                "State 2",
                "State 3",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Follow",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // PlayMaker Unity 2D
                " ",
            }),
            MakePlayMakerFsm(new[]
            {
                // Glow Noise
                "State 1",
                "State 2",
                "State 3",
            }),
            MakePlayMakerFsm(new[]
            {
                // Glow Noise
                "State 1",
                "State 2",
                "State 3",
            }),
            MakePlayMakerFsm(new[]
            {
                // Glow Noise
                "State 1",
                "State 2",
                "State 3",
            }),
            MakePlayMakerFsm(new[]
            {
                // Glow Noise
                "State 1",
                "State 2",
                "State 3",
            }),
            MakePlayMakerFsm(new[]
            {
                // Glow Noise
                "State 1",
                "State 2",
                "State 3",
            }),
            MakePlayMakerFsm(new[]
            {
                // Glow Noise
                "State 1",
                "State 2",
                "State 3",
            }),
            MakePlayMakerFsm(new[]
            {
                // Glow Noise
                "State 1",
                "State 2",
                "State 3",
            }),
            MakePlayMakerFsm(new[]
            {
                // enemy_message
                "Idle",
                "Send",
            }),
            MakePlayMakerFsm(new[]
            {
                // Inspection
                "Init",
                "Out Of Range",
                "In Range",
                "Cancel Frame",
                "Can Inspect?",
                "Check Proximity",
                "Move Hero Right",
                "Take Control",
                "Turn Hero Left",
                "Move Hero Left",
                "Turn Hero Right",
                "Prompt Up",
                "Send Text",
                "Down",
                "Regain Control",
                "Pause",
                "Blanker Up",
                "Focus Prompt?",
                "Foc Prompt Up",
                "Enemy Check",
                "Reset Text Box",
                "Turn Back",
                "Completion Prompt",
                "Set Bool",
            }),
            MakePlayMakerFsm(new[]
            {
                // Tablet Control
                "Init",
                "Away",
                "Close",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // RespawnTriggerFSM
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Glow Noise
                "State 1",
                "State 2",
                "State 3",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Pause",
                "Set",
            }),
            MakePlayMakerFsm(new[]
            {
                // enemy_message
                "Idle",
                "Send",
            }),
            MakePlayMakerFsm(new[]
            {
                // Bench Control
                "Init",
                "Idle",
                "In Range",
                "Can Rest?",
                "Cancel Frame",
                "Start Rest",
                "Rest Burst",
                "Resting",
                "Get Off",
                "Regain Control",
                "Reactivate",
                "Facing?",
                "Turn Right",
                "Turn Left",
                "Get Up",
                "Get Right",
                "Get Left",
                "Idle Pause",
                "Fall Asleep",
                "Inert",
                "Init Resting",
                "Check Start State",
                "Pause Frame",
                "Startle",
                "Open Map",
                "Close Map",
                "Save Game",
                "Game Paused?",
                "Charm Prompt?",
                "Charm Msg Down",
                "Cancel Frame 2",
                "Broadcast Event",
                "Inactive",
                "Check Inactive",
                "Update Map",
                "Sit Idle",
                "Add To Bench List",
                "Resting Init",
                "Update Map Silently",
                "Wake?",
                "Tilter?",
                "Start Tilt?",
                "Tilt translate",
                "Init Tilt",
                "Idle Start Pause",
                "Close Anim",
                "Reclose",
                "Kinemetise",
                "Pause 2",
                "Pause 3",
                "Check Start State 2",
                "Init Resting 2",
                "Map Idle",
                "Inv Map Open",
                "Save Frame",
                "Hide Prompt",
                "Re-enable Pause",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Detect Hero
                "Idle",
                "Close",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Light Pulse
                "State 1",
            }),
            MakePlayMakerFsm(new[]
            {
                // Glow Noise
                "State 1",
                "State 2",
                "State 3",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Follow",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Glow Noise
                "State 1",
                "State 2",
                "State 3",
            }),
            MakePlayMakerFsm(new[]
            {
                // Fade Control
                "Init",
                "Away",
                "Close",
                "Disappear",
            }),
            MakePlayMakerFsm(new[]
            {
                // Cancel
                "Init",
                "Idle",
                "Recycle",
                "Disappear",
            }),
            MakePlayMakerFsm(new[]
            {
                // color_fader
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Control Mesh Renderer
                "Hide",
                "Show",
            }),
            MakePlayMakerFsm(new[]
            {
                // Down
                "Idle",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Control Mesh Renderer
                "Hide",
                "Show",
            }),
            MakePlayMakerFsm(new[]
            {
                // Down
                "Idle",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Activate on Scene Load
                "Init",
                "Set",
                "Idle",
            }),
            MakePlayMakerFsm(new[]
            {
                // Init HP On Iv Open
                "Init",
                "Set",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Initial Activation
                "State 1",
                "State 2",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise Area Title
                "Globalise",
            }),
            MakePlayMakerFsm(new[]
            {
                // health_display
                "Init",
                "Check Max HP",
                "Inactive",
                "Check if Full",
                "Idle",
                "Empty",
                "Break?",
                "Heal?",
                "Appear?",
                "Max Up Appear",
                "Max Up Flash",
                "Pause",
                "Max Heal Anim",
                "Load Animation?",
                "Load Anim",
                "Charm Pause",
                "Check Type",
                "Normal",
                "Hive",
                "First Pause",
                "Last HP?",
                "ReInit",
                "Pause Frame",
                "Blue Refresh",
                "Waiting",
                "Check Bound",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Blanker Control
                "Init",
                "Fade In",
                "Fade Out",
                "Scene Reset",
                "Idle",
                "Cancel",
                "Faded Out",
            }),
            MakePlayMakerFsm(new[]
            {
                // Control
                "Init",
                "Hide",
                "Level?",
                "Set 1",
                "S1 F 1",
                "S1 F 2",
                "S1 F 3",
                "None",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Blanker Control
                "Init",
                "Fade In",
                "Fade Out",
                "Idle",
                "Fade In Instant",
                "Fade Out Instant",
                "Pause",
                "Faded Out",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Update Sprite
                "Init",
                "Update",
                "No Charm",
                "To Update",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Updated",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // ui_list_getinput
                "Init",
                "Idle",
                "Select Up",
                "Select Left",
                "Select Down",
                "Select Right",
                "Update",
                "Activate",
                "Still Up?",
                "Repeat Up",
                "Still Down?",
                "Repeat Down",
                "Still Right?",
                "Repeat Right",
                "Still Left?",
                "Repeat Left",
                "Inactive",
                "Confirm",
                "RS Up",
                "RS Down",
                "Cancel",
            }),
            MakePlayMakerFsm(new[]
            {
                // Fury Effects
                "Init",
                "Idle",
                "Fury",
            }),
            MakePlayMakerFsm(new[]
            {
                // Prompt Control
                "Init",
                "Up",
                "Down",
                "Upped",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Liquid Control
                "Idle",
                "Can Heal",
                "Can't Heal",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Dialogue Page Control
                "Init",
                "Idle",
                "Conversation End",
                "End Conversation",
                "Take Geo",
                "No",
                "Yes",
                "Activate Geo Text?",
                "Ready for Input",
                "Pause",
                "Hero Damaged",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_cost_indicator
                "Init",
                "Check",
                "Empty",
                "Full",
                "Inactive",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Update Cursor
                "Init",
                "Update",
                "Idle",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_cost_indicator
                "Init",
                "Check",
                "Empty",
                "Full",
                "Inactive",
            }),
            MakePlayMakerFsm(new[]
            {
                // Update Text
                "Init",
                "Idle",
                "Fade Down",
                "Fade Up",
                "Pane Reset",
                "Change Text",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_cost_indicator
                "Init",
                "Check",
                "Empty",
                "Full",
                "Inactive",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Get Text",
            }),
            MakePlayMakerFsm(new[]
            {
                // health_display
                "Init",
                "Check Max HP",
                "Inactive",
                "Check if Full",
                "Idle",
                "Empty",
                "Break?",
                "Heal?",
                "Appear?",
                "Max Up Appear",
                "Max Up Flash",
                "Pause",
                "Max Heal Anim",
                "Load Animation?",
                "Load Anim",
                "Charm Pause",
                "Check Type",
                "Normal",
                "Hive",
                "First Pause",
                "Last HP?",
                "ReInit",
                "Pause Frame",
                "Blue Refresh",
                "Waiting",
                "Check Bound",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // Box Open
                "Box Down",
                "Init",
                "Box Up",
                "Box Down No HUD",
            }),
            MakePlayMakerFsm(new[]
            {
                // Hive Health Regen
                "Init",
                "Idle",
                "Pause",
                "Check",
                "Inert",
                "Reset Timer",
                "Start Recovery",
                "Recover 1",
                "Recover 2",
                "Recover",
                "Cancel Recovery",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Globalise",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "State 1",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Update Cursor
                "Init",
                "Update",
                "Idle",
            }),
            MakePlayMakerFsm(new[]
            {
                // Soul Orb Control
                "Init",
                "Idle",
                "MP Drain",
                "MP <= 1",
                "MP Gain",
                "MP Full",
                "Check Can Heal",
                "Can't Heal",
                "MP Lose",
                "Check MP",
                "Check Eyes",
                "Over",
                "Under",
                "Under 2",
                "Check Eyes 2",
                "Over 2",
                "Start Full",
                "Check Focus Prompt",
                "Already Can Heal?",
                "Orb Flash?",
                "Set",
                "Pause",
                "Can Heal 2",
                "Binding?",
                "Bound",
                "Not Bound",
                "Bound Full",
                "Set?",
            }),
            MakePlayMakerFsm(new[]
            {
                // Joni Health
                "Init",
                "Check",
                "Joni",
                "Idle",
                "Normal",
            }),
            MakePlayMakerFsm(new[]
            {
                // vessel_orb
                "Init",
                "Not Obtained",
                "Down Check",
                "Down To Empty",
                "Up Check",
                "Up To Quarter",
                "Down To Quarter",
                "Down To Half",
                "Up To Half",
                "Down To 3Quarter",
                "Up To 3Quarter",
                "Down To Full",
                "Up To Full",
                "Flash?",
                "Appear?",
                "Load Anim?",
                "Load Anim",
                "Init Anim",
                "Empty",
                "Pause",
                "Bound",
                "Setup",
                "Obtained",
                "Not obtained",
            }),
            MakePlayMakerFsm(new[]
            {
                // health_display
                "Init",
                "Check Max HP",
                "Inactive",
                "Check if Full",
                "Idle",
                "Empty",
                "Break?",
                "Heal?",
                "Appear?",
                "Max Up Appear",
                "Max Up Flash",
                "Pause",
                "Max Heal Anim",
                "Load Animation?",
                "Load Anim",
                "Charm Pause",
                "Check Type",
                "Normal",
                "Hive",
                "First Pause",
                "Last HP?",
                "ReInit",
                "Pause Frame",
                "Blue Refresh",
                "Waiting",
                "Check Bound",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // health_display
                "Init",
                "Check Max HP",
                "Inactive",
                "Check if Full",
                "Idle",
                "Empty",
                "Break?",
                "Heal?",
                "Appear?",
                "Max Up Appear",
                "Max Up Flash",
                "Pause",
                "Max Heal Anim",
                "Load Animation?",
                "Load Anim",
                "Charm Pause",
                "Check Type",
                "Normal",
                "Hive",
                "First Pause",
                "Last HP?",
                "ReInit",
                "Pause Frame",
                "Blue Refresh",
                "Waiting",
                "Check Bound",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // ui_list_getinput
                "Init",
                "Idle",
                "Select Up",
                "Select Left",
                "Select Down",
                "Select Right",
                "Update",
                "Activate",
                "Still Up?",
                "Repeat Up",
                "Still Down?",
                "Repeat Down",
                "Still Right?",
                "Repeat Right",
                "Still Left?",
                "Repeat Left",
                "Inactive",
                "Confirm",
                "RS Up",
                "RS Down",
                "Cancel",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // flash
                "Idle",
                "Flash",
            }),
            MakePlayMakerFsm(new[]
            {
                // UI Charms
                "Init",
                "Inactive",
                "Cursor Down",
                "Activate",
                "Idle Collection",
                "Down",
                "Update Cursor",
                "Left",
                "Right",
                "Up",
                "Arrow L",
                "Shift Pane L",
                "Arrow R",
                "Shift Pane R",
                "Charm Collected?",
                "Collected",
                "Uncollected",
                "Build Equipped",
                "Tween Up",
                "Activate UI",
                "Check Points",
                "Set",
                "Deactivate UI",
                "Equipped?",
                "Tween Down",
                "Unequip",
                "Return Points",
                "Open Slot?",
                "No Open Slot",
                "Open Slot",
                "To Equipment",
                "Idle Equipped",
                "Get Selected",
                "To Bot",
                "Move Left",
                "Move Right",
                "Notch?",
                "Bench",
                "Not Bench",
                "Charm",
                "Set Current Item Num",
                "Activate UI Equipped",
                "Slot Open?",
                "Fail Back",
                "Fail",
                "Fail Finish",
                "Bench Reminder",
                "Open Slot? 2",
                "No Open Slot 2",
                "Open Slot 2",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Update",
                "Glass HP 2",
                "Glass Geo 2",
                "Glass Attack 2",
                "Update 2",
                "Broken?",
                "Unequippable",
                "Overcharm Check",
                "Crack 1",
                "Crack 2",
                "Break",
                "Set Overcharm",
                "Set Notch Out",
                "Over Notches",
                "Overcharmed?",
                "Over Notches 2",
                "OC Set",
                "Unequip Return",
                "End Overcharm?",
                "End Overcharm",
                "End Overcharm Indicator",
                "Remain Overcharmed",
                "Open Notch?",
                "Tink",
                "Not overcharmed",
                "Final Charm",
                "R Single",
                "R Final",
                "R Shade",
                "Royal?",
                "Black Charm?",
                "Black Charm? 2",
                "Final Charm 2",
                "R Single 2",
                "R Final 2",
                "R Shade 2",
                "Equip Prompt",
                "Equip or Unequip Prompt",
                "Con Action Down",
                "Inventory Closed",
                "Unbreakable Heart",
                "Unbreakable Greed",
                "Unbreakable Attack",
                "Unbreakable Heart 2",
                "Unbreakable Greed 2",
                "Unbreakable Attack 2",
                "Grimm?",
                "G Show",
                "G Hide",
                "Grimm? 2",
                "G Show 2",
                "G Hide 2",
                "Grimm Text",
                "Grimm Flame",
                "Grimm Complete",
                "Grimm Text 2",
                "Grimm Flame 2",
                "Grimm Complete 2",
                "Nymm",
                "Nymm 2",
                "Bound Reminder",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // vessel_orb
                "Init",
                "Not Obtained",
                "Down Check",
                "Down To Empty",
                "Up Check",
                "Up To Quarter",
                "Down To Quarter",
                "Down To Half",
                "Up To Half",
                "Down To 3Quarter",
                "Up To 3Quarter",
                "Down To Full",
                "Up To Full",
                "Flash?",
                "Appear?",
                "Load Anim?",
                "Load Anim",
                "Init Anim",
                "Empty",
                "Pause",
                "Bound",
                "Setup",
                "Obtained",
                "Not obtained",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Set",
                "Idle",
            }),
            MakePlayMakerFsm(new[]
            {
                // Blue Health Control
                "Init",
                "Idle",
                "Add Blue Health",
                "Add Existing?",
                "Add Blue Health 2",
                "Set Blue",
                "Add Joni Health",
                "Wait",
                "Hive Check",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Animate
                "Idle",
                "Animate",
            }),
            MakePlayMakerFsm(new[]
            {
                // health_display
                "Init",
                "Check Max HP",
                "Inactive",
                "Check if Full",
                "Idle",
                "Empty",
                "Break?",
                "Heal?",
                "Appear?",
                "Max Up Appear",
                "Max Up Flash",
                "Pause",
                "Max Heal Anim",
                "Load Animation?",
                "Load Anim",
                "Charm Pause",
                "Check Type",
                "Normal",
                "Hive",
                "First Pause",
                "Last HP?",
                "ReInit",
                "Pause Frame",
                "Blue Refresh",
                "Waiting",
                "Check Bound",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // Control
                "Pause",
                "Check Bench",
                "Draw Pins",
                "Check Cocoon",
                "Check Vendor",
                "Check Dream Plant",
                "Check Spa",
                "Check Stag",
                "Check Tram",
                "Check Ghost",
                "Check Grub",
                "Check Dreamer",
                "Inactive",
                "Key And Pin",
                "Down",
                "Set Backboard Y",
                "Check State",
                "Init",
                "Pin",
                "None",
                "Check Black Egg",
                "No Pins",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Pane Names
                "Init",
                "Idle",
                "Down",
                "Update text",
                "Up",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // vessel_size
                "Init",
                "Init Check",
                "Start Small",
                "Start Large",
                "Check",
                "Small",
                "Large",
                "No Change",
                "Max Inclusive?",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Vessel Drain
                "Init",
                "Idle",
                "Drain Pause",
                "Reset Pause",
                "Drain",
                "Drain Recheck",
                "Particle Check",
                "1",
                "2",
                "3",
                "4",
            }),
            MakePlayMakerFsm(new[]
            {
                // Quick Map
                "Init",
                "Idle",
                "Check Area",
                "Crossroads",
                "No Map",
                "Close",
                "Greenpath",
                "Fungal Wastes",
                "Open",
                "Dirtmouth",
                "Reset Override",
                "In Room?",
                "Get Map Zone",
                "Globalise",
                "Cliffs",
                "City",
                "Mines",
                "Resting Grounds",
                "Fog Canyon",
                "Royal Gardens",
                "Deepnest",
                "Waterways",
                "Abyss",
                "Outskirts",
                "Check State",
                "Pin On",
                "Pin Off",
            }),
            MakePlayMakerFsm(new[]
            {
                // Fader
                "Init",
                "Up",
                "Down",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // health_display
                "Init",
                "Check Max HP",
                "Inactive",
                "Check if Full",
                "Idle",
                "Empty",
                "Break?",
                "Heal?",
                "Appear?",
                "Max Up Appear",
                "Max Up Flash",
                "Pause",
                "Max Heal Anim",
                "Load Animation?",
                "Load Anim",
                "Charm Pause",
                "Check Type",
                "Normal",
                "Hive",
                "First Pause",
                "Last HP?",
                "ReInit",
                "Pause Frame",
                "Blue Refresh",
                "Waiting",
                "Check Bound",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Blanker Control
                "Init",
                "Fade In",
                "Fade Out",
                "Reset",
                "Idle",
                "Pause",
                "Faded Out",
            }),
            MakePlayMakerFsm(new[]
            {
                // Arrow Anim
                "Init",
                "Anim Up",
                "Anim Back",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_cost_indicator
                "Init",
                "Check",
                "Empty",
                "Full",
                "Inactive",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Change Fader
                "Init",
                "Up",
                "Down",
                "Delay",
            }),
            MakePlayMakerFsm(new[]
            {
                // Eyes Control
                "Init",
                "Start Under",
                "Under",
                "Start Over",
                "Over",
                "Off",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Cursor Movement
                "Init",
                "Idle",
                "Move",
                "Quick Move",
                "Inactive",
                "Cursor Activate",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Fader
                "Init",
                "Up",
                "Down",
            }),
            MakePlayMakerFsm(new[]
            {
                // health_display
                "Init",
                "Check Max HP",
                "Inactive",
                "Check if Full",
                "Idle",
                "Empty",
                "Break?",
                "Heal?",
                "Appear?",
                "Max Up Appear",
                "Max Up Flash",
                "Pause",
                "Max Heal Anim",
                "Load Animation?",
                "Load Anim",
                "Charm Pause",
                "Check Type",
                "Normal",
                "Hive",
                "First Pause",
                "Last HP?",
                "ReInit",
                "Pause Frame",
                "Blue Refresh",
                "Waiting",
                "Check Bound",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_cost_indicator
                "Init",
                "Check",
                "Empty",
                "Full",
                "Inactive",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Instantiate Game Map
                "Init Setup",
                "Instantiate",
                "Set Pan Arrows",
                "Key And Pin",
                "Check Map Key Pref",
                "Pin",
                "None",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_cost_indicator
                "Init",
                "Check",
                "Empty",
                "Full",
                "Inactive",
            }),
            MakePlayMakerFsm(new[]
            {
                // Arrow Anim
                "Init",
                "Anim Up",
                "Anim Back",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Display
                "Init",
                "Idle",
                "Cancel Existing",
                "Set Convo",
                "Check Convo",
                "Display Text",
                "Text Down",
                "Cancel",
                "Msg Text",
                "Set Sprite",
                "Return Sprite",
                "Full Cancel",
            }),
            MakePlayMakerFsm(new[]
            {
                // flash
                "Idle",
                "Flash",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // blue_health_display
                "Init",
                "Idle",
                "Off",
                "Break?",
                "Hive Check",
                "Appear",
                "Reappear",
            }),
            MakePlayMakerFsm(new[]
            {
                // vessel_orb
                "Init",
                "Not Obtained",
                "Down Check",
                "Down To Empty",
                "Up Check",
                "Up To Quarter",
                "Down To Quarter",
                "Down To Half",
                "Up To Half",
                "Down To 3Quarter",
                "Up To 3Quarter",
                "Down To Full",
                "Up To Full",
                "Flash?",
                "Appear?",
                "Load Anim?",
                "Load Anim",
                "Init Anim",
                "Empty",
                "Pause",
                "Bound",
                "Setup",
                "Obtained",
                "Not obtained",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Charm Details Cost
                "Check",
                "Init",
                "Cost 1",
                "Cost 2",
                "Cost 3",
                "Cost 4",
                "Cost 5",
                "Cost 6",
                "Cost 0",
            }),
            MakePlayMakerFsm(new[]
            {
                // ui_list_getinput
                "Init",
                "Idle",
                "Select Up",
                "Select Left",
                "Select Down",
                "Select Right",
                "Update",
                "Activate",
                "Still Up?",
                "Repeat Up",
                "Still Down?",
                "Repeat Down",
                "Still Right?",
                "Repeat Right",
                "Still Left?",
                "Repeat Left",
                "Inactive",
                "Confirm",
                "RS Up",
                "RS Down",
                "Cancel",
            }),
            MakePlayMakerFsm(new[]
            {
                // Box Open Dream
                "Box Down",
                "Init",
                "Box Up",
                "Stop Audio",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // health_display
                "Init",
                "Check Max HP",
                "Inactive",
                "Check if Full",
                "Idle",
                "Empty",
                "Break?",
                "Heal?",
                "Appear?",
                "Max Up Appear",
                "Max Up Flash",
                "Pause",
                "Max Heal Anim",
                "Load Animation?",
                "Load Anim",
                "Charm Pause",
                "Check Type",
                "Normal",
                "Hive",
                "First Pause",
                "Last HP?",
                "ReInit",
                "Pause Frame",
                "Blue Refresh",
                "Waiting",
                "Check Bound",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // vessel_size
                "Init",
                "Init Check",
                "Start Small",
                "Start Large",
                "Check",
                "Small",
                "Large",
                "No Change",
                "Max Inclusive?",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // Over Control
                "Init",
                "Idle",
                "Update Pos",
                "Display",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "Overcharmed",
                "Display Overcharm",
                "Update Pos 2",
                "Pause",
                "Fade In Notches?",
                "Redisplay",
                "Update Pos 3",
                "Update Pause",
                "Display Pause",
                "End",
            }),
            MakePlayMakerFsm(new[]
            {
                // health_display
                "Init",
                "Check Max HP",
                "Inactive",
                "Check if Full",
                "Idle",
                "Empty",
                "Break?",
                "Heal?",
                "Appear?",
                "Max Up Appear",
                "Max Up Flash",
                "Pause",
                "Max Heal Anim",
                "Load Animation?",
                "Load Anim",
                "Charm Pause",
                "Check Type",
                "Normal",
                "Hive",
                "First Pause",
                "Last HP?",
                "ReInit",
                "Pause Frame",
                "Blue Refresh",
                "Waiting",
                "Check Bound",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Geo Sprite
                "Idle",
                "Get",
                "Lose",
                "Shatter",
                "Destroy Object",
                "Init",
                "pause",
                "Appear",
                "Take",
                "First Geo Uncollected",
                "First Get",
                "Reset",
            }),
            MakePlayMakerFsm(new[]
            {
                // health_display
                "Init",
                "Check Max HP",
                "Inactive",
                "Check if Full",
                "Idle",
                "Empty",
                "Break?",
                "Heal?",
                "Appear?",
                "Max Up Appear",
                "Max Up Flash",
                "Pause",
                "Max Heal Anim",
                "Load Animation?",
                "Load Anim",
                "Charm Pause",
                "Check Type",
                "Normal",
                "Hive",
                "First Pause",
                "Last HP?",
                "ReInit",
                "Pause Frame",
                "Blue Refresh",
                "Waiting",
                "Check Bound",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_cost_indicator
                "Init",
                "Check",
                "Empty",
                "Full",
                "Inactive",
            }),
            MakePlayMakerFsm(new[]
            {
                // Geo Counter
                "Idle",
                "To Zero",
                "Add Geo",
                "Take Geo",
                "Zero Death",
                "Rand Geo",
                "Reset Counter",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_cost_indicator
                "Init",
                "Check",
                "Empty",
                "Full",
                "Inactive",
            }),
            MakePlayMakerFsm(new[]
            {
                // health_display
                "Init",
                "Check Max HP",
                "Inactive",
                "Check if Full",
                "Idle",
                "Empty",
                "Break?",
                "Heal?",
                "Appear?",
                "Max Up Appear",
                "Max Up Flash",
                "Pause",
                "Max Heal Anim",
                "Load Animation?",
                "Load Anim",
                "Charm Pause",
                "Check Type",
                "Normal",
                "Hive",
                "First Pause",
                "Last HP?",
                "ReInit",
                "Pause Frame",
                "Blue Refresh",
                "Waiting",
                "Check Bound",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Set",
                "Idle",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // vessel_size
                "Init",
                "Init Check",
                "Start Small",
                "Start Large",
                "Check",
                "Small",
                "Large",
                "No Change",
                "Max Inclusive?",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // flash
                "Idle",
                "Flash",
            }),
            MakePlayMakerFsm(new[]
            {
                // Update Vessels
                "Init",
                "Idle",
                "Send Up Msg",
                "Send Down Msg",
            }),
            MakePlayMakerFsm(new[]
            {
                // vessel_size
                "Init",
                "Init Check",
                "Start Small",
                "Start Large",
                "Check",
                "Small",
                "Large",
                "No Change",
                "Max Inclusive?",
                "Bound",
            }),
            MakePlayMakerFsm(new[]
            {
                // Open Stag
                "Idle",
                "Open",
                "Init",
                "Spawn Stag Map",
                "Inert",
                "Destroy Map",
            }),
            MakePlayMakerFsm(new[]
            {
                // Inventory Control
                "Init",
                "Closed",
                "Can Open Inventory?",
                "Open",
                "Close",
                "Regain Control",
                "Opened",
                "Check Current Pane",
                "Open inv",
                "Open charms",
                "Open Current Pane",
                "Open Journal",
                "Open Map",
                "Set R Increment",
                "Set L Increment",
                "Loop Through",
                "Next Inv",
                "Next Charms",
                "Next Journal",
                "Next Map",
                "Under",
                "Over",
                "Tween Panes",
                "Single Pane?",
                "Check R Pane",
                "Next Inv 2",
                "Next Charms 2",
                "Next Journal 2",
                "Next Map 2",
                "Under 2",
                "Over 2",
                "Opened?",
                "To Pane Checks",
                "Check L Pane",
                "Next Inv 3",
                "Next Charms 3",
                "Next Journal 3",
                "Next Map 3",
                "Under 3",
                "Over 3",
                "Open Pane Check",
                "Map Shortcut",
                "New Charm",
                "R Lock Close",
                "Regain Control 2",
                "Can Close?",
                "Init Enemy List",
                "Refresh Enemy List",
                "Calc Completion",
                "No Inv",
                "Border Up",
                "Damage Close",
                "Calc Notches",
                "Charm Equip Check?",
                "Pane Final Pos",
                "Open Equipment",
                "Next Equipment 2",
                "Next Equipment 3",
                "Next Equipment",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Set",
                "Idle",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // flash
                "Idle",
                "Flash",
            }),
            MakePlayMakerFsm(new[]
            {
                // Arrow Anim
                "Idle",
                "Up",
                "Down",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Low Health FX
                "Init",
                "Idle",
                "Low Health?",
                "Low Health",
                "Pause",
                "Low Health On Entry",
                "HUD In HP Check",
                "Overcharmed Init",
                "Overcharmed?",
                "Init Wait",
                "Pre Init",
                "Low Health Pause",
                "Wait",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_cost_indicator
                "Init",
                "Check",
                "Empty",
                "Full",
                "Inactive",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_cost_indicator
                "Init",
                "Check",
                "Empty",
                "Full",
                "Inactive",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_cost_indicator
                "Init",
                "Check",
                "Empty",
                "Full",
                "Inactive",
            }),
            MakePlayMakerFsm(new[]
            {
                // Up and Down
                "Idle",
                "Down",
                "Up",
                "To Up",
            }),
            MakePlayMakerFsm(new[]
            {
                // Box Open YN
                "Box Down",
                "Init",
                "Box Up",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // flash
                "Idle",
                "Flash",
            }),
            MakePlayMakerFsm(new[]
            {
                // Fader
                "Init",
                "Up",
                "Down",
            }),
            MakePlayMakerFsm(new[]
            {
                // Break
                "Idle",
                "Play",
            }),
            MakePlayMakerFsm(new[]
            {
                // Load Animation
                "Init",
                "pause",
                "Appear Normal",
                "Cracked?",
                "Appear Cracked",
                "First Pause",
                "Pause Frame",
                "Normal",
                "Cracked",
                "Set Anims",
                "Check",
                "GG Anims",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Vignette Control
                "Init",
                "Down",
                "Up",
                "Pulsing",
            }),
            MakePlayMakerFsm(new[]
            {
                // Cursor Movement
                "Init",
                "Idle",
                "Move",
                "Quick Move",
                "Inactive",
                "Cursor Activate",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // UI Control
                "Init",
                "Crossroads",
                "City",
                "Town",
                "Mines",
                "Resting Grounds",
                "Cliffs",
                "Greenpath",
                "Fungus",
                "Deepnest",
                "Waterways",
                "Fog Canyon",
                "Pane Reset",
                "Inactive",
                "Activate",
                "GP Up",
                "GP Down",
                "GP Right",
                "CR Left",
                "CR Up",
                "CR Right",
                "CR Down",
                "T Down",
                "T Right",
                "Move Pane L",
                "Arrow L",
                "GP Left",
                "To Map",
                "Move Pane R",
                "Arrow R",
                "To Map 2",
                "T Left",
                "Cl Right",
                "Cl Left",
                "Cl Down",
                "Mi Right",
                "Mi Left",
                "Mi Down",
                "RG Up",
                "RG Right",
                "RG Left",
                "RG Down",
                "FG Up",
                "FG Left",
                "FG Down",
                "FW Up",
                "FW Left",
                "FW Down",
                "D Left",
                "D Up",
                "FW Right",
                "FG Right",
                "D Right",
                "C Up",
                "C Left",
                "C Down",
                "C Right",
                "Wat Up",
                "Wat Left",
                "Wat Right",
                "Royal Gardens",
                "QG Up",
                "QG Left",
                "QG Down",
                "QG Right",
                "Wat Down",
                "Ancient Basin",
                "Ab Up",
                "Ab Left",
                "Ab Right",
                "Outskirts",
                "Out Up",
                "Out Right",
                "Out Left",
                "Out Down",
                "Hive",
                "Hive Down",
                "Pos Check",
                "Pos 1",
                "Pos 2",
                "Pos 3",
                "Map Zoom",
                "To Zoom 1",
                "To Zoom 2",
                "To Zoom 3",
                "To Zoom 4",
                "To Zoom 5",
                "To Zoom 6",
                "To Zoom 7",
                "To Zoom 8",
                "To Zoom 9",
                "To Zoom 10",
                "To Zoom 11",
                "To Zoom 12",
                "To Zoom 13",
                "To Zoom 14",
                "Zoomed In",
                "Zoom Out",
                "Reset",
                "Map Up",
                "Map Off",
                "To Zoom 15",
                "Inventory Cancel",
                "Have Markers?",
                "Marker Select Menu",
                "Marker Inv Cancel",
                "Marker Cancel",
                "Inert",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Control
                "Init",
                "Out",
                "Activate",
                "Idle",
                "Update",
                "Anim",
                "Deactivate",
                "Sprite Off",
                "Pos Y",
                "Achievement?",
            }),
            MakePlayMakerFsm(new[]
            {
                // Slide Out
                "Init",
                "Idle",
                "Go Out",
                "Come In",
                "Out",
                "In",
                "Go Out Instant",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Activate Children
                "Activate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Arrow Anim
                "Idle",
                "Up",
                "Down",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // vessel_orb
                "Init",
                "Not Obtained",
                "Down Check",
                "Down To Empty",
                "Up Check",
                "Up To Quarter",
                "Down To Quarter",
                "Down To Half",
                "Up To Half",
                "Down To 3Quarter",
                "Up To 3Quarter",
                "Down To Full",
                "Up To Full",
                "Flash?",
                "Appear?",
                "Load Anim?",
                "Load Anim",
                "Init Anim",
                "Empty",
                "Pause",
                "Bound",
                "Setup",
                "Obtained",
                "Not obtained",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_unequip_shift
                "Idle",
                "Shift?",
                "Init",
                "Shift",
                "Notch Shift",
                "Sprite Next Off",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_cost_indicator
                "Init",
                "Check",
                "Empty",
                "Full",
                "Inactive",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Fader
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // Dialogue Page Control
                "Init",
                "Idle",
                "Page End",
                "Show Next Page",
                "Conversation End",
                "End Conversation",
                "Text Speedup",
                "Instant Display",
                "Stop or Arrow?",
                "Stop",
                "Arrow",
                "Stop Pause",
                "SFX",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_show_if_collected
                "Check",
                "Got",
                "Not",
                "Equipped",
                "Glass HP",
                "Glass Geo",
                "Glass Attack",
                "Royal Charm",
                "R Queen",
                "R King",
                "R Final",
                "R Shade",
                "Pause",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Pause",
                "Check",
                "Destroy",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Downed",
                "Upped",
                "Up Instant",
                "Get Prev Colour",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Pause",
                "Check",
                "Destroy",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Pause",
                "Check",
                "Destroy",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Position
                "Check",
                "Abyss",
                "Abyss Deep",
                "Greenpath",
                "City",
                "Cliffs",
                "Colosseum",
                "Crossroads",
                "Deepnest",
                "Fog Canyon",
                "Hive",
                "Waterways",
                "Town",
                "Fungus",
                "Mines",
                "Outskirts",
                "Resting Grounds",
                "Royal Gardens",
                "Tram Lower",
                "Tram Upper",
                "Nowhere",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // deactivate
                "Pause",
                "Check",
                "Deactivate",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Selection Colour
                "Unselected",
                "Selected",
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_unequip_shift
                "Idle",
                "Shift?",
                "Init",
                "Shift",
                "Notch Shift",
                "Sprite Next Off",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_unequip_shift
                "Idle",
                "Shift?",
                "Init",
                "Shift",
                "Notch Shift",
                "Sprite Next Off",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_unequip_shift
                "Idle",
                "Shift?",
                "Init",
                "Shift",
                "Notch Shift",
                "Sprite Next Off",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_unequip_shift
                "Idle",
                "Shift?",
                "Init",
                "Shift",
                "Notch Shift",
                "Sprite Next Off",
            }),
            MakePlayMakerFsm(new[]
            {
                // charm_unequip_shift
                "Idle",
                "Shift?",
                "Init",
                "Shift",
                "Notch Shift",
                "Sprite Next Off",
            }),
            MakePlayMakerFsm(new[]
            {
                // Control
                "Init",
                "Up",
                "Down",
                "State 1",
            }),
            MakePlayMakerFsm(new[]
            {
                // FSM
                "Init",
                "Up",
                "Down",
                "Delay",
                "Sprite Off?",
                "Upped",
                "Up Instant",
                "Pulse Down",
                "Down Instant",
                "Stopped",
                "Fade Up Instant",
                "Downed",
            }),
            MakePlayMakerFsm(new[]
            {
                // Display
                "Idle",
                "Down",
                "Init",
                "Attack",
                "Down Pause",
                "Down Wait",
                "First Jump",
                "Interact",
                "Focus",
                "To Focus",
                "Look Down Mawlek",
                "Fireball",
                "Dash",
                "Superdash",
                "Dreamnail",
                "Japanese?",
                "Fireball JA",
            }),
            MakePlayMakerFsm(new[]
            {
                // Map FSM State
                "Idle",
            }),
            MakePlayMakerFsm(new[]
            {
                // Globalise
                "Init",
            }),
            MakePlayMakerFsm(new[]
            {
                // Initial Shade Dreamgate Position
                "Pause",
                "Position",
            }),
            MakePlayMakerFsm(new[]
            {
                // Prompt Control
                "Init",
                "Go Up",
                "Up",
                "Go Down",
                "Select Text",
                "Change Label",
                "Down",
                "Pause",
            }),
        };
    }
}
