using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class DateOfBirth : MonoBehaviour {
    private DateTime currentDate = DateTime.UtcNow;
    private string choosenDate;
    public Dropdown yearSelect;
    public Dropdown monthSelect;
    public Dropdown daySelect;

    // Use this for initialization
    void Start () {
        int lastYear = currentDate.Year-100;
        int currentYear = currentDate.Year;
        yearSelect.options.Clear();
        daySelect.options.Clear();


        for (int year = currentYear; year > lastYear; year--)
        {
            yearSelect.options.Add(new Dropdown.OptionData() { text = year.ToString()});
            
        };

    }

    public void changeDay()
    {
        int intYear;
        
        if(Int32.TryParse(yearSelect.captionText.text, out intYear) && intYear!= 0 && monthSelect.value!= 0)
        {
            setDay(DateTime.DaysInMonth(intYear, monthSelect.value));
            daySelect.interactable = true;
        }

    }

    public void setDay(int count)
    {
        daySelect.options.Clear();
        for (int day = 1; day <= count; day++)
        {
            daySelect.options.Add(new Dropdown.OptionData() { text = day.ToString() });

        }
    }
}
