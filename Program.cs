namespace ExpensePlus
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application. We invoke the loading screen from here, 
        ///  this is a single entry point of the application thread which is also a single thread as marked by the STA attribute.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new Loading());
        }
    }
}