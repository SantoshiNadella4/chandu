namespace GCS
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GCS_Entity_Model : DbContext
    {
        public GCS_Entity_Model()
            : base("name=GCS_Entity_Model")
        {
        }

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Mail_queries> Mail_queries { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<Query> Queries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .Property(e => e.regno)
                .HasPrecision(5, 0);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.DocName)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.specialization)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.phone)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.pwd)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.timings)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.FullName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.E_mail)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.PhoneNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => e.P_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.Doctor)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.P_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.P_User)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.P_Phone)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Mail_queries>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Mail_queries>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Prescription>()
                .Property(e => e.Doctor)
                .IsUnicode(false);

            modelBuilder.Entity<Prescription>()
                .Property(e => e.P_User)
                .IsUnicode(false);

            modelBuilder.Entity<Prescription>()
                .Property(e => e.Age)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Prescription>()
                .Property(e => e.Ailment)
                .IsUnicode(false);

            modelBuilder.Entity<Prescription>()
                .Property(e => e.Medication)
                .IsUnicode(false);

            modelBuilder.Entity<Query>()
                .Property(e => e.Key1)
                .IsUnicode(false);

            modelBuilder.Entity<Query>()
                .Property(e => e.Key2)
                .IsUnicode(false);

            modelBuilder.Entity<Query>()
                .Property(e => e.Key3)
                .IsUnicode(false);

            modelBuilder.Entity<Query>()
                .Property(e => e.doc)
                .IsUnicode(false);
        }
    }
}
