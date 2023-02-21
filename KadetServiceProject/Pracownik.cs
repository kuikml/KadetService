using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace KadetServiceProject
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "KadetServiceProject.ContractType".
    [DataContract]
    [Table("Pracownicy")]
    public class Pracownik
    {
        [DataMember] public int Id { get; set; }
        [DataMember] public string Imie { get; set; }
        [DataMember] public string Nazwisko { get; set; }
        [DataMember] public string Numer { get; set; }
        [DataMember] public string Email { get; set; }
        [DataMember] public string Pesel { get; set; }
        public string Haslo { get; set; }
    }
}
