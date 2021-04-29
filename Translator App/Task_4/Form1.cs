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

namespace Task_4
{
    public partial class Form1 : Form
    {
        private Progress database;

        public Form1()
        {
            InitializeComponent();
            this.Text = "English words";
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new Progress(saveFileDialog.FileName);
                database.Add(tbWord.Text, tbTranslate.Text);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;

                String fileName = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                Text = String.Concat("English words. " + "Current file: " + fileName);
            }

        }
        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new Progress(openFileDialog.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;

                tbWord.Text = database[0].engWord;
                tbTranslate.Text = database[0].rusWord;

                String fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                Text = String.Concat("English words. " + "Current file: " + fileName);
            }
        }
        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                if (tbWord.Text == String.Empty || tbTranslate.Text == String.Empty)
                {
                    MessageBox.Show("Please, fill both text fields.", "Message");
                    return;
                }
                database[(int)nudNumber.Value - 1].engWord = tbWord.Text;
                database[(int)nudNumber.Value - 1].rusWord = tbTranslate.Text;
                database.Save();
            }
            else
            {
                MessageBox.Show("Please, create a new file.", "Message");
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    database = new Progress(saveFileDialog.FileName);
                    database.Add(tbWord.Text, tbTranslate.Text);
                    database.Save();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = 1;
                    nudNumber.Value = 1;
                    String fileName = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                    Text = String.Concat("English words. " + "Current file: " + fileName);
                }

            }
        }
        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                if (tbWord.Text == String.Empty || tbTranslate.Text == String.Empty)
                {
                    MessageBox.Show("Please, fill both text fields.", "Message");
                    return;
                }
                database[(int)nudNumber.Value - 1].engWord = tbWord.Text;
                database[(int)nudNumber.Value - 1].rusWord = tbTranslate.Text;
                database.Save();
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    database = new Progress(saveFileDialog.FileName);
                    database.Add(tbWord.Text, tbTranslate.Text);
                    database.Save();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = 1;
                    nudNumber.Value = 1;
                    database.Save();
                    String fileName = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                    Text = String.Concat("English words. " + "Current file: " + fileName);
                }

            }

        }
        private void menuItemAdd_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database.Add("", "");
                nudNumber.Maximum = database.Count;
                nudNumber.Value = database.Count;
            }
            else MessageBox.Show
                    ("Please, create or open a new file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                if (nudNumber.Value < 2)
                {
                    MessageBox.Show("The word list cannot contain less than 1 value.", "Message");
                    return;
                }
                database.Remove((int)nudNumber.Value - 1);
                nudNumber.Maximum = database.Count;

            }
            else MessageBox.Show
                    ("Please, create or open a new file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void menuItemExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        private void tbAboutApp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Goncharova Kateryna\nDate of creation: 21.04.2021\nVersion: 1", "About Application");
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database != null)
            {
                tbWord.Text = database[(int)nudNumber.Value - 1].engWord;
                tbTranslate.Text = database[(int)nudNumber.Value - 1].rusWord;
            }
            else 
            {
                nudNumber.Value = 0;
                MessageBox.Show("Please, create or open a new file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
