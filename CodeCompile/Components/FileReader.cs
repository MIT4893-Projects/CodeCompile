namespace CodeCompile.Components
{
    /// <summary>
    /// Provides methods for reading files.
    /// </summary>
    static class FileReader
    {
        /// <summary>
        /// Read all text in the given file.
        /// </summary>
        /// <param name="filename">File's name to read.</param>
        /// <returns>Full file's content.</returns>
        public static string ReadFullFile(string filename)
        {
            string fileContent = string.Empty;

            try
            {
                fileContent = File.ReadAllText(filename);
            }
            catch (FileNotFoundException) { }
            catch (DirectoryNotFoundException) { }

            return fileContent;
        }

        /// <summary>
        /// Read all text in the file in the same folder with application.
        /// </summary>
        /// <param name="filename">File's name to read.</param>
        /// <returns>Full file's content.</returns>
        public static string ReadFullFileSameApplicationDir(string filename)
        {
            string applicationPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(applicationPath, filename);

            return ReadFullFile(filePath);
        }
    }
}
