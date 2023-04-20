using EntityFrameworkLearn.Data;
using EntityFrameworkLearn.Models;


var db = new UserContext();


db.Users.AddRange(
    new User { UserNickname = "alexcrazy42"}, 
    new User { UserNickname = "alexcrazy43" }
);
db.SaveChanges();

var user = db.Users.Where(u => u.UserId == 10).Single();

if (user != null)
{
    Console.WriteLine(user.UserNickname);
}
else
{
    Console.WriteLine("Такого пользователя нет");
}

var usersToDelete = db.Users.ToList();
db.Users.RemoveRange(usersToDelete);
db.SaveChanges();
