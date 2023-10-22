namespace ClassLibrary1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public static string GetPersonInfo(Person person)
        {
            return $"Name: {person.Name}, Age: {person.Age}, Address: {person.Address}";
        }
    }
}
