namespace Models
{
    public class Employee:object
    {
        public Employee():base()
        {

        }
        public string Name { get; set; }

        public string JobTitle { get; set; }
        public string Resume { get; set; }
    }
}
