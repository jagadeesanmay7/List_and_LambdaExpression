using List_and_LambdaExpression;

Console.WriteLine("Welcome to Certified in CyberSecurity!");
Console.WriteLine("Press 1 for Print Passed Students list\nPress 2 for Print Failed Students list");
Start:
int UserInput = int.Parse(Console.ReadLine());

List<StudentMarkListModel> Student = new List<StudentMarkListModel>();
List<StudentMarkListModel> PassedStudent = new List<StudentMarkListModel>();
List<StudentMarkListModel> FailedStudent = new List<StudentMarkListModel>();

Student.Add(new StudentMarkListModel()
{
    Candidate = "Jeeva",
    CandidateClientID = 1177046,
    RegistrationID = 432262377,
    AppointmentTime = DateTime.Now,
    TestCenterLocation = "PEARSON PROFESSIONAL CENTERS-CHENNAI",
    Marks = 900
});
Student.Add(new StudentMarkListModel()
{
    Candidate = "Gokula Krishnanan",
    CandidateClientID = 1177047,
    RegistrationID = 432262378,
    AppointmentTime = DateTime.Now,
    TestCenterLocation = "PEARSON PROFESSIONAL CENTERS-CHENNAI",
    Marks = 850
});
Student.Add(new StudentMarkListModel()
{
    Candidate = "Jagadeesan",
    CandidateClientID = 1177048,
    RegistrationID = 432262379,
    AppointmentTime = DateTime.Now,
    TestCenterLocation = "PEARSON PROFESSIONAL CENTERS-CHENNAI",
    Marks = 850
});
Student.Add(new StudentMarkListModel()
{
    Candidate = "Anto",
    CandidateClientID = 1177049,
    RegistrationID = 432262380,
    AppointmentTime = DateTime.Now,
    TestCenterLocation = "PEARSON PROFESSIONAL CENTERS-CHENNAI",
    Marks = 600
});
Student.Add(new StudentMarkListModel()
{
    Candidate = "Ritu",
    CandidateClientID = 1177050,
    RegistrationID = 432262389,
    AppointmentTime = DateTime.Now,
    TestCenterLocation = "PEARSON PROFESSIONAL CENTERS-CHENNAI",
    Marks = 600
});

if (UserInput == 1)
{
    PassedStudent = Student.Where(p => p.Marks >= 700).ToList();
    PassedStudent.ForEach(n => Console.WriteLine($"Dear {n.Candidate}:\nThank you for sitting for the Certified in Cybersecurity (CC) examination, We are delightful to inform you that you have achieve a passing scaled score of 700.\n"));
}
else if (UserInput == 2)
{
    FailedStudent = Student.Where(x => x.Marks < 700).ToList();
    FailedStudent.ForEach(n => Console.WriteLine($"Dear {n.Candidate}:\nThank you for sitting for the Certified in Cybersecurity (CC) examination, We regreat to inform you that you have not achieve a passing scaled score of 700.\n"));
}
else
{
    Console.WriteLine("Invalid Input");
    goto Start;
}