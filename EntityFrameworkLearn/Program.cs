using EntityFrameworkLearn.Data;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;
using System.Diagnostics;
using System.Linq;

var db = new UserContext();



////// SELECT
//var users = db.Users
//    .Where(u => u.UserId >= 17)
//    .ToList();


//var usersByLinq = from user in db.Users
//                  where user.UserId >= 17
//                  select user;




//// SELECT DISTINCT
//var usersNames = db.Users
//    .Where(u => u.UserId > 17)
//    .Select(u => u.UserNickname)
//    .Distinct().ToList();


//var userNamesByLinq = (from user in db.Users
//                      where user.UserId > 17
//                      select user.UserNickname).Distinct();


//// SELECT MULTIPLY COLUMNS WITH 'OR' OPERATION ('AND')
//var users = db.Users
//    .Where(u => (u.UserId > 17 || u.UserNickname == "alex"))
//    .Select(u => new { u.UserId, u.UserNickname })
//    .ToList();

//var userByLinq = from user in db.Users
//                 where user.UserId >= 17 || user.UserNickname == "alex"
//                 select new { user.UserId, user.UserNickname };


//// SUBSTRING
//var users = db.Users
//    .Select(u => u.UserNickname.Substring(0, u.UserNickname.Length))
//    .ToList();

//var usersByLinq = from user in db.Users
//                  select user.UserNickname.Substring(0, user.UserNickname.Length);


//// ORDER BY
//var users = db.Users
//    .OrderByDescending(u => u.UserId)
//    .ToList();

//var usersByLinq = from user in db.Users 
//                  orderby user.UserId descending 
//                  select user;



//// GROUP BY
//var users = db.Users
//    .GroupBy(user => user.UserNickname)
//    .Select(user => new { count = user.Count(), name = user.Key }).ToList();

//var userByLinq = from user in db.Users
//                 group user by user.UserNickname;



//// BETWEEN
//var users = db.Users
//    .Where(u => (u.UserId >= 22 && u.UserId < 24))
//    .ToList();

//var usersByLinq = from user in db.Users
//                  where user.UserId >= 22 && user.UserId < 24
//                  select user;



//// IN 
//var users = db.Users.
//    Where(u => new int[] { 1, 23, 4 }.Contains(u.UserId))
//    .ToList();

//var userByLinq = from u in db.Users
//                 where new int[] { 1, 23, 4 }.Contains(u.UserId)
//                 select u;


//// NEATED SUBQUERIES ???
//var users = db.Users
//    .Where(u1 =>
//    (db.Users.Where(u => u.UserId < 25).Select(u => u.UserNickname).ToList().Contains(u1.UserNickname)))
//    .ToList();

//var usersByLinq = from u in db.Users
//                where (from u1 in db.Users
//                        where u1.UserId < 25
//                        select u1.UserNickname).Contains(u.Contains())



//// INNER JOIN 
//var usersCars = db.Users
//    .Join(db.Cars,
//    user => user.UserId,
//    car => car.UserId,
//    (user, car) => new { User = user, Car = car })
//    .ToList();

//var userCarsByLinq = from user in db.Users
//                     join car in db.Cars on user.UserId equals car.UserId
//                     select new { User = user, Car = car };

// LEFT JOIN 



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
