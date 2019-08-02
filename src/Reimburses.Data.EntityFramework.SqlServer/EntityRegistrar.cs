using Reimburses.Data.Entities;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reimburses.Data.EntityFramework.SqlServer
{
    public class EntityRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<RequestOvertime>(etb => {
                etb.ToTable("RequestOvertimes");
                etb.HasKey(e => e.Id);

                etb.Property(p => p.OvertimeType);
                etb.Property(p => p.ProjectName).HasMaxLength(128).IsRequired();
                etb.Property(p => p.RequestTo).HasMaxLength(64);
                               
                etb.Property(e => e.Id).ValueGeneratedOnAdd();              
            });

            modelbuilder.Entity<RequestMedical>(etb => {
                etb.ToTable("RequestMedicals");
                etb.HasKey(e => e.Id);

                etb.Property(p => p.MedicationType).HasMaxLength(64).IsRequired();
  
                etb.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelbuilder.Entity<RequestBusinesstrip>(etb => {
                etb.ToTable("RequestBusinesstrips");
                etb.HasKey(e => e.Id);

                etb.Property(p => p.From).HasMaxLength(128).IsRequired();
                etb.Property(p => p.To).HasMaxLength(128).IsRequired();
            
                etb.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelbuilder.Entity<QuickLeave>(etb => {
                etb.ToTable("QuickLeaves");
                etb.HasKey(e => e.Id);

                etb.Property(p => p.Purpose).HasMaxLength(64).IsRequired();
                etb.Property(p => p.ProjectName).HasMaxLength(128).IsRequired();
                etb.Property(p => p.RequestTo).HasMaxLength(64).IsRequired();
                etb.Property(p => p.Note).HasMaxLength(128).IsRequired();

                etb.Property(e => e.Id).ValueGeneratedOnAdd();
            });

        }
    }
}