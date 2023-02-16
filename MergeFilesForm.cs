/* *********************************************************************** 
 * Project:     MergeFiles
 * File:        MergeFilesForm
 * Language:    C# 
 * 
 * Description: This class implements the button to call the merge routine and have the user pick
 * the files
 * s
 *             
 * College: Husson University 
 * Course: IT 326 
 * 
 * Edit History; 
 * Ver   Who  Date       Notes 
 * ----  ---- ------     -----------------------------------
 * 0.1   BL  2-13-23      Inital writing  
 * 
 * 0.2   BL  2-15-23      Finished button
 * 
 *                         
 * 
 * ***********************************************************************/
using SortingAlgorithims;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeFiles
{
    public partial class MergeFilesForm : Form
    {
        public MergeFilesForm()
        {
            InitializeComponent();
        }
        #region data 
        #endregion data 

        #region properties 
        #endregion properties  

        #region constructor 
        #endregion constructor

        #region methods   
        public string SelectFile()
        {
            String filePath = String.Empty;

            // all of this code use the openFileDialog 

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Config the intital directory 
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = " txt files (*.txt)|*.txt" + "|"
                    + " comma seperated values (*.csv)|*.csv" + "|"
                    + " configuration files (*.cfg)|*.cfg" + "|"
                    + " All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // Get the selected file name from the user 
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //get path of the selected file 
                    filePath = openFileDialog.FileName;
                    MessageBox.Show(filePath);
                }


            }
            return filePath;

        }
        private void buttonSelectFile1_Click(object sender, EventArgs e)
        {
            String filePath1;
            MessageBox.Show("Please select the first input file");
            filePath1 = SelectFile();
        }
        private void buttonSelectFile2_Click(object sender, EventArgs e)
        {
            String filePath2;
            MessageBox.Show("Please select the second input file");
            filePath2 = SelectFile();
        }

        private void buttonSelectOutput_Click(object sender, EventArgs e)
        {
            String outputFile;
            MessageBox.Show("Please select the output file");
            outputFile = SelectFile();
            
        }

        private void buttonMergeFiles_Click(object sender, EventArgs e)
        {
            try
            {
                String filePath1;
                MessageBox.Show("Please select the first input file");
                filePath1 = SelectFile();
                listBoxFirstFile.Items.Add(filePath1);

                String filePath2;
                MessageBox.Show("Please select the second input file");
                filePath2 = SelectFile();
                listBoxSecondFile.Items.Add(filePath2);

                String outputFile;
                MessageBox.Show("Please select the output file");
                outputFile = SelectFile();
                listBoxOutputFile.Items.Add(outputFile);

                MergeFilesBL.Merge(filePath1, filePath2, outputFile);
            } 
            catch (Exception ex)
            {

                
                MessageBox.Show("Please select a file for every answer"); 
                listBoxFirstFile.Items.Clear(); 
                listBoxSecondFile.Items.Clear(); 
                listBoxOutputFile.Items.Clear();

            }

            
        }
        #endregion methods


    }
}
