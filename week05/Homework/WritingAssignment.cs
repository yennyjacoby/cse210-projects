using System;

public class WritingAssignment:Assignment
{
    private string _title;

    //CONSTRUCTOR- THE ORDER MATERS
    public WritingAssignment (string studentName, string topic, string title):base(studentName, topic)
    {
    _title= title;
    }
    
    //Method
    public string GetWritingInformation()
    {
        string studentName= GetStudentName();
        return $"{_title} by {studentName}";
    }
}