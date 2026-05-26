Student student = new Student("CIST", "1234");
student.firstName = "Eric";
student.lastName = "Lahti";
student.Score(1, 100);
student.Score(2, 98);
student.Score(3, 100);
Console.WriteLine(student.firstName + " " + student.lastName);
Console.WriteLine(student.major + " " + student.ID);
Console.WriteLine("Scores: " + student.GetScores());
