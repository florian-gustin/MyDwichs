using System;

namespace Domain {

    public class Context {
        State _state;

        public Context(State state)
        {
            this.State = state;
        }

        public State State
        {
            get { return _state; }
            set {
                _state = value;
                Console.WriteLine("State: ", _state.GetType().Name);
            }
        }

        public void Next()
        {
            _state.Handle(this);
        }

    }

}