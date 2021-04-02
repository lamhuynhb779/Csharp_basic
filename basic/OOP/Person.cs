namespace OOP
{
    public class Person
    {
        // Field
        private string name;

        // Property
        public string Name
        {
            get { return name;} // get method
            set { name = value;} // set method
        }

        public string Birthday
        {
            get; set;
        }
    }
}