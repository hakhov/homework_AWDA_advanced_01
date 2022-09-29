namespace _03_Indexer
{
    internal class User
    {
        private string _id;
        private string _name;
        private string _email;

        public string this[string index]
        {
            get
            {
                switch (index)
                {
                    case "id":
                        return _id;
                    case "name":
                        return _name;
                    case "email":
                        return _email;
                    default: return "-Non result-";
                }
            }
            set
            {
                switch (index)
                {
                    case "id":
                        _id = value;
                        break;
                    case "name":
                        _name = value;
                        break;
                    case "email":
                        _email = value;
                        break;
                }
            }
        }
    }
}
