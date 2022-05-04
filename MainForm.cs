using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace watch_complete_activity
{
    public partial class Form : System.Windows.Forms.Form
    {
        List<string> listClockTelemetry = new List<string>();
        string PATH = null;

        public Form()
        {
            InitializeComponent();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            cmdDataPick1.SelectedItem = cmdDataPick1.FindString(cmdDataPick1.Text);
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            cmdDataPick2.SelectedItem = cmdDataPick2.FindString(cmdDataPick2.Text);
        }

        private void ClearInfo()
        {
            listBox1.Items.Clear();
            cmdDataPick1.Items.Clear();
            cmdDataPick2.Items.Clear();
        }

        private async void selectToolStrop_Click(object sender, EventArgs e)
        {
            await AddItem();
        }

        private async Task AddItem()
        {
            listBox1.Items.Clear();
            textBox1.Text = "";

            ClearInfo();
            await EnableBtn(false);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                PATH = openFileDialog.FileName;
                var fileValue = System.IO.File.ReadAllText(PATH);

                var data = fileValue.Split('\n');

                progressBar1.Maximum = data.Length;
                progressBar1.Visible = true;

                listBox1.BeginUpdate();
                cmdDataPick1.BeginUpdate();
                cmdDataPick2.BeginUpdate();

                for (int i = 0; i < data.Length; i++)
                {
                    await Task.Run(() => { progressBar1.Value = i; });
                    listBox1.Items.Add(data[i]);
                    cmdDataPick1.Items.Add(data[i].Split(';')[0]);
                    cmdDataPick2.Items.Add(data[i].Split(';')[0]);
                }

                listBox1.EndUpdate();
                cmdDataPick1.EndUpdate();
                cmdDataPick2.EndUpdate();


                MessageBox.Show("Все данные телеметрии считаны.", "Уведомление");

                this.Text = "Заполнение телеметрии";
                progressBar1.Value = 0;
                progressBar1.Visible = false;

                await EnableBtn(true);
            }
        }
        
        private async Task EnableBtn(bool IsState)
        {
            btnDataSave.Enabled = IsState;
            btnEntrySave.Enabled = IsState;
            btnFill_a.Enabled = IsState;
            btnSearch.Enabled = IsState;
            saveAsToolStripMenuItem.Enabled = IsState;
            saveToolStripMenuItem.Enabled = IsState;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString().Trim();
        }

        private void exitToolStrip_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDataSave_Click(object sender, EventArgs e)
        {
            if (cmdDataPick1.SelectedIndex != -1 && cmdDataPick2.SelectedIndex != -1 && cmbActivity1.SelectedIndex != -1)
            {
                ClearLetter(cmdDataPick1.SelectedIndex, cmdDataPick2.SelectedIndex + 1);
                Task.Run(async () => await FillActivity(cmdDataPick1.SelectedIndex, cmdDataPick2.SelectedIndex + 1, $";{cmbActivity1.Text}"));
            }
            else
            {
                MessageBox.Show("Выберите два периода времени (от и до) и \"Актиновсть\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEntrySave_Click(object sender, EventArgs e)
        {
            if (cmbActivity2.SelectedIndex != -1)
            {
                var index = listBox1.SelectedIndex;
                //this.listBox1.Items[index] = $"{listClockTelemetry[index]} {cmbActivity2.Text}";
                this.textBox1.Text += $";{cmbActivity2.Text}";
                this.listBox1.Items[index] = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Выберите два периода времени (от и до) и \"Актиновсть\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //listBox1.SelectedItem = listBox1.FindString(textBox2.Text);
            //cmdDataPick1.SelectedItem = cmdDataPick1.FindString(cmdDataPick1.Text);
        }

        private void btnFill_a_Click(object sender, EventArgs e)
        {
            ClearLetter(0, listBox1.Items.Count);
            Task.Run(async () => await FillActivity(0, listBox1.Items.Count, ";a"));
        }

        private void ClearLetter(int start, int end)
        {
            Regex regex = new Regex(@".+\d");


            for (int i = start; i < end; i++)
            {
                if (regex.IsMatch(listBox1.Items[i].ToString()))
                {
                    if (listBox1.Items[i].ToString().Length != 0)
                    {
                        var regexValue = regex.Match(listBox1.Items[i].ToString()).Value;
                        var length = listBox1.Items[i].ToString().Length;
                        var delIndex = length - (length - regexValue.Length);

                        if (delIndex < length)
                            listBox1.Items[i] = listBox1.Items[i].ToString().Remove(delIndex);
                    }
                }
            }
        }

        private async Task FillActivity(int start, int end, string typeActivity)
        {
            progressBar1.Value = start;
            progressBar1.Maximum = end;
            progressBar1.Visible = true;

            listBox1.BeginUpdate();

            for (int i = start; i < end; i++)
            {
                listBox1.Items[i] = $"{listBox1.Items[i]}{typeActivity}";
                progressBar1.Value = i;
            }

            listBox1.EndUpdate();

            MessageBox.Show("Все данные телеметрии изменены", "Уведомление");

            this.Text = "Заполнение телеметрии";
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }

        private async void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                using (System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(saveFileDialog.FileName))
                {
                    progressBar1.Value = 0;
                    progressBar1.Maximum = listBox1.Items.Count;
                    progressBar1.Visible = true;

                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        await SaveFile.WriteAsync(listBox1.Items[i].ToString() + "\n");

                        progressBar1.Value += 1;
                        this.Text = $"Сохранение данных телеметрии ({progressBar1.Value}/{progressBar1.Maximum})";
                    }

                    SaveFile.Close();
                }

                MessageBox.Show("Все данные телеметрии сохранены", "Уведомление");

                this.Text = "Заполнение телеметрии";
                progressBar1.Visible = false;
                progressBar1.Value = 0;
            }
        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PATH != null)
            {
                using (System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(PATH))
                {
                    progressBar1.Value = 0;
                    progressBar1.Maximum = listBox1.Items.Count;
                    progressBar1.Visible = true;

                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        await SaveFile.WriteAsync(listBox1.Items[i].ToString() + "\n");

                        progressBar1.Value += 1;
                        this.Text = $"Сохранение данных телеметрии ({progressBar1.Value}/{progressBar1.Maximum})";
                    }

                    SaveFile.Close();
                }

                MessageBox.Show("Все данные телеметрии сохранены", "Уведомление");

                this.Text = "Заполнение телеметрии";
                progressBar1.Visible = false;
                progressBar1.Value = 0;
            }
            else
            {
                MessageBox.Show("Откройте файл телеметрии!", "Ошибка");
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
