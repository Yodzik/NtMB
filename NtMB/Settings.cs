using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NtMB
{
    public static class Settings
    {
        public static readonly Size WIN_MAIN_SIZE_MAX = new Size(250, 1080);
        public static readonly Size WIN_MAIN_SIZE_MIN = new Size(250, 600);
        //Path values
        public static string DirectoryPath { get; private set; }
        public static string FilePathSettings { get; private set; }
        //Windows metrics and positions
        public static Point ScreenResolution { get; private set; }
        public static int WindowMainWidth { get; private set; }
        public static int WindowMainHeight { get; private set; }
        public static Point WindowPositionMain { get; private set; }


        static Settings()
        {
            Settings.SetDefault();
            //Getting values from file and trying to overwrite defaults
            //Settings.GetFromFile(Settings.FilePathSettings);//unfinished
        }

        private static void SetDefault()
        {
            DirectoryPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            FilePathSettings = Settings.DirectoryPath + @"\Settings.xml";
            WindowMainHeight = 600;
            WindowMainWidth = 250;
            ScreenResolution = new Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
            WindowPositionMain = new Point(ScreenResolution.X - WindowMainWidth, 0);
        }

        private static bool GetFromFile(string filePath)//unfinished
        {
            return true;
        }
    }
}
