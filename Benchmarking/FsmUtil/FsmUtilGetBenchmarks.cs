using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using HutongGames.PlayMaker;
using CommunityToolkit.HighPerformance;

namespace Benchmarking.FsmUtil;

public class FsmUtilGetMethods : FsmUtilBenchmarkBase
{
    public static FsmState Fsm_Fsm_GetState(PlayMakerFSM fsm, string stateName)
    {
        return fsm.Fsm.GetState(stateName);
    }

    public static FsmState Fsm_FsmStates_First(PlayMakerFSM fsm, string stateName)
    {
        return fsm.FsmStates.First(state => state.Name == stateName);
    }

    public static FsmState Fsm_FsmStates_First_StringLength(PlayMakerFSM fsm, string stateName)
    {
        int stateNameLength = stateName.Length;
        return fsm.FsmStates.First(state => stateNameLength == state.Name.Length && state.Name == stateName);
    }

    public static FsmState Fsm_FsmStates_FirstOrDefault(PlayMakerFSM fsm, string stateName)
    {
        return fsm.FsmStates.FirstOrDefault(state => state.Name == stateName);
    }

    public static FsmState Fsm_FsmStates_FirstOrDefault_StringLength(PlayMakerFSM fsm, string stateName)
    {
        int stateNameLength = stateName.Length;
        return fsm.FsmStates.FirstOrDefault(state => stateNameLength == state.Name.Length && state.Name == stateName);
    }

    public static FsmState Array_Find_Fsm_FsmStates(PlayMakerFSM fsm, string stateName)
    {
        return Array.Find(fsm.FsmStates, state => state.Name == stateName);
    }

    public static FsmState Array_Find_Fsm_FsmStates_StringLength(PlayMakerFSM fsm, string stateName)
    {
        int stateNameLength = stateName.Length;
        return Array.Find(fsm.FsmStates, state => stateNameLength == state.Name.Length && state.Name == stateName);
    }

    public static FsmState For_Fsm_FsmStates(PlayMakerFSM fsm, string stateName)
    {
        FsmState[] fsmStates = fsm.FsmStates;
        int fsmStatesCount = fsmStates.Length;
        for (int i = 0; i < fsmStatesCount; i++)
        {
            if (fsmStates[i].Name == stateName)
            {
                return fsmStates[i];
            }
        }

        return null;
    }

    public static FsmState For_Fsm_FsmStates_StringLength(PlayMakerFSM fsm, string stateName)
    {
        FsmState[] fsmStates = fsm.FsmStates;
        int fsmStatesCount = fsmStates.Length;
        int stateNameLength = stateName.Length;
        for (int i = 0; i < fsmStatesCount; i++)
        {
            if (stateNameLength == fsmStates[i].Name.Length && fsmStates[i].Name == stateName)
            {
                return fsmStates[i];
            }
        }

        return null;
    }

    public static FsmState For_Fsm_FsmStates_StringLength_StateCache(PlayMakerFSM fsm, string stateName)
    {
        FsmState[] fsmStates = fsm.FsmStates;
        int fsmStatesCount = fsmStates.Length;
        int stateNameLength = stateName.Length;
        FsmState currentState;
        for (int i = 0; i < fsmStatesCount; i++)
        {
            currentState = fsmStates[i];
            if (stateNameLength == currentState.Name.Length && currentState.Name == stateName)
            {
                return currentState;
            }
        }

        return null;
    }

    public static FsmState For_Fsm_FsmStates_StringLength_StateCache_NameCache(PlayMakerFSM fsm, string stateName)
    {
        FsmState[] fsmStates = fsm.FsmStates;
        int fsmStatesCount = fsmStates.Length;
        int stateNameLength = stateName.Length;
        FsmState currentState;
        string currentStateName;
        for (int i = 0; i < fsmStatesCount; i++)
        {
            currentState = fsmStates[i];
            currentStateName = currentState.Name;
            if (stateNameLength == currentStateName.Length && currentStateName == stateName)
            {
                return currentState;
            }
        }

        return null;
    }

    public static FsmState For_Fsm_FsmStates_StringLength_StateCache_NameCache_NameLengthCache(PlayMakerFSM fsm, string stateName)
    {
        FsmState[] fsmStates = fsm.FsmStates;
        int fsmStatesCount = fsmStates.Length;
        int stateNameLength = stateName.Length;
        FsmState currentState;
        string currentStateName;
        int currentStateNameLength;
        for (int i = 0; i < fsmStatesCount; i++)
        {
            currentState = fsmStates[i];
            currentStateName = currentState.Name;
            currentStateNameLength = currentStateName.Length;
            if (stateNameLength == currentStateNameLength && currentStateName == stateName)
            {
                return currentState;
            }
        }

        return null;
    }

    public static unsafe FsmState For_Unsafe_Pointer_Fsm_FsmStates(PlayMakerFSM fsm, string stateName)
    {
        FsmState[] localFsmStates = fsm.FsmStates;
        void* arr = Unsafe.AsPointer(ref localFsmStates[0]);
        void* end = Unsafe.Add<FsmState>(arr, localFsmStates.Length);
        for (; arr != end; arr = Unsafe.Add<FsmState>(arr, 1))
        {
            if (stateName == Unsafe.AsRef<FsmState>(arr).Name)
            {
                return Unsafe.AsRef<FsmState>(arr);
            }
        }

        return null;
    }

    public static unsafe FsmState For_Unsafe_Pointer_Fsm_FsmStates_StringLength(PlayMakerFSM fsm, string stateName)
    {
        FsmState[] localFsmStates = fsm.FsmStates;
        int stateNameLength = stateName.Length;
        void* arr = Unsafe.AsPointer(ref localFsmStates[0]);
        void* end = Unsafe.Add<FsmState>(arr, localFsmStates.Length);
        for (; arr != end; arr = Unsafe.Add<FsmState>(arr, 1))
        {
            if (stateNameLength == Unsafe.AsRef<FsmState>(arr).Name.Length && stateName == Unsafe.AsRef<FsmState>(arr).Name)
            {
                return Unsafe.AsRef<FsmState>(arr);
            }
        }

        return null;
    }

    public static FsmState For_Fsm_FsmStates_HighPerformance(PlayMakerFSM fsm, string stateName)
    {
        FsmState[] fsmStates = fsm.FsmStates;
        int fsmStatesCount = fsmStates.Length;
        FsmState currentState;
        for (int i = 0; i < fsmStatesCount; i++)
        {
            currentState = fsmStates.DangerousGetReferenceAt(i);
            if (currentState.Name == stateName)
            {
                return currentState;
            }
        }

        return null;
    }

    public static FsmState For_Fsm_FsmStates_HighPerformance_StringLength(PlayMakerFSM fsm, string stateName)
    {
        FsmState[] fsmStates = fsm.FsmStates;
        int fsmStatesCount = fsmStates.Length;
        int stateNameLength = stateName.Length;
        FsmState currentState;
        for (int i = 0; i < fsmStatesCount; i++)
        {
            currentState = fsmStates.DangerousGetReferenceAt(i);
            if (stateNameLength == currentState.Name.Length && currentState.Name == stateName)
            {
                return currentState;
            }
        }

        return null;
    }

    public static FsmState For_Fsm_FsmStates_56_1_Modified(PlayMakerFSM fsm, string stateName)
    {
        FsmState[] states = fsm.FsmStates;
        int length = states.Length;
        unsafe
        {
            void* arr = Unsafe.AsPointer(ref states.DangerousGetReference()); // void* arr = Unsafe.AsPointer(ref MemoryMarshal.GetArrayDataReference(states));
            void* end = Unsafe.Add<FsmState>(arr, length);
            for (; arr != end; arr = Unsafe.Add<FsmState>(arr, 1))
            {
                if (string.Equals(Unsafe.AsRef<FsmState>(arr).Name, stateName))
                    return Unsafe.AsRef<FsmState>(arr);
            }
        }

        return null;
    }

    public static FsmState For_Fsm_FsmStates_56_1_Modified_StringLength(PlayMakerFSM fsm, string stateName)
    {
        FsmState[] states = fsm.FsmStates;
        int length = states.Length;
        int stateNameLength = stateName.Length;
        unsafe
        {
            Dictionary<int, int> test = new();
            bool exists;
            void* arr = Unsafe.AsPointer(ref states.DangerousGetReference()); // void* arr = Unsafe.AsPointer(ref MemoryMarshal.GetArrayDataReference(states));
            void* end = Unsafe.Add<FsmState>(arr, length);
            for (; arr != end; arr = Unsafe.Add<FsmState>(arr, 1))
            {
                if (stateNameLength == Unsafe.AsRef<FsmState>(arr).Name.Length && stateName == Unsafe.AsRef<FsmState>(arr).Name)
                    return Unsafe.AsRef<FsmState>(arr);
            }
        }

        return null;
    }

    public static FsmState For_Fsm_FsmStates_56_2_Modified(PlayMakerFSM fsm, string stateName)
    {
        FsmState[] states = fsm.FsmStates;
        int length = states.Length;
        ref FsmState st = ref states.DangerousGetReference(); // ref var st = ref MemoryMarshal.GetArrayDataReference(states);
        ref FsmState end = ref Unsafe.Add(ref st, length);
        for (; !Unsafe.AreSame(ref st, ref end); st = ref Unsafe.Add(ref st, 1))
        {
            if (st.Name == stateName)
                return st;
        }

        return null;
    }

    public static FsmState For_Fsm_FsmStates_56_2_Modified_StringLength(PlayMakerFSM fsm, string stateName)
    {
        FsmState[] states = fsm.FsmStates;
        int length = states.Length;
        int stateNameLength = stateName.Length;
        ref FsmState st = ref states.DangerousGetReference(); // ref var st = ref MemoryMarshal.GetArrayDataReference(states);
        ref FsmState end = ref Unsafe.Add(ref st, length);
        for (; !Unsafe.AreSame(ref st, ref end); st = ref Unsafe.Add(ref st, 1))
        {
            if (stateNameLength == st.Name.Length && stateName == st.Name)
                return st;
        }

        return null;
    }
}
