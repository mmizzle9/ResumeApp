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
                Image = Resource.Drawable.Wku,
            },
            new School
            {
                Name = "Gatton Academy of Math and Science",
                Degree = "H.S. Diploma",
                Graduation = "Spring 2009",
                Image = Resource.Drawable.GattonAcademy,
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
                IconPath = Resource.Drawable.Hitcents,
            },
            new Employer
            {
                Name = "Shogun Bistro",
                Title = "Server",
                DateWorked = "2011 - 2012",
                Location = "Bowling Green, KY",
                IconPath = Resource.Drawable.Shogun,
            },
            new Employer
            {
                Name = "Ray's Alignment",
                Title = "Mechanic",
                DateWorked = "Summer 2010 & 2012",
                Location = "Madisonville, KY",
                IconPath = Resource.Drawable.Tow,
            }
        };

        public static List<string> Experience = new List<string>
        {
            "C#",
            "Java",
            "Android",
            "iOS",
            "Windows Presentation Forms (WPF)",
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

        public static List<Project> Projects = new List<Project>
        {
            new Project
            {
                Name = "****",
                Description = "Developed windows application for local manufacturing facility",
                Icon = Resource.Drawable.Placeholder,
            },
            new Project
            {
                Name = "****",
                Description = "Developed cross platform money transfer application for developing markets",
                Icon = Resource.Drawable.Placeholder,
            },
            new Project
            {
                Name = "Cheer Social",
                Description = "Developed api and backend for social networking application with Facebook and Twitter integration",
                Icon = Resource.Drawable.CheerSocial,
            },
            new Project
            {
                Name = "Battlepillars",
                Description = "Built multiplayer gaming client using Google Play Services and integrated apis such as Facebook and Twitter",
                Icon = Resource.Drawable.Battlepillars,
            },
            new Project
            {
                Name = "Think Again",
                Description = "Built mobile game with native Android UI",
                Icon = Resource.Drawable.ThinkAgain,
            },
            new Project
            {
                Name = "Draw a Stickman Epic",
                Description = "Testing, localization, and bug fixes for the popular mobile and PC game",
                Icon = Resource.Drawable.Epic,
            },
            new Project
            {
                Name = "Draw a Stickman Episodes",
                Description = "Developed native mobile port of the viral webpage drawastickman.com/",
                Icon = Resource.Drawable.Episodes,
            },
            new Project
            {
                Name = "Xamarin Field Service",
                Description = "Testing and bug fixes to Xamarin�s showcase app for monodroid and monotouch software",
                Icon = Resource.Drawable.FieldService,
            },
            new Project
            {
                Name = "Dexter",
                Description = "Port of popular android app for iOS",
                Icon = Resource.Drawable.Dexter,
            },
            new Project
            {
                Name = "Micro Budget",
                Description = "Developed simple mobile budget app",
                Icon = Resource.Drawable.MicroBudget,
            }
        };
    }
}
