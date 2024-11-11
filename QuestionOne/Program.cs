// See https://aka.ms/new-console-template for more information
using QuestionOne;

Console.WriteLine("Hello, World!");

List<Student> student = new List<Student>();

var studentData = student.Where(s => s.GPA > 3);
var highestGpaStudent = student.OrderByDescending(s => s.GPA).FirstOrDefault();
var sortStudent = student.OrderBy( s=> s.Age);

