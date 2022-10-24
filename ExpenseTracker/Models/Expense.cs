using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        [Key]
        public int ExpensesId { get; set; }
        public string ExpensesName { get; set; }
        public DateTime DateOfExpense { get; set; }
        public decimal ExpenseAmount { get; set; }
        [ForeignKey("ExpenseCategory")]
        public int ExpenseCategoryId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
        //[NotMapped]
        //public string CategoryName { get; set; }
    }
}
