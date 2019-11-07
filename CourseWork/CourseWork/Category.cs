//******************************************************
// File: Category.cs
//
// Purpose: Contains the class definition for Category.
//          Category will hold all information about the
//          category of each assignment such as the name
//          and percent towards total grade [weight]. 
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
    public class Category
    {
        #region Private Variables
        private string name;
        //Percentage used to calculate the weight of this category.
        private double percentage;
        #endregion

        #region Properties
        [DataMember(Name="name")]
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
        [DataMember(Name = "percentage")]
        public double Percentage
        {
            get
            {
                return percentage;
            }
            set
            {
                percentage = value;
            }
        }
        #endregion

        #region Class Methods
        //****************************************************
        // Method: Category
        //
        // Purpose: default constructor for category.
        //****************************************************
        public Category()
        {
            Name = "N/A";
            Percentage = -1;
        }
        //****************************************************
        // Method: ToString
        //
        // Purpose: Returns string of data member properties from category class (Name, Percentage).
        //****************************************************
        public override string ToString()
        {
            return "Name: " + Name + ", Percentage: " + Percentage + "%";
        }
        #endregion
    }
}
