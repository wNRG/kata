using Microsoft.EntityFrameworkCore;

namespace kata.api.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<StatementOfAccount> StatementOfAccounts { get; set; }
        public DbSet<StatementItem> StatementItems { get; set; }
        public DbSet<BusinessSetting> BusinessSettings { get; set; }
        public DbSet<InvoiceSequence> InvoiceSequences { get; set; }
    }
}