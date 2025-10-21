using System.ComponentModel.DataAnnotations;

//Gabriel Afonso dos Santos - CB3026167
namespace InventoryManagement.Models
    {
        public class Product
        {
            public int Id { get; set; }

            [Required(ErrorMessage = "O nome é obrigatório")]
            public string Name { get; set; }

            [StringLength(200)]
            public string Description { get; set; }

            [Range(0.01, 999999, ErrorMessage = "O preço deve ser maior que zero")]
            public decimal Price { get; set; }

            [Range(0, int.MaxValue, ErrorMessage = "A quantidade não pode ser negativa")]
            public int StockQuantity { get; set; }
        }
    }
