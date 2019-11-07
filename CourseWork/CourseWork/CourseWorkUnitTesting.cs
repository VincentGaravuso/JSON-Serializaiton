using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CourseWork
{

    public class CourseWorkUnitTesting
    {
        #region Class Methods
        public void UnitTestCategory()
        {
            Category c = new Category();
            string name = "Vinny";
            c.Name = name;
            if(c.Name == name)
            {
                Console.WriteLine("Category Name property, invalid value: Pass");
            }
            else
            {
                Console.WriteLine("Category Name property, invalid value: FAIL!");
            }

            double percentage = 49;
            c.Percentage = percentage;

            if (c.Percentage == percentage)
            {
                Console.WriteLine("Category Percentage property, invalid value: Pass");
            }
            else
            {
                Console.WriteLine("Category Percentage property, invalid value: FAIL!");
            }

        }
        public void UnitTestAssignment()
        {
            Assignment a = new Assignment();
            string name = "VinnyG";
            a.Name = name;
            if (a.Name == name)
            {
                Console.WriteLine("Assignment Name property, invalid value: Pass");
            }
            else
            {
                Console.WriteLine("Assignment Name property, invalid value: FAIL!");
            }
            string description = "Shalalala Lorem Ipsum psudo description here hi";
            a.Description = description;
            if (a.Description == description)
            {
                Console.WriteLine("Assignment Description property, invalid value: Pass");
            }
            else
            {
                Console.WriteLine("Assignment Description property, invalid value: FAIL!");
            }
            string catName = "States that start with Q";
            a.CategoryName = catName;
            if (a.CategoryName == catName)
            {
                Console.WriteLine("Assignment CategoryName property, invalid value: Pass");
            }
            else
            {
                Console.WriteLine("Assignment CategoryName property, invalid value: FAIL!");
            }

        }
        #endregion
    }
}
