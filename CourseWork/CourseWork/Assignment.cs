//******************************************************
// File: Assignment.cs
//
// Purpose: Contains the class definition for Assignment.
//          Assignment will hold all assignment information 
//          such as the name, description and category of
//          each assignment. This class was built to be 
//          used in homework 3.
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
    public class Assignment
    {
        #region Private Variables
        private string name;
        private string description;
        private string categoryName;
        #endregion

        #region Properties
        [DataMember(Name = "name")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        [DataMember(Name = "description")]
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        [DataMember(Name = "categoryname")]
        public string CategoryName
        {
            get
            {
                return categoryName;
            }
            set
            {
                categoryName = value;
            }
        }
        #endregion

        #region Class Methods

        //****************************************************
        // Method: Assignment
        //
        // Purpose: default constructor for assignment.
        //****************************************************
        public Assignment()
        {
            Name = "N/A";
            Description = "N/A";
            CategoryName = "N/A";
        }
        //****************************************************
        // Method: ToString
        //
        // Purpose: Returns string of data member properties from assignment class (Name, Description, CategoryName).
        //****************************************************
        public override string ToString()
        {
            return "Name: " + Name + ", Description: " + Description + ", Category Name: " + CategoryName;
        }
        #endregion
    }
}
