using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.AudioFormat;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace TextToAudio
{
    public enum ResultActionType{
        Complete,
        Text,
        FileCreated,
        FileRead,
        FileDeleted,
        Error
    }

    public class TextAudioHelper
    {
        private static TextAudioHelper instance = null;

        public Action<ResultActionType, string> ResultsAction { get; set; }

        public static TextAudioHelper GetInstance()
        {
            if (instance == null)
                instance = new TextAudioHelper();
            return instance;
        }

        private SpeechSynthesizer _Speech;

        private TextAudioHelper() {
            _Speech = new SpeechSynthesizer();
        }
        
        public void SpeakText(string text)
        {
            _Speech.SpeakAsyncCancelAll();
            _Speech.SpeakAsync(text);
        }

        public void StopSpeaking()
        {
            _Speech.SpeakAsyncCancelAll();
        }

        public void CreateWavFile(string file, string text)
        {
            try
            {
                if (!file.EndsWith(".wav"))
                    file = file + ".wav";
                FileInfo fi = new FileInfo(file);
                if (fi.Exists)
                    fi.Delete();
                _Speech.SetOutputToWaveFile(file);
                _Speech.Speak(text);
                _Speech.SetOutputToDefaultAudioDevice();                
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void GetTextFromWavFile(string file)
        {
            try
            {
                SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
                Grammar dGram = new DictationGrammar();
                dGram.Name = "default dictation";
                dGram.Enabled = true;
                sre.LoadGrammar(dGram);
                Grammar sGram = new DictationGrammar("grammar:dictation#spelling");
                sGram.Name = "spelling dictation";
                sGram.Enabled = true;
                sre.LoadGrammar(sGram);
                Grammar cGram = new DictationGrammar("grammar:dictation");
                cGram.Name = "question dictation";
                cGram.Enabled = true;
                sre.LoadGrammar(cGram);                
                sre.SetInputToWaveFile(file);               
                sre.SpeechRecognized += (o, e) => ResultsAction?.Invoke(ResultActionType.Text, $"{e.Result.Text}.  ");       
                sre.RecognizeCompleted += (o,e) => ResultsAction?.Invoke(ResultActionType.Complete, "Speech recognition complete.");
                sre.SpeechRecognitionRejected += (o,e) => ResultsAction?.Invoke(ResultActionType.Error, "Error while trying to recognize a part of audio to text.");
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
