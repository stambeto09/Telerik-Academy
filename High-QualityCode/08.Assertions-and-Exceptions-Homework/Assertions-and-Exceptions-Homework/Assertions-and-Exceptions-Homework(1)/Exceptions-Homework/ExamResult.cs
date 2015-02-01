using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentException("The grades can't be negative number.", "grade");
        }
        if (minGrade < 0)
        {
            throw new ArgumentException("The minimal grade cann't be negative number.", "minGrade");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("The minimal grade can't be greater than maximal.", "maxGrad over minGrade");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentNullException("The comment field can't be empty.", "comments");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
