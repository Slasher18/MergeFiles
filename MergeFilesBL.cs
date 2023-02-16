/* *********************************************************************** 
 * Project:     MergeFiles
 * File:        MergeFilesBL
 * Language:    C# 
 * 
 * Description: This class implements a merge routine to combine two files with no 
 * saved memory 
 *             
 * College: Husson University 
 * Course: IT 326 
 * 
 * Edit History; 
 * Ver   Who  Date       Notes 
 * ----  ---- ------     -----------------------------------
 * 0.1   BL  2-13-23      Inital writing  
 * 0.2   BL  2-14-23      Bulk of code completed not yet running 
 * 0.3   BL  2-15-23      Code working and error catching starts 
 * 
 *                         
 * 
 * ***********************************************************************/
using System;
using System.IO;
using System.Windows.Forms;

namespace SortingAlgorithims
{
    internal class MergeFilesBL
    {
        #region data 
        #endregion data 

        #region properties 
        #endregion properties  

        #region constructor  

        #endregion constructor

        #region methods 

        public static void Merge(string filePath1, string filePath2, string outputFile)
        {
            String fileVal1;
            String fileVal2;

                               
            FileStream stream;
            FileStream stream2;
            FileStream stream3; 
            
            stream = File.Open(filePath1, FileMode.Open, FileAccess.Read);
            stream2 = File.Open(filePath2, FileMode.Open, FileAccess.Read);
            stream3 = File.Open(outputFile, FileMode.Open, FileAccess.Write);
            StreamReader file1 = new StreamReader(stream);
            StreamReader file2 = new StreamReader(stream2);
            StreamWriter file3 = new StreamWriter(stream3);


            fileVal1 = file1.ReadLine();
            fileVal2 = file2.ReadLine();


            while (!file1.EndOfStream || !file2.EndOfStream)
            {


                int val1 = Convert.ToInt32(fileVal1);


                int val2 = Convert.ToInt32(fileVal2);


                //int val1 = int.Parse(fileVal1);
                //int val2 = int.Parse(fileVal2);

                if (val1 < val2)
                {
                    file3.WriteLine(fileVal1);
                    fileVal1 = file1.ReadLine();
                }
                else if (val1 > val2)
                {
                    file3.WriteLine(fileVal2);
                    fileVal2 = file2.ReadLine();
                }
                else if (val1 == val2)
                {
                    file3.WriteLine(fileVal1);
                    fileVal1 = file1.ReadLine();
                }



            }
            if (fileVal1 == null || fileVal1 == "")
            {
                while (fileVal2 != null)
                {
                    file3.WriteLine(fileVal2);
                    fileVal2 = file2.ReadLine();
                }
            }
            else if (fileVal2 == null || fileVal2 == "")
            {
                while (fileVal1 != null)
                {
                    file3.WriteLine(fileVal1);
                    fileVal1 = file1.ReadLine();
                }
            }



            file1.Close();
            file2.Close();
            file3.Close();
            MessageBox.Show("All done my man");
        }


        #endregion methods
    }
}
