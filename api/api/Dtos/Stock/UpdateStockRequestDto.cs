using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot exceed 10 characters.")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(20, ErrorMessage = "Company name cannot exceed 20 characters.")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(1, 10000000, ErrorMessage = "Price must be between 1 and 1,000,000.")]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Industry cannot exceed 50 characters.")]
        public string Industry { get; set; } = string.Empty;
        [Required]
        [Range(1, 5000000000, ErrorMessage = "Market cap must be between 1 and 5,000,000,000.")]
        public long MarketCap { get; set; }
    }
}
