using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class ExpensesContext:DbContext
    {
        //public ExpensesContext()
        //{

        //}
        public ExpensesContext(DbContextOptions<ExpensesContext> options) : base(options)
        {
        }
        public DbSet<ExpenseCategory> ExpenseCategorys { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
