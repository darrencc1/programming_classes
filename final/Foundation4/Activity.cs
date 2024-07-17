using System;
// virtual methods for getting distance, speed, pace. 
// get Summarry method to produce a string of summary information (available to all classes)
// Track Date and Length of Activity in minutes (Base)
public abstract class Activity
{
    private DateTime date;
    private int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public DateTime Date { get => date; }
    public int Minutes { get => minutes; }
// I Originally had the Get as int, I couldnt figure out why it wasnt workign, gp said double, I understand that I should have probably used float and an easy fix,
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    // Chat gpt helped me fix this and get this get Summary correct. 
    {
        return $"{Date:dd MMM yyyy} {this.GetType().Name} ({Minutes} min) - " +
               $"Distance: {GetDistance():0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min per mile";
    }
}
