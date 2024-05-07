using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

public class Job{
    string _company;
    public string _jobTitle;
    int _startYear;
    int _endYear;

    public Job(string _company, string _jobTitle, int _startYear, int _endYear){
        this._company = _company;
        this._jobTitle = _jobTitle;
        this._startYear = _startYear;
        this._endYear = _endYear;

    }

    public void Display(){
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}