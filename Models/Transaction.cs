using System.ComponentModel.DataAnnotations;

namespace FinanceTracker.Models
{
    public enum TransactionType
    {
        Income,
        Expense
    }

    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Amount { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        [Required]
        public TransactionType Type { get; set; }
    }
}