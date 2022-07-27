
namespace Domain {

    public class OrderInProgress : State {
        public override void Handle(Context ctx) {
            ctx.State = new OrderCompleted();
        }
    }

}