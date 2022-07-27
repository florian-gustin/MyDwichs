

namespace Domain
{
    public class Cook
    {
        private Cook() {}

        private static Cook _instance;

        private static readonly object Lock = new object();

        public static Cook GetInstance()
        {
            if(_instance == null)
            {
                lock(Lock)
                {
                    if(_instance == null)
                    {
                        _instance = new Cook();
                    }
                }
            }
            return _instance;
        }
        
        private Ingredient _pain = new Ingredient("Pain", "1");
        private Ingredient _mayonnaise = new Ingredient("Mayonnaise", "10g");
        private Ingredient _salade = new Ingredient("Salade", "10g");
        private Ingredient _tomate = new Ingredient("Tomate", "0.5");
        private Ingredient _jambon = new Ingredient("Tranche de jambon", "1");
        private Ingredient _poulet = new Ingredient("Tranche de poulet", "1");
        private Ingredient _thon = new Ingredient("Thon", "50g");
        private Ingredient _beurre = new Ingredient("Beurre", "10g");
        private Ingredient _oeuf = new Ingredient("Oeuf", "1");

        public Ingredient Pain => _pain;
        public Ingredient Mayonnaise => _mayonnaise;
        public Ingredient Salade => _salade;
        public Ingredient Tomate => _tomate;
        public Ingredient Jambon => _jambon;
        public Ingredient Poulet => _poulet;
        public Ingredient Thon => _thon;
        public Ingredient Beurre => _beurre;
        public Ingredient Oeuf => _oeuf;
    }
}
