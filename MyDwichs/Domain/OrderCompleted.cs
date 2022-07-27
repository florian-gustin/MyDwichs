
namespace Domain {

    public class OrderCompleted : State {
        public override void Handle(Context ctx) {
            ctx.State = new OrderInitialized();
        }
    }

}