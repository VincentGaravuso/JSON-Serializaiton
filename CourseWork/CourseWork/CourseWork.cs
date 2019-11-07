//******************************************************
// File: CourseWork.cs
//
// Purpose: Contains the class definition for CourseWork.
//          CourseWork will hold all information about each
//          category, assignment and submission. This class
//          can find submissions by assignment name, calculate
//          a students total grade based of weighted averages
//          and return all information about each category,
//          assignment and submission.
//          This class was built to be used in homework 3.
//
// Written By: Vincent Garavuso 
//
// Compiler: Visual Studio 2019
//
//******************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CourseWork
{
    [DataContract]
    public class CourseWork
    {
        private string courseName;
        private List<Category> categories;
        private List<Assignment> assignments;
        private List<Submission> submissions;


        [DataMember(Name = "coursename")]
        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        } 
        [DataMember(Name = "categories")]
        public List<Category> Categories
        {
            get
            {
                return categories;
            }
            set
            {
                categories = value;
            }
        }
        [DataMember(Name = "assignments")]
        public List<Assignment> Assignments
        {
            get
            {
                return assignments;
            }
            set
            {
                assignments = value;
            }
        }
        [DataMember(Name = "submissions")]
        public List<Submission> Submissions
        {
            get
            {
                return submissions;
            }
            set
            {
                submissions = value;
            }
        }

        //****************************************************
        // Method: CourseWork
        //
        // Purpose: Default constructor for CourseWork class. Instantiates categories, assignments and submissions list.
        //****************************************************
        public CourseWork()
        {
            courseName = "N/A";
            categories = new List<Category>();
            assignments = new List<Assignment>();
            submissions = new List<Submission>();
        }

        //****************************************************
        // Method: FindSubmission
        //
        // Purpose: Given an assignment name, returns submission with corresponding name.
        //****************************************************
        public Submission FindSubmission(string assignmentName)
        {
            foreach(Submission s in Submissions)
            {
                if(s.AssignmentName.ToLower() == assignmentName.ToLower())
                {
                    return s;
                }
            }
            return null;
        }

        //****************************************************
        // Method: CalculateGrade
        //
        // Purpose: Calculates weighted average based off submission averages (by category) and weights of each category.
        //****************************************************
        public double CalculateGrade()
        {
            double examAvg = 0, homeworkAvg = 0, quizAvg = 0, labAvg = 0;
            int numExams = 0, numHomeworks = 0, numQuizzes = 0, numLabs = 0;
            foreach(Submission s in Submissions)
            {
                if(s.CategoryName == "Exams")
                {
                    examAvg += s.Grade;
                    numExams++;
                }
                else if(s.CategoryName == "Homework")
                {
                    homeworkAvg += s.Grade;
                    numHomeworks++;
                }
                else if(s.CategoryName == "Quizzes")
                {
                    quizAvg += s.Grade;
                    numQuizzes++;
                }
                else if(s.CategoryName == "Labs")
                {
                    labAvg += s.Grade;
                    numLabs++;
                }
            }
            examAvg = (examAvg / numExams);
            homeworkAvg = (homeworkAvg / numHomeworks);
            quizAvg = (quizAvg / numQuizzes);
            labAvg = (labAvg / numLabs);

            double examPoints = 0, homeworkPoints = 0, quizPoints = 0, labPoints = 0;
            foreach(Category c in Categories)
            {
                if (c.Name == "Exams")
                {
                    examPoints = (c.Percentage * (examAvg / 100));
                }
                else if (c.Name == "Homework")
                {

                    homeworkPoints = (c.Percentage * (homeworkAvg / 100));
                }
                else if (c.Name == "Quizzes")
                {

                    quizPoints = (c.Percentage * (quizAvg / 100));
                }
                else if (c.Name == "Labs")
                {

                    labPoints = (c.Percentage * (labAvg / 100));
                }
            }

            double grade = examPoints + homeworkPoints + quizPoints + labPoints;
            return grade;

        }

        //****************************************************
        // Method: ListToString
        //
        // Purpose: Given a list of any type, returns each element separated by a new line.
        //****************************************************
        private string ListToString<T>(List<T> list)
        {
            string listAsString = "";
            foreach(T x in list)
            {
                listAsString += x.ToString() + "\n";
            }
            return listAsString;
        }
        //****************************************************
        // Method: ToString
        //
        // Purpose: Returns a string of each data member of the CourseWork class.
        //****************************************************
        public override string ToString()
        {
            return courseName + "\n\n" + ListToString<Category>(categories) + "\n\n" + ListToString<Assignment>(assignments) + "\n\n" + ListToString<Submission>(submissions);
        }

    }
}
