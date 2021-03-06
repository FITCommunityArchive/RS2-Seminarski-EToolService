﻿// <auto-generated />
using System;
using EToolService.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace eToolService.WebAPI.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EToolService.WebAPI.Database.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Administrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnName("AccountID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnName("AccountID")
                        .HasColumnType("int");

                    b.Property<bool?>("Active")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Active")
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("AreaId")
                        .HasColumnName("AreaID")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("AreaId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<DateTime>("ContractSigned")
                        .HasColumnType("datetime");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("Salary")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.EmployeeMachine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnName("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("MachineId")
                        .HasColumnName("MachineID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("MachineId");

                    b.ToTable("EmployeeMachine");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.EmployeeRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdministratorId")
                        .HasColumnName("AdministratorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnName("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("Phase")
                        .HasColumnType("int");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeRequest");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MachineDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Machine");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdministratorId")
                        .HasColumnName("AdministratorID")
                        .HasColumnType("int");

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Diameter")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("Hardness")
                        .HasColumnType("int");

                    b.Property<decimal?>("Length")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("MaterialTypeId")
                        .HasColumnName("MaterialTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Quality")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal?>("Thickness")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<decimal?>("Width")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.HasIndex("MaterialTypeId");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.MaterialType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("MaterialType");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("CustomerId")
                        .HasColumnName("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("ImageLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.ProductOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnName("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnName("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOrder");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnName("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool?>("Responsed")
                        .HasColumnType("bit");

                    b.Property<string>("ServiceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("ToolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("Urgent")
                        .HasColumnType("bit");

                    b.Property<bool?>("Viewed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.ServiceResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdministratorId")
                        .HasColumnName("AdministratorID")
                        .HasColumnType("int");

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FinishDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("ServiceId")
                        .HasColumnName("ServiceID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServiceResponse");
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Administrator", b =>
                {
                    b.HasOne("EToolService.WebAPI.Database.Account", "Account")
                        .WithMany("Administrator")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("fk_administrator_account")
                        .IsRequired();
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Customer", b =>
                {
                    b.HasOne("EToolService.WebAPI.Database.Account", "Account")
                        .WithMany("Customer")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("fk_customer_account")
                        .IsRequired();

                    b.HasOne("EToolService.WebAPI.Database.Area", "Area")
                        .WithMany("Customer")
                        .HasForeignKey("AreaId")
                        .HasConstraintName("fk_customer_area")
                        .IsRequired();
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.EmployeeMachine", b =>
                {
                    b.HasOne("EToolService.WebAPI.Database.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("fk_employeemachine_employee")
                        .IsRequired();

                    b.HasOne("EToolService.WebAPI.Database.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .HasConstraintName("fk_employeemachine_machine")
                        .IsRequired();
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.EmployeeRequest", b =>
                {
                    b.HasOne("EToolService.WebAPI.Database.Administrator", "Administrator")
                        .WithMany("EmployeeRequest")
                        .HasForeignKey("AdministratorId")
                        .HasConstraintName("fk_employee_request_administrator")
                        .IsRequired();

                    b.HasOne("EToolService.WebAPI.Database.Employee", "Employee")
                        .WithMany("EmployeeRequest")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("fk_employee_request_employee")
                        .IsRequired();
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Material", b =>
                {
                    b.HasOne("EToolService.WebAPI.Database.Administrator", "Administrator")
                        .WithMany("Material")
                        .HasForeignKey("AdministratorId")
                        .HasConstraintName("fk_material_administrator")
                        .IsRequired();

                    b.HasOne("EToolService.WebAPI.Database.MaterialType", "MaterialType")
                        .WithMany("Material")
                        .HasForeignKey("MaterialTypeId")
                        .HasConstraintName("fk_material_materialtype")
                        .IsRequired();
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Order", b =>
                {
                    b.HasOne("EToolService.WebAPI.Database.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("fk_order_customer")
                        .IsRequired();
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.ProductOrder", b =>
                {
                    b.HasOne("EToolService.WebAPI.Database.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .HasConstraintName("fk_productorder_order")
                        .IsRequired();

                    b.HasOne("EToolService.WebAPI.Database.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_productorder_product")
                        .IsRequired();
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.Service", b =>
                {
                    b.HasOne("EToolService.WebAPI.Database.Customer", "Customer")
                        .WithMany("Service")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("fk_service_customer")
                        .IsRequired();
                });

            modelBuilder.Entity("EToolService.WebAPI.Database.ServiceResponse", b =>
                {
                    b.HasOne("EToolService.WebAPI.Database.Administrator", "Administrator")
                        .WithMany()
                        .HasForeignKey("AdministratorId")
                        .HasConstraintName("fk_serviceresponse_administrator")
                        .IsRequired();

                    b.HasOne("EToolService.WebAPI.Database.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("fk_serviceresponse_service")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
