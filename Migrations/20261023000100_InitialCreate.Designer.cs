using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using ProductsApi.Data;

namespace ProductsApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261023000100_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "8.0.22");
            modelBuilder.Entity("ProductsApi.Models.Product", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("INTEGER");
                b.Property<string>("Name").HasColumnType("TEXT");
                b.Property<decimal>("Price").HasColumnType("TEXT");
                b.HasKey("Id");
                b.ToTable("Products");
                b.HasData(
                    new { Id = 1, Name = "Notebook", Price = 500m },
                    new { Id = 2, Name = "Pen", Price = 150m }
                );
            });
        }
    }
}
