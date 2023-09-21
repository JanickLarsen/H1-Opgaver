using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Den_gode_systemudviklerv2.Model
{
    /// <summary>
    /// Class <c>Data</c> prepares is to get different date from a file
    /// </summary>
    internal class Data
    {
        /// <summary>
        /// Gets all the text from the File at the Filepath
        /// </summary>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="FormatException"></exception>
        public string GetTextFromFile(string Filepath)
        {
            StreamReader? sr = null;

            try
            {
                sr = new StreamReader(Filepath);
                StringBuilder fileText = new StringBuilder();

                string  line = sr.ReadLine()!;
                //Continue to read until you reach end of file
                while (line != null)
                {
                    fileText.Append(line);
                    //Read the next line
                    line = sr.ReadLine()!;
                }
                return fileText.ToString();
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("The file do not exit", e);
            }
            catch (IOException e)
            {
                throw new IOException("A error while reading the file", e);
            }
            catch (FormatException e)
            {
                throw new FormatException("File is not the current format", e);
            }
            finally
            {
                //close the file
                if (sr != null) sr.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="FormatException"></exception>
        public long GetFileSize(string Filepath)
        {
            try
            {
                return new FileInfo(Filepath).Length;
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("The file do not exit", e);
            }
            catch (IOException e)
            {
                throw new IOException("A error while reading the file", e);
            }
            catch (FormatException e)
            {
                throw new FormatException("File is not the current format", e);
            }
        }
    }
}
