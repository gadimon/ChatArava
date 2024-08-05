using ChatArava.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace ChatArava.DAL
{
    public class DataLayer : DbContext
    {
        public DataLayer(string ConnectionString) : base(GetOptions(ConnectionString))
        {
            Database.EnsureCreated();

            //Seed();
        }
        private void Seed()
        {
            if (!Users.Any())
            {
                User user = new User { NickName = "gadi", FollName = "Gadi Monsonego", Password = "1234", ConfirmPassWord = "1234" };
                user.MessegeList = new List<Messege>();
                user.MessegeList = CreateDefaultMessegeList(user);
                Users.Add(user);
                SaveChanges();
            }


        }
        private List<Messege> CreateDefaultMessegeList(User user)
        {
            List<Messege> messegeList = new List<Messege>();
            Messege messege = new Messege { Text = "hello world", Sender = user.NickName, SendingTime = DateTime.Now };


            messegeList.Add(messege);
            Messeges.Add(messege);
            return messegeList;
        }











        public DbSet<User> Users { get; set; }
        public DbSet<Messege> Messeges { get; set; }


        private static DbContextOptions GetOptions(string ConnectionString)
        {
            return SqlServerDbContextOptionsExtensions
                .UseSqlServer(new DbContextOptionsBuilder(), ConnectionString)
                .Options;
        }
    }
}





