using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Command
    {
        public List<Sandwich> SandwichList { get; private set; } = new List<Sandwich>();
        public Context Context;

        public Command() {
            this.Context = new Context(new OrderInitialized());
        }

        public bool IsOrderCompleted() {
            return typeof(OrderCompleted).IsInstanceOfType(this.Context);
        }

        public void AwaitOrder() {
            if(this.Context.State.GetType().Name == nameof(OrderInitialized)) {
                this.Context.Next();
            }else {
                throw new Exception("Error taking order");
            }
        }

        public void CompleteOrder() {
            if(this.Context.State.GetType().Name == nameof(OrderInProgress)) {
                this.Context.Next();
            }else {
                throw new Exception("Error while completed order");
            }
        }

        public void AddSandwich(Sandwich sandwich)
        {
            if(this.Context.State.GetType().Name == nameof(OrderInProgress)) {
                this.SandwichList.Add(sandwich);
            }else {
                throw new Exception("Error adding sandwich");
            }
        }
    }
}
