using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace WarehouseProject2.Entities
{
    class EntityFW : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<OrderIn> OrderIns { get; set; }
        public DbSet<OrderOut> OrderOuts { get; set; }
        public DbSet<TransferOrderIn> TransferOrderIns { get; set; }
        public DbSet<TransferOrderOut> TransferOrderOuts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<MeasuringUnit> MeasuringUnits { get; set; }
        public DbSet<Product_MeasuringUnit> Product_MeasuringUnits { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Product_OrderIn> Product_OrderIns { get; set; }
        public DbSet<Product_OrderOut> Product_OrderOuts { get; set; }
        public DbSet<Product_Warehouse> Product_Warehouses { get; set; }
        public DbSet<Product_TransferOrderIn> Product_TransferOrderIns { get; set; }
        public DbSet<Product_TransferOrderOut> Product_TransferOrderOuts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=WarehouseProjectDB;Trusted_Connection=True;TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Primary Keys
            modelBuilder.Entity<Customer>().HasKey(c => c.C_ID);
            modelBuilder.Entity<Supplier>().HasKey(s => s.S_ID);
            modelBuilder.Entity<OrderIn>().HasKey(o => o.O_ID);
            modelBuilder.Entity<OrderOut>().HasKey(o => o.O_ID);
            modelBuilder.Entity<TransferOrderIn>().HasKey(o => o.O_ID);
            modelBuilder.Entity<TransferOrderOut>().HasKey(o => o.O_ID);
            modelBuilder.Entity<Product>().HasKey(p => p.P_ID);
            modelBuilder.Entity<Warehouse>().HasKey(w => w.W_ID);
            modelBuilder.Entity<Product_OrderIn>().HasKey(po => new { po.O_ID, po.P_ID });
            modelBuilder.Entity<Product_OrderOut>().HasKey(po => new { po.O_ID, po.P_ID });
            modelBuilder.Entity<Product_Warehouse>().HasKey(pw => new { pw.W_ID, pw.P_ID, pw.ExpiryDate });
            modelBuilder.Entity<Product_TransferOrderIn>().HasKey(pto => new { pto.O_ID, pto.P_ID });
            modelBuilder.Entity<Product_TransferOrderOut>().HasKey(pto => new { pto.O_ID, pto.P_ID });
            modelBuilder.Entity<MeasuringUnit>().HasKey(mu => mu.MU_ID);
            modelBuilder.Entity<Product_MeasuringUnit>().HasKey(pmu => new { pmu.P_ID, pmu.MU_ID });

            // Relationships

            // Customer -> OrderOut (One-to-Many)
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.OrderOuts)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.C_ID);

            // Supplier -> OrderIn (One-to-Many)
            modelBuilder.Entity<Supplier>()
                .HasMany(s => s.OrderIns)
                .WithOne(o => o.Supplier)
                .HasForeignKey(o => o.S_ID);

            // OrderIn -> Product_OrderIn (One-to-Many)
            modelBuilder.Entity<OrderIn>()
                .HasMany(o => o.OrderProducts)
                .WithOne(po => po.OrderIn)
                .HasForeignKey(po => po.O_ID);

            // OrderOut -> Product_OrderOut (One-to-Many)
            modelBuilder.Entity<OrderOut>()
                .HasMany(o => o.OrderProducts)
                .WithOne(po => po.OrderOut)
                .HasForeignKey(po => po.O_ID);

            // TransferOrderOut -> Product_TransferOrderOut (One-to-Many)
            modelBuilder.Entity<TransferOrderOut>()
                .HasMany(to => to.OrderProducts)
                .WithOne(pto => pto.TransferOrderOut)
                .HasForeignKey(pto => pto.O_ID);

            // TransferOrderIn -> Product_TransferOrderIn (One-to-Many)
            modelBuilder.Entity<TransferOrderIn>()
                .HasMany(to => to.OrderProducts)
                .WithOne(pto => pto.TransferOrderIn)
                .HasForeignKey(pto => pto.O_ID);

            // Warehouse -> Product_Warehouse (One-to-Many)
            modelBuilder.Entity<Warehouse>()
                .HasMany(w => w.Product_Warehouses)
                .WithOne(pw => pw.Warehouse)
                .HasForeignKey(pw => pw.W_ID);

            // Product -> Product_OrderIn (One-to-Many)
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Product_OrderIns)
                .WithOne(po => po.Product)
                .HasForeignKey(po => po.P_ID);

            // Product -> Product_OrderOut (One-to-Many)
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Product_OrderOuts)
                .WithOne(po => po.Product)
                .HasForeignKey(po => po.P_ID);

            // Product -> Product_Warehouse (One-to-Many)
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Product_Warehouses)
                .WithOne(pw => pw.Product)
                .HasForeignKey(pw => pw.P_ID);

            // Product -> Product_TransferOrderIn (One-to-Many)
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Product_TransferOrderIns)
                .WithOne(pto => pto.Product)
                .HasForeignKey(pto => pto.P_ID);

            // Product -> Product_TransferOrderOut (One-to-Many)
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Product_TransferOrderOuts)
                .WithOne(pto => pto.Product)
                .HasForeignKey(pto => pto.P_ID);

            // Warehouse -> OrderIn (One-to-Many)
            modelBuilder.Entity<Warehouse>()
                .HasMany(w => w.OrderIns)
                .WithOne(o => o.Warehouse)
                .HasForeignKey(o => o.W_ID);

            // Warehouse -> OrderOut (One-to-Many)
            modelBuilder.Entity<Warehouse>()
                .HasMany(w => w.OrderOuts)
                .WithOne(o => o.Warehouse)
                .HasForeignKey(o => o.W_ID);

            // Warehouse -> TransferOrderIn (One-to-Many)
            modelBuilder.Entity<Warehouse>()
                .HasMany(w => w.SourceTransferOrderIns)
                .WithOne(to => to.SourceWarehouse)
                .HasForeignKey(to => to.SourceWarehouse_ID)
                .OnDelete(DeleteBehavior.Cascade);
            // Warehouse -> TransferOrderIn (One-to-Many)
            modelBuilder.Entity<Warehouse>()
                .HasMany(w => w.TargetTransferOrderIns)
                .WithOne(to => to.TargetWarehouse)
                .HasForeignKey(to => to.TargetWarehouse_ID)
                .OnDelete(DeleteBehavior.NoAction);
            // Warehouse -> TransferOrderOut (One-to-Many)
            modelBuilder.Entity<Warehouse>()
                .HasMany(w => w.SourceTransferOrderOuts)
                .WithOne(to => to.SourceWarehouse)
                .HasForeignKey(to => to.SourceWarehouse_ID)
                .OnDelete(DeleteBehavior.Cascade);

            // Warehouse -> TransferOrderOut (One-to-Many)
            modelBuilder.Entity<Warehouse>()
                .HasMany(w => w.TargetTransferOrderOuts)
                .WithOne(to => to.TargetWarehouse)
                .HasForeignKey(to => to.TargetWarehouse_ID)
                .OnDelete(DeleteBehavior.NoAction);

            // MeasuringUnit -> Product_MeasuringUnit (One-to-Many)
            modelBuilder.Entity<MeasuringUnit>()
                .HasMany(mu => mu.Product_MeasuringUnits)
                .WithOne(pmu => pmu.MeasuringUnit)
                .HasForeignKey(pmu => pmu.MU_ID);
            // Product -> Product_MeasuringUnit (One-to-Many)

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Product_MeasuringUnits)
                .WithOne(pmu => pmu.Product)
                .HasForeignKey(pmu => pmu.P_ID);
        }
    }
}