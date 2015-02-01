namespace DesignPatterns
{
    public class AuthorForShallowCopy : ICloneable
    {
        public string Name { get; set; }

        public string TwitterAccount { get; set; }

        public string Website { get; set; }

        public Address HomeAddress { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
