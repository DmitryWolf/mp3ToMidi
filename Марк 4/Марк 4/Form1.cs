using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAudio;
using WindowsInput;
using WindowsInput.Native;
using System.Diagnostics;
using NAudio.Wave;
using NAudio.Midi;
using System.Media;

namespace Марк_4
{

    public partial class Form1 : Form
    {
        InputSimulator sim = new InputSimulator();
        InputSimulator sim2 = new InputSimulator();
        private AudioPlayer Player;
        string str = "";
        List<string> arr = new List<string>();


        public Form1()
        {
            InitializeComponent();
            Player = new AudioPlayer();
            Player.PlayingStatusChanged += (s, e) => button1.Text = e == Status.Playing ? "Pause" : "Play";
            Player.AudioSelected += (s, e) =>
            {
                trackBar1.Maximum = (int)e.Duration;
                label1.Text = e.Name;
                if (str[str.Length - 1] != '3' && str[str.Length - 1] != 'd')
                    label3.Text = e.DurationTime.ToString(@"mm\:ss");
                else if (str[str.Length - 1] != 'd')
                {
                    Mp3FileReader reader = new Mp3FileReader(str);
                    TimeSpan duration = reader.TotalTime;
                    string time = duration.TotalSeconds.ToString();
                    int i = 0;
                    int sec = 0, min = 0;
                    while (time[i] != ',')
                    {
                        if (sec == 0)
                        {
                            sec = time[i] - 48;
                        }
                        else
                        {
                            sec = sec * 10 + time[i] - 48;
                        }
                        i++;
                    }
                    min = sec / 60;
                    sec = sec % 60;


                    if (min < 10 && sec < 10)
                        label3.Text = "0" + min + ":" + "0" + sec;
                    else if (sec < 10)
                        label3.Text = min + ":" + "0" + sec;
                    else if (min < 10)
                        label3.Text = "0" + min + ":" + sec;

                }
                else
                { // доделать для миди

                }
                listBox1.SelectedItem = e.Name;
            };
            Player.ProgressChanged += (s, e) =>
            {
                if (str[str.Length - 1] != '3' && str[str.Length - 1] != 'd')
                    trackBar1.Value = (int)e; // ошибка при воспроизведении midi
                else
                {//доделать для миди
                    //TimeSpan position = TimeSpan.FromSeconds(str);
                    //trackBar1.Value = 
                }

                label2.Text = ((AudioPlayer)s).PositionTime.ToString(@"mm\:ss");
            };
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(flowLayoutPanel1.Location.X + flowLayoutPanel1.Width / 2, flowLayoutPanel1.Location.Y + flowLayoutPanel1.Height / 2);
            flowLayoutPanel1.BackColor = Color.Transparent;
            label1.Text = "";
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;

            label2.Text = "";
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;

            label3.Text = "";
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Play")
                Player.Play();
            else if (((Button)sender).Text == "Pause")
                Player.Pause();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedItem == null)
                return;
            Player.SelectAudio(((ListBox)sender).SelectedIndex);
            str = listBox1.SelectedItem.ToString();
        }




        private void trackBar1_Scroll(object sender, EventArgs e) => Player.Position = ((TrackBar)sender).Value;

        private void trackBar2_Scroll(object sender, EventArgs e) => Player.Volume = ((TrackBar)sender).Value;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "Audio Files|*mp3;*.wav;*mid;"
            }
            )
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < dialog.FileNames.Count(); i++)
                    {
                        arr.Add(dialog.FileNames[i]);
                    }

                    str = dialog.FileName;
                    Player.LoadAudio(dialog.FileNames);
                    listBox1.Items.Clear();

                    for (int i = 0; i < arr.Count(); i++)
                    {
                        listBox1.Items.Add(arr[i]);
                    }
                }
            }
        }

        private void mP3ToWAVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                if (str[str.Length - 1] == '3')
                {
                    var infile = str;
                    string str1 = str.Remove(str.Length - 3) + "wav";
                    var outfile = str1;
                    using (var reader = new MediaFoundationReader(infile))
                    {
                        WaveFileWriter.CreateWaveFile(outfile, reader);
                    }
                    MessageBox.Show("Вы конвертировали MP3 в WAV", "Успех!");
                }
                else MessageBox.Show("Вы пытаетесь перевести перевести " + str[str.Length - 3] + str[str.Length - 2] + str[str.Length - 1] + " файл. Выберите mp3 файл", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wAVToMIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                if (str[str.Length - 1] != 'v' || str[str.Length - 2] != 'a' || str[str.Length - 3] != 'w')
                {
                    MessageBox.Show("Вы пытаетесь перевести перевести " + str[str.Length - 3] + str[str.Length - 2] + str[str.Length - 1] + " файл. Выберите wav файл", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Process.Start("C:/Windows/system32/cmd.exe");
                    sim.Keyboard.Sleep(1000);
                    sim.Keyboard.TextEntry("cd /d C:/Users/Hunte/PycharmProjects/pythonProject8");
                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    sim.Keyboard.TextEntry("python main.py");
                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    sim.Keyboard.TextEntry(str);
                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    sim.Keyboard.TextEntry("exit");
                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                }
            }
        }

        private void mIDToPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                if (str[str.Length - 1] == 'd')
                {
                    Process.Start("C:/Users/Hunte/PycharmProjects/pythonProject8/sheet.exe");
                    sim.Keyboard.Sleep(2000);
                    sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LCONTROL, new[]{
                VirtualKeyCode.VK_O});
                    sim.Keyboard.TextEntry(str);
                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    sim.Keyboard.Sleep(2000);
                    sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LCONTROL, new[]{
                VirtualKeyCode.VK_S});
                    sim.Keyboard.Sleep(3000);
                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    sim.Keyboard.Sleep(5000);
                    sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LMENU, new[] { VirtualKeyCode.F4 });
                }
                else MessageBox.Show("Вы пытаетесь перевести перевести " + str[str.Length - 3] + str[str.Length - 2] + str[str.Length - 1] + " файл. Выберите mid файл", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mIDToSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                if (str[str.Length - 1] == 'd')
                {
                    Process.Start("C:/Users/Hunte/PycharmProjects/pythonProject8/sheet.exe");
                    sim.Keyboard.Sleep(2000);
                    sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, new[]{
                VirtualKeyCode.VK_O});
                    sim.Keyboard.Sleep(2000);
                    sim.Keyboard.TextEntry(str);
                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    sim.Keyboard.Sleep(2000);
                    sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, new[]{
                VirtualKeyCode.VK_P});
                }
                else MessageBox.Show("Вы пытаетесь перевести перевести " + str[str.Length - 3] + str[str.Length - 2] + str[str.Length - 1] + " файл. Выберите mid файл", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mP3ToMIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                if (str[str.Length - 1] == '3')
                {
                    var infile = str;
                    string str1 = str.Remove(str.Length - 3) + "wav";
                    var outfile = str1;
                    using (var reader = new MediaFoundationReader(infile))
                    {
                        WaveFileWriter.CreateWaveFile(outfile, reader);
                    }
                    Process.Start("C:/Windows/system32/cmd.exe");
                    sim.Keyboard.Sleep(1000);
                    sim.Keyboard.TextEntry("cd /d C:/Users/Hunte/PycharmProjects/pythonProject8");
                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    sim.Keyboard.TextEntry("python main.py");
                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    sim.Keyboard.TextEntry(str1);
                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    sim.Keyboard.TextEntry("exit");
                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                }
                else MessageBox.Show("Вы пытаетесь перевести перевести " + str[str.Length - 3] + str[str.Length - 2] + str[str.Length - 1] + " файл. Выберите mp3 файл", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sheetMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                if (str[str.Length - 1] == 'd')
                {
                    Process.Start("C:/Users/Hunte/PycharmProjects/pythonProject8/sheet.exe");
                    sim.Keyboard.Sleep(2000);
                    sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, new[]{
                VirtualKeyCode.VK_O});
                    sim.Keyboard.Sleep(2000);
                    sim.Keyboard.TextEntry(str);
                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                }
                else MessageBox.Show("Вы пытаетесь перевести перевести " + str[str.Length - 3] + str[str.Length - 2] + str[str.Length - 1] + " файл. Выберите mid файл", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
