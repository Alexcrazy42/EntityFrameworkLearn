using EntityFrameworkLearn.Data;
using EntityFrameworkLearn.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;

var db = new UserContext();

////// SELECT
//var users = db.Users
//    .Where(u => u.UserId >= 17).ToList()
//    .Where(u => u.UserNickname[0] == 'a');
//foreach (var u in users)
//{

//    Console.WriteLine($"{u.UserId} : {u.UserNickname}");
//}


//// SELECT DISTINCT
//var usersNames = db.Users
//    .Where(u => u.UserId > 17)
//    .Select(u => u.UserNickname)
//    .Distinct().ToList();
//foreach (var userName in usersNames)
//{
//    Console.WriteLine($"{userName}");
//}

//// SELECT MULTIPLY COLUMNS WITH 'OR' OPERATION ('AND')
//var users = db.Users
//    .Where(u => (u.UserId > 17 || u.UserNickname == "alex"))
//    .Select(u => new { u.UserId, u.UserNickname })
//    .ToList();
//foreach (var user in users)
//{
//    Console.WriteLine($"{user.UserId} {user.UserNickname}");
//}

//// SUBSTRING
//var users = db.Users
//    .Select(u => u.UserNickname.Substring(0, u.UserNickname.Length))
//    .ToList();

//// ORDER BY
//var users = db.Users
//    .OrderByDescending(u => u.UserId)
//    .ToList();

//// GROUP BY
//var users = db.Users
//    .GroupBy(user => user.UserNickname)
//    .Select(user => new { count = user.Count(), name = user.Key}).ToList();


//// BETWEEN
//var users = db.Users
//    .Where(u => (u.UserId >= 22 && u.UserId < 24))
//    .ToList();

//// IN 
//var users = db.Users.
//    Where(u => new int[] { 1, 23, 4 }.Contains(u.UserId))
//    .ToList();



//// INSERT
//db.Users.AddRange(
//    new User { UserNickname = "alexcrazy42" },
//    new User { UserNickname = "alexcrazy43" }
//);
//db.SaveChanges();



//// UPDATE
//var user = db.Users.Where(u => u.UserId == 20).Single();

//if (user != null)
//{
//    user.UserNickname = "Привет";
//    db.SaveChanges();

//}
//else
//{
//    Console.WriteLine("Такого пользователя нет");
//}

//// DELETE
//var usersToDelete = db.Users.ToList();
//db.Users.RemoveRange(usersToDelete);
//db.SaveChanges();
