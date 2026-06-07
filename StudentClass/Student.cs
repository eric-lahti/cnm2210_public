using System.Runtime.CompilerServices;

class Student
{
    private string studentMajor;
    private int score1 = 0;
    private int score2 = 0;
    private int score3 = 0;
    private string studentFirstName;
    private string studentLastName;
    private string studentNumber;
    public string FavoriteBook;

    public string myotherFirstName{get;set;}

    public string firstName
    {
        get
        {
            return "'Crazy' " + studentFirstName;
        }
        set
        {
            studentFirstName = value;
        }
    }

    public string lastName
    {
        get{return "Von" + studentLastName;}
        set{studentLastName = value + " The one and only";}
    }

    public string major
    {
        set
        {
            Console.WriteLine("Looking up major " + value);

        }
        get {return studentMajor; }
    }

    public string ID
    {
        get {return studentNumber;}
    }

    public void Score(int scoreNum, int scoreVal)
    {
        switch (scoreNum)
        {
            case 1:
                score1 = scoreVal;
                break;
            case 2:
                score2 = scoreVal;
                break;
            case 3:
                score3 = scoreVal;
                break;
            default:
                break;
        }
    }

    public string GetScores()
    {
        return score1.ToString() + ", " + score2.ToString() + ", " + score3.ToString();
    }

    public Student(string major, string studentID)
    {
        studentMajor = major;
        studentNumber = studentID;
    }

    public void DropClass()
    {
        string DropDate = DateTime.Now.ToString();
        DoDropClass(DropDate, studentNumber);
        Console.Write(studentFirstName + " " + studentLastName + " Class dropped");
    }

    void DoDropClass(string dropDate, string studentNumber)
    {
        //Does actual class dropping
    }
}