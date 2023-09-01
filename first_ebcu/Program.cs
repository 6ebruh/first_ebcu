namespace first_ebcu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBmanager dbmanager = new DBmanager();
            dbmanager.Connect("database");
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}