﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TweetBook.Domain;

namespace TweetBook.Data
{
    public class DataContext :IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PostTag>()
                .HasKey(postTag => new { postTag.PostId, postTag.TagName });
        }
    }
}
