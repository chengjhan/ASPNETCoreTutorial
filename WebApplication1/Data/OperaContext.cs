using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class OperaContext : DbContext
    {

        public OperaContext(DbContextOptions<OperaContext> options) : base(options)
        {
        }

        public DbSet<Opera> Operas { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Opera>().HasData(
                new Opera
                {
                    OperaID = 1,
                    Title = "Cosi Fan Tutte",
                    Year = 1790,
                    Composer = "Wolfgang Amadeus Mozart",
                },
                new Opera
                {
                    OperaID = 2,
                    Title = "Rigoletto",
                    Year = 1851,
                    Composer = "Giuseppe Verdi",
                },
                new Opera
                {
                    OperaID = 3,
                    Title = "Nixon in China",
                    Year = 1987,
                    Composer = "John Adams"
                },
                new Opera
                {
                    OperaID = 4,
                    Title = "Wozzeck",
                    Year = 1922,
                    Composer = "Alban Berg"
                },
                new Opera
                {
                    OperaID = 5,
                    Title = "Cosi Fan Tutte",
                    Year = 1790,
                    Composer = "Wolfgang Amadeus Mozart",
                },
                new Opera
                {
                    OperaID = 6,
                    Title = "Rigoletto",
                    Year = 1851,
                    Composer = "Giuseppe Verdi",
                },
                new Opera
                {
                    OperaID = 7,
                    Title = "Nixon in China",
                    Year = 1987,
                    Composer = "John Adams"
                },
                new Opera
                {
                    OperaID = 8,
                    Title = "Wozzeck",
                    Year = 1922,
                    Composer = "Alban Berg"
                },
                new Opera
                {
                    OperaID = 9,
                    Title = "Cosi Fan Tutte",
                    Year = 1790,
                    Composer = "Wolfgang Amadeus Mozart",
                },
                new Opera
                {
                    OperaID = 10,
                    Title = "Rigoletto",
                    Year = 1851,
                    Composer = "Giuseppe Verdi",
                },
                new Opera
                {
                    OperaID = 11,
                    Title = "Nixon in China",
                    Year = 1987,
                    Composer = "John Adams"
                },
                new Opera
                {
                    OperaID = 12,
                    Title = "Wozzeck",
                    Year = 1922,
                    Composer = "Alban Berg"
                },
                new Opera
                {
                    OperaID = 13,
                    Title = "Cosi Fan Tutte",
                    Year = 1790,
                    Composer = "Wolfgang Amadeus Mozart",
                },
                new Opera
                {
                    OperaID = 14,
                    Title = "Rigoletto",
                    Year = 1851,
                    Composer = "Giuseppe Verdi",
                },
                new Opera
                {
                    OperaID = 15,
                    Title = "Nixon in China",
                    Year = 1987,
                    Composer = "John Adams"
                },
                new Opera
                {
                    OperaID = 16,
                    Title = "Wozzeck",
                    Year = 1922,
                    Composer = "Alban Berg"
                },
                new Opera
                {
                    OperaID = 17,
                    Title = "Cosi Fan Tutte",
                    Year = 1790,
                    Composer = "Wolfgang Amadeus Mozart",
                },
                new Opera
                {
                    OperaID = 18,
                    Title = "Rigoletto",
                    Year = 1851,
                    Composer = "Giuseppe Verdi",
                },
                new Opera
                {
                    OperaID = 19,
                    Title = "Nixon in China",
                    Year = 1987,
                    Composer = "John Adams"
                },
                new Opera
                {
                    OperaID = 20,
                    Title = "Wozzeck",
                    Year = 1922,
                    Composer = "Alban Berg"
                },
                new Opera
                {
                    OperaID = 21,
                    Title = "Cosi Fan Tutte",
                    Year = 1790,
                    Composer = "Wolfgang Amadeus Mozart",
                },
                new Opera
                {
                    OperaID = 22,
                    Title = "Rigoletto",
                    Year = 1851,
                    Composer = "Giuseppe Verdi",
                },
                new Opera
                {
                    OperaID = 23,
                    Title = "Nixon in China",
                    Year = 1987,
                    Composer = "John Adams"
                },
                new Opera
                {
                    OperaID = 24,
                    Title = "Wozzeck",
                    Year = 1922,
                    Composer = "Alban Berg"
                },
                new Opera
                {
                    OperaID = 25,
                    Title = "Cosi Fan Tutte",
                    Year = 1790,
                    Composer = "Wolfgang Amadeus Mozart",
                },
                new Opera
                {
                    OperaID = 26,
                    Title = "Rigoletto",
                    Year = 1851,
                    Composer = "Giuseppe Verdi",
                },
                new Opera
                {
                    OperaID = 27,
                    Title = "Nixon in China",
                    Year = 1987,
                    Composer = "John Adams"
                },
                new Opera
                {
                    OperaID = 28,
                    Title = "Wozzeck",
                    Year = 1922,
                    Composer = "Alban Berg"
                }
            );
            modelBuilder.Entity<Comment>().HasData(
                new Comment
                { 
                    CommentId = 1,
                    UserName = "user1",
                    UserComment = "comment1",
                    LastModified = DateTime.Now,
                    OperaID = 1
                },
                new Comment
                {
                    CommentId = 2,
                    UserName = "user2",
                    UserComment = "comment2",
                    LastModified = DateTime.Now,
                    OperaID = 1
                },
                new Comment
                {
                    CommentId = 3,
                    UserName = "user3",
                    UserComment = "comment3",
                    LastModified = DateTime.Now,
                    OperaID = 2
                },
                new Comment
                {
                    CommentId = 4,
                    UserName = "user4",
                    UserComment = "comment4",
                    LastModified = DateTime.Now,
                    OperaID = 2
                }
            );
        }

    }

}
