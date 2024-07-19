using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace Speech_to_Text___Text_to_Speech
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer recognitionTimer = new System.Windows.Forms.Timer();
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TSB_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Volume = trackBar1.Value;
                synth.Speak(textBox2.Text);
            }
            else
            {
                MessageBox.Show("Please write something first");
            }
        }
        private void STB_Click_1(object sender, EventArgs e)
        {
            recognitionTimer.Interval = 10000; // 10 seconds (its default base is in milliseconds)
            recognitionTimer.Tick += new EventHandler(OnRecognitionTimeout);

            SpeechRecognitionEngine speech = new SpeechRecognitionEngine();
            speech.SetInputToDefaultAudioDevice();
            speech.LoadGrammar(new DictationGrammar());

            speech.BabbleTimeout = TimeSpan.FromSeconds(10);
            speech.InitialSilenceTimeout = TimeSpan.FromSeconds(10);
            speech.EndSilenceTimeout = TimeSpan.FromSeconds(1);

            speech.SpeechRecognized += (s, args) =>
            {
                if (args.Result != null)
                {
                    recognitionTimer.Stop();
                    MessageBox.Show("Detected: " + args.Result.Text);
                    textBox1.Text = args.Result.Text;
                }
            };

            speech.RecognizeCompleted += (s, args) =>
            {
                if (args.Error != null)
                {
                    recognitionTimer.Stop();
                    MessageBox.Show("Error: " + args.Error.Message);
                }
                else if (args.Result == null)
                {
                    recognitionTimer.Stop();
                    MessageBox.Show("No speech was recognized.");
                }
            };

            try
            {
                recognitionTimer.Start();
                speech.RecognizeAsync(RecognizeMode.Single);
                textBox1.Text = "Listening Now ...";
            }
            catch (InvalidOperationException ex)
            {
                recognitionTimer.Stop();
                textBox1.Text = "";
                MessageBox.Show("Mic not found or other error: " + ex.Message);
            }
        }

        private void OnRecognitionTimeout(object sender, EventArgs e)
        {
            recognitionTimer.Stop();
            MessageBox.Show("No speech was recognized in the first 10 seconds.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a Text File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show("File Uploaded Successfully, Now Reading");
                try
                {
                    string text = File.ReadAllText(filePath);
                    if (!string.IsNullOrEmpty(text))
                    {
                        SpeechSynthesizer synth = new SpeechSynthesizer();
                        synth.Speak(text); 
                    }
                    else
                    {
                        MessageBox.Show("The file is empty. Please select a valid text file.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while reading the file: " + ex.Message);
                }
            }
        }
    }
}
