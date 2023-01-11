using System.ComponentModel.DataAnnotations;

namespace MinimalApi.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Id cant be blank")]
        [Range(0, int.MaxValue, ErrorMessage =("Id should be between 0 to max value of int"))]
        public int Id { get; set; }
        [Required]
        public string? ProductName { get; set; }

        public override string ToString()
        {
            return $"Product ID: {Id}, Product Name: {ProductName}";
        }
    }
}
