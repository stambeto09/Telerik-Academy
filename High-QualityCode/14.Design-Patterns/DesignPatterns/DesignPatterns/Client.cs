namespace DesignPatterns
{
    using System;
    class Client
    {
        static void Main()
        {
            Console.WriteLine("Shallow Copy Sample\n");

            AuthorForShallowCopy o = new AuthorForShallowCopy()
            {
                Name = "Sukesh Marla",
                TwitterAccount = "https://twitter.com/SukeshMarla",
                Website = "http://www.sukesh-marla.com",
                HomeAddress = new Address()
                {
                    City = "Mumbai",
                    State = "Maharastra"
                }
            };
            Console.WriteLine("Original Copy");
            Console.WriteLine(o);


            AuthorForShallowCopy clonedObject = (AuthorForShallowCopy)o.Clone();
            Console.WriteLine("\nCloned Copy");
            Console.WriteLine(clonedObject);

            Console.WriteLine("\nMake Changes to clone copy address");

            clonedObject.Name = "Mr.Changer";
            clonedObject.TwitterAccount = "https://twitter.com/MrChanger";
            clonedObject.Website = "https://MrChanger.com";
            clonedObject.HomeAddress.State = "Karnataka";
            clonedObject.HomeAddress.City = "Manglore";

            Console.WriteLine("\nCloned Copy");
            Console.WriteLine(clonedObject);

            Console.WriteLine("\nOriginal Copy");
            Console.WriteLine(o);
        }
    }
}
