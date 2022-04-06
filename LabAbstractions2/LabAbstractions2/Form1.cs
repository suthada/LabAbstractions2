using System.Text;

namespace LabAbstractions2
{
    public partial class Form1 : Form
    {
        private double sum1 = 0;
        private double sum2 = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                string readAllText = File.ReadAllText(openFileDialog.FileName);
                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string allDATARAW = readAllLine[i];
                    string[] allDATASplited = allDATARAW.Split(',');
                    this.dataGridView2.Rows.Add(allDATASplited[0], allDATASplited[1], allDATASplited[2]);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string column = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                column += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += column;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(saveFileDialog.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            /*string User_or_Id = textBoxUserorId.Text;  ได้แล้วแบบหายทีละบรรทัด
            string Password = textBoxPassword.Text;
            string SSID = textBoxSSID.Text;

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = "";
            dataGridView1.Rows[n].Cells[1].Value = "";
            dataGridView1.Rows[n].Cells[2].Value = ""; */

            string User_or_ID = textBoxUserorId.Text;
            string Password = textBoxPassword.Text;
            string SSID = textBoxSSID.Text;

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = "Staff";
            dataGridView1.Rows[n].Cells[1].Value = sum1;
            dataGridView1.Rows[n].Cells[2].Value = User_or_ID;

        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            this.sum1 += sum2;

            string User_or_ID = textBoxUserorId.Text;
            string Password = textBoxPassword.Text;
            string SSID = textBoxSSID.Text;

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = "Staff";
            dataGridView1.Rows[n].Cells[1].Value = sum1;
            dataGridView1.Rows[n].Cells[2].Value = User_or_ID;
            //dataGridView1.Rows[n].Cells[3].Value = Password;
        }
    }
}