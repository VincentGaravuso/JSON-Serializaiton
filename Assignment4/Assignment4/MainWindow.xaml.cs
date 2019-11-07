//******************************************************
// File: MainWindow.xaml.cs
//
// Purpose: Contains the class definition for MainWindow.
//          MainWindow will handle all interactions and operations
//          done with the GUI. This class utilizes the CourseWork.dll
//          to load, search and display data on the front end.
//
// Written By: Vincent Garavuso 
//
// Compiler: Visual Studio 2019
//
//******************************************************
using Microsoft.Win32;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows;
using CourseWork;
namespace Assignment4
{
    public partial class MainWindow : Window
    {

        CourseWork.CourseWork cw;
        public MainWindow()
        {
            InitializeComponent();
        }

        //****************************************************
        // Method: OpenCourseWorkBtn_Click
        //
        // Purpose: Opens file chooser dialog, deserializes JSON data using CouseWork.dll and populates
        // controls on the front end with said data.
        //****************************************************
        private void OpenCourseWorkBtn_Click(object sender, RoutedEventArgs e)
        {
            string filename = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Title = "Open Course Work From JSON";
            if (openFileDialog.ShowDialog() == true)
            {
                filename = openFileDialog.FileName;
                CourseWorkFilenameTb.Text = filename;
            }
            else
            {
                return;
            }


            try
            {
                CategoriesListView.Items.Clear();
                AssignmentsListView.Items.Clear();
                SubmissionsListView.Items.Clear();
                FileStream fileStream;
                DataContractJsonSerializer serializerJSON;
                fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                serializerJSON = new DataContractJsonSerializer(typeof(CourseWork.CourseWork));
                cw = (CourseWork.CourseWork)serializerJSON.ReadObject(fileStream);
                CourseNameTb.Text = cw.CourseName;
                OverallGradeTb.Text = Math.Round(cw.CalculateGrade(), 2).ToString();
                foreach (Category c in cw.Categories)
                {
                    CategoriesListView.Items.Add(c);
                }
                foreach (Assignment a in cw.Assignments)
                {
                    AssignmentsListView.Items.Add(a);
                }
                foreach (Submission s in cw.Submissions)
                {
                    SubmissionsListView.Items.Add(s);
                }
                TargetAssignmentTb.Clear();
                AssignmentNameTb.Clear();
                CategoryNameTb.Clear();
                GradeTb.Clear();
            }
            catch
            {

                MessageBoxResult result = MessageBox.Show("Error parsing JSON file.",
                                         "Error",
                                         MessageBoxButton.OK,
                                         MessageBoxImage.Error);
            }
        }

        //****************************************************
        // Method: FindSubmisison_Click
        //
        // Purpose: Verifies necessary fields are filled out and uses CourseWork.dll to find
        // details about subissions.
        //****************************************************
        private void FindSubmissionBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TargetAssignmentTb.Text))
            {
                Submission foundSubmission = cw.FindSubmission(TargetAssignmentTb.Text);
                if (foundSubmission != null)
                {
                    AssignmentNameTb.Text = foundSubmission.AssignmentName;
                    CategoryNameTb.Text = foundSubmission.CategoryName;
                    GradeTb.Text = foundSubmission.Grade.ToString();
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Assignment '" + TargetAssignmentTb.Text + "' not found.",
                                             "Attention",
                                             MessageBoxButton.OK,
                                             MessageBoxImage.None);
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("You must enter an assignment to search for first.",
                                         "Error",
                                         MessageBoxButton.OK,
                                         MessageBoxImage.Error);
            }


        }
    }
}
