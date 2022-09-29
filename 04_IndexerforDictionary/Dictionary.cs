namespace _04_IndexerforDictionary
{
    public class Dictionary
    {
        public Words[] Arr = new Words[3];
        public Dictionary()
        {
            //Arr = new Words[]
            //{
            //    new Words("red", "Karmir"),
            //        new Words("green", "Kanach"),
            //        new Words("blue", "Kapuyn"),
            //};
        }

        public string this[string source]
        {
            get
            {
                Words obj = null;
                foreach (var word in Arr)
                {
                    if (word.Source == source)
                    {
                        obj = word;
                        break;
                    }
                }

                //return !string.IsNullOrEmpty(obj.Translation) ? obj?.Translation : "-non found-";
                return obj?.Translation;
            }
            set
            {
                foreach (var word in Arr)
                {
                    if (word.Source == source)
                    {
                        word.Source = value;
                        break;
                    }
                }
            }
        }

        private bool IsValid(string source)
        {
            foreach (var word in Arr)
            {
                if (word.Source == source)
                    return true;
            }
            return false;
        }
    }
}
