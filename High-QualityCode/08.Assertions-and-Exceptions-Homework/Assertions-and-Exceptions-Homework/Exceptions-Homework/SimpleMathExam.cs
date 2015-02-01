﻿using System;

public class SimpleMathExam : Exam
{
    private int problemsSolved;
    public int ProblemsSolved 
    {
        get
        {
            return this.problemsSolved;
        }
        private set
        {
            this.problemsSolved = value;    
        }
    }

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0)
        {
            throw new ArgumentException("The solved problems can't be negative number.", "problemsSolved");
        }
        else
        {
            this.ProblemsSolved = problemsSolved;
        }
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: nothing done.");
        }
        else if (ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Average result: nothing done.");
        }

        return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
    }
}
