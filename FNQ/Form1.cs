using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FNQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string datafileURI = "";
        public GameState datafile;

        private void saveFile()
        {
            if (datafileURI == "")
            {
                MessageBox.Show("Data File is not opened!");
                return;
            }

            XmlSerializer ser = new XmlSerializer(typeof(GameState));
            TextWriter writer = new StreamWriter(datafileURI);
            ser.Serialize(writer, datafile);
            writer.Close();
        }

        private void buttonLoadDataFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            datafileURI = saveFileDialog1.FileName;
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(GameState));
                TextReader reader = new StreamReader(datafileURI);
                datafile = (GameState)ser.Deserialize(reader);
                reader.Close();
                if (datafile == null) throw new Exception("null datafile");
                if (datafile.questionDB == null) throw new Exception("null datafile");
            }
            catch (Exception ex)
            {
                datafile = new GameState();
                datafile.questionDB = new QuizQuestion[1];
                for (int i = 0; i < 1; i++) datafile.questionDB[i] = new QuizQuestion();
                saveFile();
            }
            
            dataGridView1.DataSource = datafile.questionDB;
            buttonAddQuestion.Enabled = buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            // dirty, i know...
            List<QuizQuestion> qql = datafile.questionDB.ToList<QuizQuestion>();
            qql.Add(new QuizQuestion());
            datafile.questionDB = qql.ToArray();
            saveFile();
            dataGridView1.DataSource = datafile.questionDB;
        }

        private void buttonLoadRanking_Click(object sender, EventArgs e)
        {
            if (datafile.rankingDB == null) return;

            dataGridView2.DataSource = datafile.rankingDB;
          //  dataGridView2.Sort(dataGridView2.Columns["points"], ListSortDirection.Descending);

        }
        bool locked=false;

        private void markCorrect()
        {
            if (cq.answerIndex == 1) labelAns1.BackColor = Color.Green;
            if (cq.answerIndex == 2) labelAns2.BackColor = Color.Green;
            if (cq.answerIndex == 3) labelAns3.BackColor = Color.Green;
            if (cq.answerIndex == 4) labelAns4.BackColor = Color.Green;
            locked = true;
            
        }

        private void labelAns1_Click(object sender, EventArgs e)
        {
            if (locked) return;
            if (cq.answerIndex != 1) labelAns1.ForeColor = Color.Red;
            else
            {
                re.points++;
                labelWynik.Text = "Wynik: "+re.points.ToString();
            }
            qIndex++;
            markCorrect();
        }

        private void labelAns2_Click(object sender, EventArgs e)
        {
            if (locked) return;
            if (cq.answerIndex != 2) labelAns2.ForeColor = Color.Red;
            else
            {
                re.points++;
                labelWynik.Text = "Wynik: " + re.points.ToString();
            }
            qIndex++;
            markCorrect();
        }

        private void labelAns3_Click(object sender, EventArgs e)
        {
            if (locked) return;
            if (cq.answerIndex != 3) labelAns3.ForeColor = Color.Red;
            else
            {
                re.points++;
                labelWynik.Text = "Wynik: " + re.points.ToString();
            }
            qIndex++;
            markCorrect();
        }

        private void labelAns4_Click(object sender, EventArgs e)
        {
            if (locked) return;
            if (cq.answerIndex != 4) labelAns4.ForeColor = Color.Red;
            else
            {
                re.points++;
                labelWynik.Text = "Wynik: "+re.points.ToString();
            }
            qIndex++;
            markCorrect();
        }

        RankingEntry re;
        int qIndex, maxIndex;
        QuizQuestion cq;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxImie.Text=="")
            {
                MessageBox.Show("podaj imię!");
                return;
            }
            re = new RankingEntry();
            re.name = textBoxImie.Text;
            qIndex = 0;

            maxIndex = 0;
            for (int i=0; i<datafile.questionDB.Length; i++)
            {
                if (datafile.questionDB[i].enabled) maxIndex++;
            }

            labelAns1.Show(); labelAns2.Show(); labelAns3.Show(); labelAns4.Show();
            nextQuestion();
            panel1.Enabled = true;

        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            nextQuestion();
            locked = false;
        }

        private void nextQuestion()
        {
            labelAns1.ForeColor = Color.Black;
            labelAns2.ForeColor = Color.Black;
            labelAns3.ForeColor = Color.Black;
            labelAns4.ForeColor = Color.Black;
            labelAns1.BackColor = Color.Transparent;
            labelAns2.BackColor = Color.Transparent;
            labelAns3.BackColor = Color.Transparent;
            labelAns4.BackColor = Color.Transparent;

            if (qIndex < maxIndex)
            {

                cq = datafile.questionDB[qIndex];
                labelQuestion.Text = "Pytanie: " + cq.questionBody;
                labelAns1.Text = "a) " + cq.ans1;
                labelAns2.Text = "b) " + cq.ans2;
                labelAns3.Text = "c) " + cq.ans3;
                labelAns4.Text = "d) " + cq.ans4;

            }
            else
            {
                labelQuestion.Text = "Gratulacje!";
                labelAns1.Hide(); labelAns2.Hide(); labelAns3.Hide(); labelAns4.Hide();

                // dirty, i know...
                List<RankingEntry> rel;
                if (datafile.rankingDB==null)
                {
                    datafile.rankingDB = new RankingEntry[1];
                }
                rel = datafile.rankingDB.ToList<RankingEntry>();
                rel.Add(re);
                datafile.rankingDB = rel.ToArray();
                saveFile();
                //dataGridView2.DataSource = datafile.rankingDB;
                //dataGridView2.Sort(dataGridView2.Columns["points"], ListSortDirection.Descending);
            }
        }
    }
}
