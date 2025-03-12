namespace VolleyballRecruitmentApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogReg()); // Ensure this references Form1 correctly
        }
    }
}
