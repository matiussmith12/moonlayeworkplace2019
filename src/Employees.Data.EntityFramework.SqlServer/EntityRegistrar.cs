using Employees.Data.Entities;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Data.EntityFramework.SqlServer
{
    public class EntityRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Employee>(etb => {
                etb.ToTable("Employees");
                etb.HasKey(e => e.Id);
                etb.Property(e => e.Id).ValueGeneratedOnAdd();

                etb.Property(p => p.FirstName).HasMaxLength(64).IsRequired();
                etb.Property(e => e.Username).HasMaxLength(128).IsRequired();
                etb.Property(e => e.Password).HasMaxLength(64).IsRequired();
                etb.Property(e => e.FullName).HasMaxLength(128).IsRequired();
                etb.Property(e => e.LastName).HasMaxLength(64).IsRequired();
                etb.Property(e => e.InitialName).HasMaxLength(3).IsRequired();
                etb.Property(e => e.MaritalStatus).IsRequired();

                //Personal Data
                etb.Property(e => e.KTPAddress).HasMaxLength(225).IsRequired();
                etb.Property(e => e.CurrentAddress).HasMaxLength(225).IsRequired();
                etb.Property(e => e.Gender).IsRequired();
                etb.Property(e => e.PhoneNumber).HasMaxLength(25).IsRequired();
                etb.Property(e => e.TelephoneNumber).HasMaxLength(25).IsRequired();
                etb.Property(e => e.EmergencyContactName).HasMaxLength(128).IsRequired();
                etb.Property(e => e.EmergencyContactNumber).HasMaxLength(64).IsRequired();
                etb.Property(e => e.EmergencyContactRelationship).HasMaxLength(128).IsRequired();
                etb.Property(e => e.BirthLocation).HasMaxLength(225).IsRequired();
                etb.Property(e => e.PersonalEmail).HasMaxLength(128).IsRequired();
                etb.Property(e => e.OfficeEmail).HasMaxLength(64).IsRequired();

                //Worker Status 
                etb.Property(e => e.StatusWorker).IsRequired();
                etb.Property(e => e.LineManager).HasMaxLength(64).IsRequired();
                etb.Property(e => e.ReasonLeaving).HasMaxLength(225);
                etb.Property(e => e.SpecialNotes).HasMaxLength(225);
                etb.Property(e => e.NoSurat).HasMaxLength(128).IsRequired();
                etb.Property(e => e.ImageUrl);

                etb.HasQueryFilter(m => m.IsDeleted == false);
            });

            modelbuilder.Entity<EmployeeRole>(etb =>
            {
                etb.ToTable("Roles");
                etb.HasKey(r => r.Id);
                etb.Property(r => r.Id).ValueGeneratedOnAdd();

                etb.Property(r => r.PositionTitle).HasMaxLength(128).IsRequired();

                etb.HasMany(e => e.Employees).WithOne(r => r.EmployeeRole).HasForeignKey(h => h.EmployeeRoleId);

                etb.HasQueryFilter(m => m.IsDeleted == false);

            });

            modelbuilder.Entity<Group>(etb =>
            {
                etb.ToTable("Groups");
                etb.HasKey(g => g.Id);
                etb.Property(g => g.Id).ValueGeneratedOnAdd();

                etb.Property(g => g.GroupName).HasMaxLength(128).IsRequired();

                etb.HasMany(r => r.EmployeeRoles).WithOne(g => g.Group).HasForeignKey(f => f.GroupId);

                etb.HasQueryFilter(m => m.IsDeleted == false);
            });

            modelbuilder.Entity<BankAccount>(etb =>
            {
                etb.ToTable("BankAccounts");
                etb.HasKey(b => b.Id);
                etb.Property(b => b.Id).ValueGeneratedOnAdd();

                etb.Property(b => b.AccountNumber).HasMaxLength(20).IsRequired();
                etb.Property(b => b.BankName).HasMaxLength(30).IsRequired();
                etb.Property(b => b.BranchName).HasMaxLength(128).IsRequired();
                etb.Property(b => b.ReceiverName).HasMaxLength(128).IsRequired();

                etb.HasQueryFilter(b => b.IsDeleted == false);
            });

            modelbuilder.Entity<Department>(etb =>
            {
                etb.ToTable("Departments");
                etb.HasKey(d => d.Id);
                etb.Property(d => d.Id).ValueGeneratedOnAdd();

                etb.Property(d => d.DepartmentName).HasMaxLength(128).IsRequired();

                etb.HasQueryFilter(b => b.IsDeleted == false);
            });

            modelbuilder.Entity<Education>(etb =>
            {
                etb.ToTable("Educations");
                etb.HasKey(e => e.Id);
                etb.Property(e => e.Id).ValueGeneratedOnAdd();

                etb.Property(e => e.LastEducation).HasMaxLength(64).IsRequired();

                etb.HasQueryFilter(b => b.IsDeleted == false);
            });

            modelbuilder.Entity<GradingTitle>(etb =>
            {
                etb.ToTable("GradingTitles");
                etb.HasKey(g => g.Id);
                etb.Property(g => g.Id).ValueGeneratedOnAdd();

                etb.Property(g => g.GradingName).HasMaxLength(128).IsRequired();

                etb.HasQueryFilter(b => b.IsDeleted == false);
            });

            modelbuilder.Entity<WorkPlacement>(etb =>
            {
                etb.ToTable("Placements");
                etb.HasKey(p => p.Id);
                etb.Property(p => p.Id).ValueGeneratedOnAdd();

                etb.Property(p => p.WorkLocation).HasMaxLength(225).IsRequired();
                etb.Property(p => p.OfficeAddress).HasMaxLength(225).IsRequired();

                etb.HasQueryFilter(b => b.IsDeleted == false);
            });

            modelbuilder.Entity<Religion>(etb =>
            {
                etb.ToTable("Religions");
                etb.HasKey(r => r.Id);
                etb.Property(r => r.Id).ValueGeneratedOnAdd();

                etb.Property(r => r.ReligionName).HasMaxLength(64).IsRequired();

                etb.HasQueryFilter(b => b.IsDeleted == false);
            });
        }
    }
}
