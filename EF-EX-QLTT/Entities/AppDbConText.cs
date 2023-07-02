using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_QLTT.Entities
{
    public class AppDbConText : DbContext
    {
        public virtual DbSet<Lop> Lop { get; set; 
        }
        public virtual DbSet<HocVien> HocVien { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server = THUOCLE\\THUOCLE; Database = QuanLyTrungTam; " +
                $"Trusted_Connection = True; " +
                $"TrustServerCertificate=True");
        }
    }
}
