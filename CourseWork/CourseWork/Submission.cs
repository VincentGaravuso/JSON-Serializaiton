//******************************************************
// File: Submission.cs
//
// Purpose: Contains the class definition for Submission.
//          Submission will hold all information about a
//          students submissions such as the category name,
//          assignment name and the grade recieved. 
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
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    [DataContract]
    public class Submission
    {
        private string categoryName;
        private string assignmentName;
        private double grade;


        [DataMember(Name = "categoryname")]
        public string CategoryName
        {
            get { return categoryName; }
            set { this.categoryName = value; }
        }

        [DataMember(Name = "assignmentname")]
        public string AssignmentName
        {
            get { return assignmentName; }
            set { this.assignmentName = value; }
        }

        [DataMember(Name = "grade")]
        public double Grade
        {
            get { return grade; }
            set { this.grade = value; }
        }

        //****************************************************
        // Method: Submission
        //
        // Purpose: Default constructor for submission class
        //****************************************************
        public Submission()
        {
            this.categoryName = "N/A";
            this.assignmentName = "N/A";
            this.grade = -1;
        }

        //****************************************************
        // Method: ToString
        //
        // Purpose: Returns string of data member properties from submission class (CategoryName, AssignmentName, Grade).
        //****************************************************
        public override string ToString()
        {
            return "Category Name: " + CategoryName + ", Assignment Name: " + AssignmentName + ", Grade: " + Grade;
        }
    }
}
