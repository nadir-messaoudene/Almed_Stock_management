using AlmedFramework.DO;

namespace AlmedFramework
{
    public abstract class AbstractHelper
    {
        public abstract string GetLN(string stringIn);
        public abstract string GetNLot(string stringIn);
        public abstract string GetDLC(string stringIn);

        public abstract Items GetCode(string codeIn, string qte);

    }
}
