﻿using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLibrary.Configuration
{
    public class ReminderConfiguration : IEntityTypeConfiguration<ReminderModel>
    {
        public void Configure(EntityTypeBuilder<ReminderModel> builder)
        {
            builder.ToTable("Reminders");
            builder.HasKey(e => e.ReminderId);
            builder.Property(e => e.Title)
                .IsUnicode(false);
            builder.Property(e => e.Notes)
                .IsUnicode(false);
        }
    }
}