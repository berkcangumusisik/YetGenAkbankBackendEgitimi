using Week6.Context;
using Week6.Entities;
using Week6.Enums;

JobPost jobPost1 = new()
{
    Title = "Software Developer",
    Company = "Microsoft",
    Description = "Develop software",
    WorkMode = WorkMode.Remote,
    CreatedOn = DateTime.UtcNow

};
JobHunterDbContext dbContext = new();
var state1 = dbContext.Entry(jobPost1).State;
dbContext.JobPosts.Add(jobPost1);
var state2 = dbContext.Entry(jobPost1).State;
dbContext.SaveChanges();
var state3 = dbContext.Entry(jobPost1).State;
jobPost1.Title = "Software Developer 2";
var state4 = dbContext.Entry(jobPost1).State;
dbContext.SaveChanges();
var state5 = dbContext.Entry(jobPost1).State;
dbContext.JobPosts.Remove(jobPost1);
var state6 = dbContext.Entry(jobPost1).State;
dbContext.SaveChanges();
var state7 = dbContext.Entry(jobPost1).State;
Console.WriteLine("State 1: " + state1);
Console.WriteLine("State 2: " + state2);
Console.WriteLine("State 3: " + state3);
Console.WriteLine("State 4: " + state4);
Console.WriteLine("State 5: " + state5);
Console.WriteLine("State 6: " + state6);
Console.WriteLine("State 7: " + state7);


JobPost jobPost2 = dbContext.JobPosts.Where(x=>x.Id == Guid.Parse("ab447a4d-639c-48b8-b2c1-5375052a44a7")).FirstOrDefault();

var state8 = dbContext.Entry(jobPost2).State;
dbContext.SaveChanges();

// Interception : Bir işlemi başlatmadan önce veya sonra, bir işlem sırasında veya bir işlem tamamlandıktan sonra kodu çalıştırmak için kullanılır.


JobPost jobPost3 = dbContext.JobPosts.FirstOrDefault();
jobPost3.Description = "Software Developer 3";
dbContext.SaveChanges();

var query1 = dbContext.JobPosts.Where(x => x.Title.Contains("Software"));
var result1 = query1.ToList();

var query2 = dbContext.JobPosts.ToList().Where(x => x.Title.Contains("Software"));

