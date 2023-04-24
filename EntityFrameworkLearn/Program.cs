using EntityFrameworkLearn.Data;
using EntityFrameworkLearn.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;

var db = new UserContext();

// SELECT
var users = db.Users
    .Where(u => u.UserId >= 17).ToList()
    .Where(u => u.UserNickname[0] == 'a');
foreach (var u in users)
{
    Console.WriteLine($"{u.UserId} : {u.UserNickname}");
}


// SELECT DISTINCT
var usersNames = db.Users
    .Where(u => u.UserId > 17)
    .Select(u => u.UserNickname)
    .Distinct().ToList();
foreach (var userName in usersNames)
{
    Console.WriteLine($"{userName}");
}

//// INSERT
//db.Users.AddRange(
//    new User { UserNickname = "alexcrazy42" },
//    new User { UserNickname = "alexcrazy43" }
//);
//db.SaveChanges();



// UPDATE
var user = db.Users.Where(u => u.UserId == 20).Single();

if (user != null)
{
    user.UserNickname = "Привет";
    db.SaveChanges();

}
else
{
    Console.WriteLine("Такого пользователя нет");
}

// DELETE
var usersToDelete = db.Users.ToList();
db.Users.RemoveRange(usersToDelete);
db.SaveChanges();
