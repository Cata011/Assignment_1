using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace Assignment_1.Data
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = SeeAllUsers();

            if (!users.Any())
            {
                users.Add(new User
                {
                    Password = "123456",
                    UserId = -1,
                    Role = "Admin",
                    SecurityLevel = 2,
                    UserName = "Cata"
                });
                WriteFile();
            }
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }

        public void CreateNewUser(string username, string password, string role, int securityLevel)
        {  
           
            User newUser = new User
            {
                UserName = username,
                Password = password,
                Role = role,
                SecurityLevel = securityLevel
            };
            foreach (var VARIABLE in users)
            {
                if (newUser.UserName.Equals(VARIABLE.UserName)) throw new Exception("User already exists");
            }
            

            int numberOfUsers = users.Count;
                newUser.UserId = numberOfUsers++;
                users.Add(newUser);
                WriteFile();
            
        }

        void WriteFile()
        {
            File.WriteAllText("Users.json", JsonSerializer.Serialize(users));
        }

        public List<User> SeeAllUsers()
        {
            return JsonSerializer.Deserialize<List<User>>(File.ReadAllText("Users.json"));
        }
    }
}