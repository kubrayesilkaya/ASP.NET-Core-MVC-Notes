namespace HTML_Rendering.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public String FullName => $"{FirstName} {LastName.ToUpper()}";

        public int Age { get; set; } // = 0; -> //Default değeri 0. Belirtmesek de 0'dır.
    }
}
