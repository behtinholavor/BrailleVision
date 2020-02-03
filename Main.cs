using System.Windows.Forms;
using System;
using System.Speech.Synthesis;
using System.Drawing;
using Tesseract;

//https://azure.microsoft.com/pt-br/services/cognitive-services/speech-services/
//http://intervox.nce.ufrj.br/brfacil/
//https://www.microsoft.com/en-us/download/details.aspx?id=27224 | Microsoft Speech Platform - Runtime Languages (Version 11)
/*
 voice.VoiceInfo
"'Microsoft Maria Desktop'  'pt-BR'  'Female'  'Adult' "
    AdditionalInfo: Count = 8
    Age: Adult
    Culture: {pt-BR}
    Description: "Microsoft Maria Desktop - Portuguese(Brazil)"
    Gender: Female
    Id: "TTS_MS_PT-BR_MARIA_11.0"
    Name: "Microsoft Maria Desktop"
    SupportedAudioFormats: Count = 0
*/


namespace BrailleVision
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Load += ApplicationLoad;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ActionClose(sender, e);
            } else if (e.KeyCode == Keys.F12)
            {
                ActionMotivate(sender, e);
            }
        }

        private void ApplicationLoad(object sender, EventArgs e)
        {
            btnConvert.Click += ActionConvert;
            btnReproduce.Click += ActionReproduce;            
            btnClear.Click += ActionClear;
            btnShoot.Click += ActionShoot;
            btnClose.Click += ActionClose;
        }

        private void ActionConvert(object sender, EventArgs e)
        {
            txtConvert.Text = txtInput.Text;
            txtConvert.Font = new Font("Braille Normal", 25, FontStyle.Bold);
            ActionReproduce(sender, e);
        }

        private void ActionReproduce(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Volume = 100;
            synthesizer.Rate = -2;
            synthesizer.SelectVoice("Microsoft Maria Desktop");
            synthesizer.Speak(txtInput.Text);
        }

        private void ActionClear(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtConvert.Clear();
        }

        private void ActionShoot(object sender, EventArgs e)
        {
            dialogFile.Title = "Selecione a imagem";
            dialogFile.FileName = "*.*";
            dialogFile.Filter = "image files (*.bmp)|*.png|All files (*.*)|*.*";
            dialogFile.ShowDialog();
            string path = dialogFile.FileName;
            if ((!String.IsNullOrEmpty(path)) && (!String.IsNullOrWhiteSpace(path)))
            {
                ReadImage(path);
            }            
        }

        private void ActionClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActionMotivate(object sender, EventArgs e)
        {
            ActionClear(sender, e);
            txtInput.Text = "O êxito da vida não se mede pelo caminho que você conquistou,";
            txtInput.Text += " mas sim pelas dificuldades que superou no caminho.";
            txtInput.Text += " Abraham Lincoln";
            ActionConvert(sender, e);
        }

        public void ReadImage(string path) 
        {            
            try
            {
                using (var engine = new TesseractEngine(@"tessdata", "por", EngineMode.Default))
                {
                    using (var image = Pix.LoadFromFile(path))
                    {
                        using (var page = engine.Process(image))
                        {
                            var text = page.GetText();
                            var rate = page.GetMeanConfidence() * 100;

                            Console.WriteLine("Rate: {0}", rate.ToString() + "%");
                            Console.WriteLine("Text: /r/n{0}", text);

                            if ((!String.IsNullOrEmpty(text)) && (!String.IsNullOrWhiteSpace(text)))
                            {
                                object sender = new object();
                                KeyEventArgs e = new KeyEventArgs(0);
                                ActionClear(sender, e);
                                txtInput.Text = text;                                
                                ActionConvert(sender, e);
                            }

                        }
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Exception: {0}", e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }


    }
}
