using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Mod8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|KAI Notepad File (*.tnf)|*.tnf";
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
        }

        private void настройкиШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog.Font;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFile.FileName;

                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Считывание данных о шрифте
                        string fontName = reader.ReadLine().Split(':')[1];
                        float fontSize = float.Parse(reader.ReadLine().Split(':')[1]);
                        FontStyle fontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), reader.ReadLine().Split(':')[1]);

                        // Устанавка шрифта в RichTextBox
                        richTextBox1.SelectionFont = new Font(fontName, fontSize, fontStyle);

                        // Загрузка содержииого из файла в RichTextBox
                        richTextBox1.Rtf = reader.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
                }
            }


        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text File (*.txt)|*.txt";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFile.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Сохранение данных о шрифте перед сохранением текста
                        writer.WriteLine($"FontName:{richTextBox1.Font.Name}");
                        writer.WriteLine($"FontSize:{richTextBox1.Font.Size}");
                        writer.WriteLine($"FontStyle:{richTextBox1.Font.Style}");

                        // Сохранение содержимого RichTextBox
                        writer.Write(richTextBox1.Rtf);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
                }
            }
        }     

        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFile.FileName;

                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Считывание данных о шрифте
                        string fontName = reader.ReadLine().Split(':')[1];
                        float fontSize = float.Parse(reader.ReadLine().Split(':')[1]);
                        FontStyle fontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), reader.ReadLine().Split(':')[1]);

                        // Устанавка шрифта в RichTextBox
                        richTextBox1.SelectionFont = new Font(fontName, fontSize, fontStyle);

                        // Загрузка содержииого из файла в RichTextBox
                        richTextBox1.Rtf = reader.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
                }
            }
        }

        private void сохранитьКакToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text File (*.txt)|*.txt";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFile.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Сохранение данных о шрифте перед сохранением текста
                        writer.WriteLine($"FontName:{richTextBox1.Font.Name}");
                        writer.WriteLine($"FontSize:{richTextBox1.Font.Size}");
                        writer.WriteLine($"FontStyle:{richTextBox1.Font.Style}");

                        // Сохранение содержимого RichTextBox
                        writer.Write(richTextBox1.Rtf);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
                }
            }
        }

        private void настройкиШрифтаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog.Font;
        }
    }
}