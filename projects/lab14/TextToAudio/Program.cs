using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextToAudio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += (o, e) => CloseApp();
            Application.Run(new Form1());            
        }

        public static void CloseApp()
        {
            TextAudioHelper.GetInstance().StopSpeaking();
            Application.Exit();
        }

    }
}
