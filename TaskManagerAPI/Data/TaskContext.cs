﻿using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions options) : base(options)
        {
        }
       public DbSet<TaskItem> Tasks { get; set; } 
       public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(a => a.Address)
                .WithOne(b => b.User)
                .HasForeignKey<Address>(c => c.UserId);

            modelBuilder.Entity<User>()
                .HasMany(o => o.Tasks)
                .WithOne(p=>p.Assignee)
                .HasForeignKey(o=>o.AssigneeId);

            base.OnModelCreating(modelBuilder);
        }
    }
   
}
