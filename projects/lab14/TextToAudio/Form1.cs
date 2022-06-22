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

namespace TextToAudio
{
    public partial class Form1 : Form
    {
        TextAudioHelper tah = TextAudioHelper.GetInstance();

        public Form1()
        {
            InitializeComponent();
            btnClose.Click += (o, e) => Program.CloseApp();
            btnClear.Click += (o, e) => textBox1.Clear();
            btnPlay.Click += (o, e) => tah.SpeakText(textBox1.Text);
            btnOptions.Click += (o, e) => { };
            btnSaveText.Click += (o, e) => {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save Text File";
                sfd.RestoreDirectory = true;
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                sfd.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.DefaultExt = ".txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, textBox1.Text);
                    }catch(Exception ex)
                    {
                        MessageBox.Show($"Error while trying to save the text file {sfd.FileName}.  {ex.Message}");
                    }
                }
            };
            btnLoadText.Click += (o, e) => {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open Text File";
                ofd.RestoreDirectory = true;
                ofd.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.Multiselect = false;
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        textBox1.Clear();
                        textBox1.Text = File.ReadAllText(ofd.FileName);
                    }catch(Exception ex)
                    {
                        MessageBox.Show($"Error while trying to open the text file {ofd.FileName}.  {ex.Message}");
                    }
                }
            };
            btnSaveAudio.Click += (o, e) => {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save Audio File";
                sfd.RestoreDirectory = true;
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                sfd.Filter = "WAV Files (*.wav)|*.wav|All files (*.*)|*.*";
                sfd.DefaultExt = ".wav";
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        tah.CreateWavFile(sfd.FileName, textBox1.Text);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Error while trying to save the audio file {sfd.FileName}.  {ex.Message}");
                    }
                }
            };
            btnLoadAudio.Click += (o,e) => {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open Audio File";
                ofd.RestoreDirectory = true;
                ofd.Filter = "WAV Files (*.wav)|*.wav|All files (*.*)|*.*";
                ofd.Multiselect = false;
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        textBox1.Clear();
                        tah.GetTextFromWavFile(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while trying to open the audio file {ofd.FileName}.  {ex.Message}");
                    }
                }
            };            
            btnStop.Click += (o, e) => tah.StopSpeaking();
            tah.ResultsAction = (t, s) => {
                switch (t) {  
                    case ResultActionType.Text:
                        textBox1.AppendText(s);
                        break;
                    case ResultActionType.Complete:
                    case ResultActionType.FileRead:                        
                    case ResultActionType.FileDeleted:                       
                    case ResultActionType.FileCreated:                       
                    case ResultActionType.Error:
                        MessageBox.Show(s);
                        break;
                }
            };
        }
    }
}
