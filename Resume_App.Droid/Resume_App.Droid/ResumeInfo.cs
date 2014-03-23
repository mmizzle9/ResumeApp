using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Resume_App.Droid.DataModel;
using Android.Graphics.Drawables;

namespace Resume_App.Droid
{
    public static class ResumeInfo
    {
        public static List<School> Schools = new List<School>
        {
            new School
            {
                Name = "Western Kentucky University",
                Degree = "B.S. in Computer Science",
                Graduation = "Spring 2013",
                Image = Resource.Drawable.PlaceholderIcon,
            },
            new School
            {
                Name = "Gatton Academy of Math and Science",
                Degree = "H.S. Diploma",
                Graduation = "Spring 2009",
                Image = Resource.Drawable.PlaceholderIcon,
            }
        };

        public static List<Employer> Employers = new List<Employer>
        {
            new Employer
            {
                Name = "Hitcents",
                Title = "App Developer",
                DateWorked = "11/2012-Current",
                Location = "Bowling Green, KY",
                IconPath = Resource.Drawable.PlaceholderIcon,
            },
            new Employer
            {
                Name = "Shogun Bistro",
                Title = "Server",
                DateWorked = "2011 - 2012",
                Location = "Bowling Green, KY",
                IconPath = Resource.Drawable.PlaceholderIcon,
            },
            new Employer
            {
                Name = "Ray's Alignment",
                Title = "Mechanic",
                DateWorked = "Summer 2010 & 2012",
                Location = "Madisonville, KY",
                IconPath = Resource.Drawable.PlaceholderIcon,
            }
        };

        public static List<string> Experience = new List<string>
        {
            "C#",
            "Java",
            "Android",
            "iOS / WPF Application Development",
            "UI Design",
            "SQLite",
            "Linq",
            "Localization",
            "X(Cross)Platform Development",
            "Asynchronous Programming",
            "HTML",
            "Ruby",
            "Json",
            "Database Design",
            "Javascript",
            "RESTful Design",
        };

        public static List<string> Tools = new List<string>
        {
            "Visual Studio",
            "Eclipse",
            "XCode",
            "Xamarin Studio",
            "SQL Expert Professional",
            "Github",
            "SVN",
        };
    }
}
