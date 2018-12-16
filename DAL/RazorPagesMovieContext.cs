﻿using System;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.DAL
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
