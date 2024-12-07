using Land.DAL.Models;
using Land.PL.Data.Migrations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Emit;

namespace Land.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //seed Data
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Car>()
           .HasOne(c => c.Citizen)  // علاقة "One-to-Many" من Car إلى Citizen
           .WithMany(citizen => citizen.Cars)  // كل Citizen يمكنه امتلاك العديد من السيارات
           .HasForeignKey(c => c.CitizenId);

            builder.Entity<TrafficViolation>()
            .HasOne(c => c.Citizen)  // الشكوى تكون مرتبطة بمواطن واحد
            .WithMany(c => c.TrafficViolations)  // كل مواطن يمكنه تقديم العديد من الشكاوى
            .HasForeignKey(c => c.CitizenId);  // المفتاح الأجنبي الذي يشير إلى المواطن


            
            builder.Entity<PolicemanDecision>()
                .HasOne(d => d.Policeman)  // القرار مرتبط بشرطي واحد فقط
                .WithMany(o => o.Decisions)  // الشرطي يمكنه تقديم عدة قرارات
                .HasForeignKey(d => d.PolicemanDecisionId);  // المفتاح الأجنبي المرتبط بالشرطي



            // تحديد العلاقة One-to-One بين Violation و Decision
            builder.Entity<TrafficViolation>()
                .HasOne(v => v.Decision)  // كل مخالفة مرتبطة بقرار واحد فقط
                .WithOne(d => d.TrafficViolation)  // وكل قرار مرتبط بمخالفة واحدة فقط
                .HasForeignKey<TrafficViolation>(v => v.DecisionId);  // المفتاح الأجنبي في المخالفة

            builder.Entity<PolicemanDecision>()
                .HasOne(d => d.TrafficViolation)  // كل قرار مرتبط بمخالفة واحدة فقط
                .WithOne(v => v.Decision)  // وكل مخالفة مرتبطة بقرار واحد فقط
                .HasForeignKey<PolicemanDecision>(d => d.Violationid);  // المفتاح الأجنبي في القرار

            // تحديد العلاقة One-to-Many بين Court و JudicialDecision
            builder.Entity<CourtDecisions>()
                .HasOne(jd => jd.Court)  // القرار مرتبط بمحكمة واحدة فقط
                .WithMany(c => c.CourtDecisions)  // المحكمة يمكنها إصدار عدة قرارات
                .HasForeignKey(jd => jd.Courtid);  // المفتاح الأجنبي المرتبط بالمحكمة


            builder.Entity<PolicemanDecision>()
           .HasOne(pd => pd.CourtDecision)  // كل قرار شرطي مرتبط بقرار محكمة واحد فقط
           .WithOne(cd => cd.PoliceDecision)  // وكل قرار محكمة مرتبط بقرار شرطي واحد فقط
           .HasForeignKey<PolicemanDecision>(pd => pd.CourtDecisionId);  // المفتاح الأجنبي في قرار الشرطي

            builder.Entity<CourtDecisions>()
                .HasOne(cd => cd.PoliceDecision)  // كل قرار محكمة مرتبط بقرار شرطي واحد فقط
                .WithOne(pd => pd.CourtDecision)  // وكل قرار شرطي مرتبط بقرار محكمة واحد فقط
                .HasForeignKey<CourtDecisions>(cd => cd.PoliceDecisionId);  // المفتاح الأجنبي في قرار المحكمة

            builder.Entity<TrafficViolation>()
           .HasOne(vs => vs.CourtDecision)  // كل حالة مخالفة مرتبطة بقرار قاضي واحد فقط
           .WithOne(cd => cd.ViolationStatus)  // وكل قرار قاضي مرتبط بحالة مخالفة واحدة فقط
           .HasForeignKey<TrafficViolation>(vs => vs.CourtDecisionId);  // المفتاح الأجنبي في حالة المخالفة

            builder.Entity<CourtDecisions>()
                .HasOne(cd => cd.ViolationStatus)  // كل قرار قاضي مرتبط بحالة مخالفة واحدة فقط
                .WithOne(vs => vs.CourtDecision)  // وكل حالة مخالفة مرتبطة بقرار قاضي واحد فقط
                .HasForeignKey<CourtDecisions>(cd => cd.Violationid);  // المفتاح الأجنبي في قرار القاضي

            builder.Entity<Judge>()
            .HasMany(j => j.CourtDecisions)  // القاضي يمكن أن يحكم في العديد من المخالفات
            .WithOne(v => v.Judge)  // كل مخالفة تتعلق بقاضي واحد فقط
            .HasForeignKey(v => v.JudgeId);  // المفتاح الأجنبي في جدول المخالفات






            var roleAdminId = Guid.NewGuid().ToString();
            var rolePolicemanId = Guid.NewGuid().ToString();
            var roleCitizenId = Guid.NewGuid().ToString();
            var rolejudgedId = Guid.NewGuid().ToString();
            //بدي اضيف داتا اولية 
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = roleAdminId, Name ="Admin" , NormalizedName="ADMIN"},
                new IdentityRole { Id = roleCitizenId, Name = "Citizen", NormalizedName = "CITIZEN"},
                new IdentityRole { Id = rolePolicemanId, Name = "Policeman", NormalizedName = "POLICEMAN"},
                 new IdentityRole { Id = rolejudgedId, Name = "judged", NormalizedName = "JUDGED" }
                );

            //تشفير الباسوورد
            var hasher = new PasswordHasher<ApplicationUser>();

            var adminUser = new ApplicationUser {
                Id = Guid.NewGuid().ToString(),
                UserName="admin",
                NormalizedUserName= "ADMIN",
                Email= "admin@gmail.com",
                NormalizedEmail= "ADMIN@GMAIL.COM",
                EmailConfirmed=true,
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin@1212");


            var citizenUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "citizen",
                NormalizedUserName = "CITIZEN",
                Email = "citizen@gmail.com",
                NormalizedEmail = "CITIZEN@GMAIL.COM",
                EmailConfirmed = true,
            };
            citizenUser.PasswordHash = hasher.HashPassword(citizenUser, "Citizen@1212");


            var policemanUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "policeman",
                NormalizedUserName = "POLICEMAN",
                Email = "policeman@gmail.com",
                NormalizedEmail = "POLICEMAN@GMAIL.COM",
                EmailConfirmed = true,
            };
            policemanUser.PasswordHash = hasher.HashPassword(policemanUser, "Policeman@1212");


            var judgedUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "judged",
                NormalizedUserName = "JUDGED",
                Email = "judged@gmail.com",
                NormalizedEmail = "JUDGED@GMAIL.COM",
                EmailConfirmed = true,
            };
            judgedUser.PasswordHash = hasher.HashPassword(judgedUser, "Judged@1212");

           

            builder.Entity<ApplicationUser>().HasData(adminUser, citizenUser, policemanUser, judgedUser);//هيك ضفناهن 
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId= roleAdminId, UserId= adminUser.Id},
                new IdentityUserRole<string> { RoleId = rolePolicemanId, UserId = policemanUser.Id },
                new IdentityUserRole<string> { RoleId = roleCitizenId, UserId = citizenUser.Id },
                 new IdentityUserRole<string> { RoleId = rolejudgedId, UserId = judgedUser.Id }
                  
                );
        }
        
        public DbSet<Service> Services { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
    }
}
