
namespace Domain {

    public class OrderInitialized : State {
        public override void Handle(Context ctx) {
            ctx.State = new OrderInProgress();
        }
    }
}