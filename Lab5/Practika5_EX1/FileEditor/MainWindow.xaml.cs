using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace FileEditor
{
    class TextFileOperations
    {
        public static string ReadTextFileContents(string fileName)
        {
            return File.ReadAllText(fileName);
        }
        public static void WriteTextFileContents(string fileName, string text)
        {
            File.WriteAllText(fileName, text);
        }
    } 


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Name of file in use
        /// </summary>
        private string fileName = String.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open the file after the user has been prompted for the file name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {            
            // Call GetFileName to get the name of the file to load
            fileName = GetFileName(); 

            
            // Populate the editor TextBox with the file contents
            if (fileName != String.Empty)
            {
                editor.Text =
                TextFileOperations.ReadTextFileContents(fileName);
            }
         }

        
        // Add a GetFileName method
        private string GetFileName()
        {
            string fname = String.Empty;
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.InitialDirectory =
            @"E:\Labfiles\Lab 5\Ex1\Starter";
            openFileDlg.DefaultExt = ".txt";
            openFileDlg.Filter = "Text Documents (.txt)|*.txt";
            bool? result = openFileDlg.ShowDialog();
            if (result == true)
            {
                fname = openFileDlg.FileName;
            }
            return fname;
        }


 

        // Save the data back to the file
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            
            // Write the contents of the editor TextBox back to the file
            if (fileName != String.Empty)
            {
                TextFileOperations.WriteTextFileContents(fileName,
                editor.Text);
            } 
        }
    }   
}
