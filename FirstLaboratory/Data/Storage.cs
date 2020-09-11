using CustomGenerics.Structure;
using FirstLaboratory.Models;

namespace FirstLaboratory.Data
{
    public class Storage {
        //Instance element
        private static Storage _instance = null;

        //Method for instance
        public static Storage Instance {
            get {
                if (_instance == null) _instance = new Storage();
                return _instance;
            }
        }

        public RangeTree<Movie> rangeTree;
    }
}
