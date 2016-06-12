namespace AkademiaCzaliczenie
{
    enum OperationSign
    {
        Dodawanie = 1,
        Odejmowanie = 2,
        Mnożenie = 3,
        Dzielenie = 4,
    }
    struct DataToSave
    {
        public float A;
        public float B;
        public float result;
        public string operation;
    }
}