using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    public class AccountMachine
    {
        public enum State
        {
            Start, Login, Registration,
            PembeliRegistration, TenantRegistration, KasirRegistration,
            PembeliLogin, TenantLogin, KasirLogin,
            PembeliScreen, TenantScreen, KasirScreen,
            End
        };
        public enum Trigger { SelectPembeli, SelectTenant, SelectKasir, RegisButton, LoginButton, Submit, Cancel };

        class transition
        {
            public State prevState;
            public State nextState;
            public Trigger trigger;

            public transition(State prevState, State nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }

        transition[] transitions =
        {
            // Bagian Start
            new transition(State.Start, State.Registration, Trigger.RegisButton),
            new transition(State.Start, State.Login, Trigger.LoginButton),
            new transition(State.Start, State.End, Trigger.Cancel),

            // Bagian Registration
            new transition(State.Registration, State.PembeliRegistration, Trigger.SelectPembeli),
            new transition(State.Registration, State.TenantRegistration, Trigger.SelectTenant),
            new transition(State.Registration, State.KasirRegistration, Trigger.SelectKasir),
            new transition(State.Registration, State.Start, Trigger.Cancel),

            new transition(State.PembeliRegistration, State.Start, Trigger.Submit),
            new transition(State.PembeliRegistration, State.Registration, Trigger.Cancel),

            new transition(State.TenantRegistration, State.Start, Trigger.Submit),
            new transition(State.TenantRegistration, State.Registration, Trigger.Cancel),

            new transition(State.KasirRegistration, State.Start, Trigger.Submit),
            new transition(State.KasirRegistration, State.Registration, Trigger.Cancel),

            // Bagian Login
            new transition(State.Login, State.PembeliLogin, Trigger.SelectPembeli),
            new transition(State.Login, State.TenantLogin, Trigger.SelectTenant),
            new transition(State.Login, State.KasirLogin, Trigger.SelectKasir),
            new transition(State.Login, State.Start, Trigger.Cancel),

            new transition(State.PembeliLogin, State.PembeliScreen, Trigger.Submit),
            new transition(State.PembeliLogin, State.Login, Trigger.Cancel),

            new transition(State.TenantLogin, State.TenantScreen, Trigger.Submit),
            new transition(State.TenantLogin, State.Login, Trigger.Cancel),

            new transition(State.KasirLogin, State.KasirScreen, Trigger.Submit),
            new transition(State.KasirLogin, State.Login, Trigger.Cancel),

            // Bagian MainScreen
            new transition(State.PembeliScreen, State.Start, Trigger.Cancel),
            new transition(State.TenantScreen, State.Start, Trigger.Cancel),
            new transition(State.KasirScreen, State.Start, Trigger.Cancel)
        };

        public State currentState;

        public State getNextState(State prevState, Trigger trigger)
        {
            State nextState = prevState;

            for (int i = 0; i < transitions.Length; i++)
            {
                if (transitions[i].prevState == prevState && transitions[i].trigger == trigger)
                {
                    nextState = transitions[i].nextState;
                }
            }
            return nextState;
        }

        public void activeTrigger(Trigger trigger)
        {
            State nextState = getNextState(currentState, trigger);
            currentState = nextState;
        }
    }
}
