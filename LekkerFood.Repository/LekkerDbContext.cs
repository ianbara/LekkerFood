﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LekkerFood.Models;
using LekkerFood.Models.Interfaces;
using System.Threading;
using LekkerFood.Repository.Interfaces;

namespace LekkerFood.Repository
{

    public class LekkerDbContext : DbContext
    {

        public LekkerDbContext()
            : base("Name=LekkerDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<IngredientCategory> IngredientCategories { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }

        public DbSet<RecipeCategory> RecipeCategories { get; set; }

        public DbSet<Recipe> Recipe { get; set; }


        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity
                    && (x.State == System.Data.Entity.EntityState.Added || x.State == System.Data.Entity.EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == System.Data.Entity.EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }
    }

    //public class LekkerDbContext : DbContext, ILekkerDbContext
    //{

    //    public LekkerDbContext()
    //        : base("Name=LekkerDbContext")
    //  {
 
    //  }

    //    public DbSet<IngredientCategory> IngredientCategories { get; set; }
    //    public DbSet<MeasurementType> MeasurementTypes { get; set; }
    //    public DbSet<PreparationType> PreparationTypes { get; set; }
    //    public DbSet<Ingredient> Ingredients { get; set; }
    //    public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
    //    public DbSet<RecipeCategory> RecipeCategories { get; set; }
    //    public DbSet<Recipe> Recipes { get; set; }

    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        Database.SetInitializer(new MigrateDatabaseToLatestVersion<LekkerDbContext, LekkerFood.Repository.Migrations.Configuration>());

    //        modelBuilder.Configurations.Add(new IngredientCategoryEntityConfiguration());
    //        modelBuilder.Configurations.Add(new RecipeCategoryEntityConfiguration());
    //        modelBuilder.Configurations.Add(new MeasurementTypeEntityConfiguration());
    //        modelBuilder.Configurations.Add(new PreparationTypeEntityConfiguration());
    //        modelBuilder.Configurations.Add(new RecipeEntityConfiguration());

    //        base.OnModelCreating(modelBuilder);
    //    }


    //    public override int SaveChanges()
    //    {
    //        var modifiedEntries = ChangeTracker.Entries()
    //            .Where(x => x.Entity is IAuditableEntity
    //                && (x.State == System.Data.Entity.EntityState.Added || x.State == System.Data.Entity.EntityState.Modified));

    //        foreach (var entry in modifiedEntries)
    //        {
    //            IAuditableEntity entity = entry.Entity as IAuditableEntity;
    //            if (entity != null)
    //            {
    //                string identityName = Thread.CurrentPrincipal.Identity.Name;
    //                DateTime now = DateTime.UtcNow;

    //                if (entry.State == System.Data.Entity.EntityState.Added)
    //                {
    //                    entity.CreatedBy = identityName;
    //                    entity.CreatedDate = now;
    //                }
    //                else
    //                {
    //                    base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
    //                    base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
    //                }

    //                entity.UpdatedBy = identityName;
    //                entity.UpdatedDate = now;
    //            }
    //        }

    //        return base.SaveChanges();
    //    }
            
            
    //}
}