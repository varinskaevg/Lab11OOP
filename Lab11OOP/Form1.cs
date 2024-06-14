using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab11OOP
{
    public partial class Form1 : Form
    {
        private OleDbConnection oleDbConnection1;
        private OleDbDataAdapter oleDbDataAdapter1;
        private DataSet dataset1;
        private string dbPath;
        private string imFolder;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged; // Додаємо обробник події
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Вказати шлях до файлу бази даних Car.accdb
            dbPath = Path.Combine(Application.StartupPath, "Car.accdb");
            if (!File.Exists(dbPath))
            {
                MessageBox.Show("База даних не знайдена: " + dbPath);
                return;
            }

            // Відкрити з'єднання із БД
            oleDbConnection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}");

            // Налаштування OleDbDataAdapter з необхідними командами
            oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM cars", oleDbConnection1);
            dataset1 = new DataSet();

            // Папка ілюстрацій
            imFolder = Path.Combine(Application.StartupPath, "Images");

            // Одержати інформацію із БД
            try
            {
                oleDbConnection1.Open();
                oleDbDataAdapter1.Fill(dataset1, "cars");

                if (dataset1.Tables["cars"].Rows.Count == 0)
                {
                    MessageBox.Show("Дані не знайдено.");
                }
                else
                {
                    MessageBox.Show($"Знайдено записів: {dataset1.Tables["cars"].Rows.Count}");
                    // Призначення джерела даних для DataGridView
                    dataGridView1.DataSource = dataset1.Tables["cars"];
                    MessageBox.Show("Дані успішно завантажені в DataGridView");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні даних: " + ex.Message);
            }
            finally
            {
                oleDbConnection1.Close();
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Отримуємо поточний рядок
                DataGridViewRow row = dataGridView1.CurrentRow;

                // Перевіряємо чи рядок не порожній
                if (row != null)
                {
                    // Призначаємо значення TextBox на основі стовпців DataGridView
                    textBox1.Text = row.Cells["name"].Value?.ToString();
                    textBox2.Text = row.Cells["model"].Value?.ToString();
                    textBox3.Text = row.Cells["year"].Value?.ToString();
                    textBox5.Text = row.Cells["tap"].Value?.ToString();
                }
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ви дійсно прагнете вилучити запис?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string imageFile;
            string msg = "";
            if (textBox4.Text.Length == 0)
            {
                imageFile = Path.Combine(imFolder, "nobody.jpg");
            }
            else
            {
                imageFile = Path.Combine(imFolder, textBox4.Text);
            }

            try
            {
                pictureBox1.Image = Bitmap.FromFile(imageFile);
            }
            catch (FileNotFoundException)
            {
                msg = "File not found: " + imageFile;
                pictureBox1.Image = null;
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Виберіть ілюстрацію";
            openFileDialog1.InitialDirectory = imFolder;
            openFileDialog1.Filter = "Фото|*.jpg|Всі файли|*.*";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bool r = openFileDialog1.FileName.ToLower().Contains(openFileDialog1.InitialDirectory.ToLower());
                if (r)
                {
                    textBox4.Text = openFileDialog1.SafeFileName;
                }
                else
                {
                    try
                    {
                        File.Copy(openFileDialog1.FileName, Path.Combine(imFolder, openFileDialog1.SafeFileName));
                        textBox4.Text = openFileDialog1.SafeFileName;
                    }
                    catch (Exception ex)
                    {
                        DialogResult dr = MessageBox.Show(ex.Message + " Замінити його?", "",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (dr == DialogResult.OK)
                        {
                            File.Copy(openFileDialog1.FileName, Path.Combine(imFolder, openFileDialog1.SafeFileName), true);
                            textBox4.Text = openFileDialog1.SafeFileName;
                        }
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                oleDbDataAdapter1.Update(dataset1.Tables["cars"]);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }
    }
}
