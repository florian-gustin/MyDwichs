
namespace Domain
{
    public abstract class State
    {
        public abstract void Handle(Context ctx);
    }
}