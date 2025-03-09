using System;
using System.Collections.Generic;

namespace tpmodul4_103022300121
{
    class DoorMachine
    {
        public enum DoorState { TERKUNCI, TERBUKA };
        public enum Trigger { KUNCI_PINTU, BUKA_PINTU };

        class Transition
        {
            public DoorState PrevState { get; }
            public DoorState NextState { get; }
            public Trigger Trigger { get; }

            public Transition(DoorState prevState, DoorState nextState, Trigger trigger)
            {
                PrevState = prevState;
                NextState = nextState;
                Trigger = trigger;
            }
        }

        private DoorState currentState;
        private List<Transition> transitions;

        public DoorMachine()
        {
            currentState = DoorState.TERKUNCI;
            transitions = new List<Transition>
            {
                new Transition(DoorState.TERKUNCI, DoorState.TERBUKA, Trigger.BUKA_PINTU),
                new Transition(DoorState.TERBUKA, DoorState.TERKUNCI, Trigger.KUNCI_PINTU),
                new Transition(DoorState.TERKUNCI, DoorState.TERKUNCI, Trigger.KUNCI_PINTU),
                new Transition(DoorState.TERBUKA, DoorState.TERBUKA, Trigger.BUKA_PINTU)
            };
        }
        private DoorState GetNextState(DoorState prevState, Trigger trigger)
        {
            foreach (var transition in transitions)
            {
                if (transition.PrevState == prevState && transition.Trigger == trigger)
                {
                    return transition.NextState;
                }
            }
            return prevState;
        }
        public void ActivateTrigger(Trigger trigger)
        {
            DoorState nextState = GetNextState(currentState, trigger);
            currentState = nextState;
            Console.WriteLine($"Pintu sekarang {currentState}");
        }

        public DoorState GetCurrentState()
        {
            return currentState;
        }
    }
}
