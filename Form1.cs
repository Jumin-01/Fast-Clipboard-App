using System.Diagnostics;
using System.Windows.Forms;


namespace Fast_Clipboard_App
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();
            InitializeFile();        
        }

        public void InitializeFile()
        {

            if (File.Exists("result.txt"))
            {
                string[] itemsAdd = File.ReadAllLines("result.txt");
                listBox1.Items.Clear();
                listBox1.Items.AddRange(itemsAdd);

            }
            else File.Create("result.txt");
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                Clipboard.SetText(selectedItem);
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                TopMost = true;
            }else TopMost = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(executablePath, "result.txt");
           

            // ������ ���������� "�������" � ��������� ������
            Process.Start("notepad.exe", filePath);   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeFile();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WindowPositionX = this.Location.X;
            Properties.Settings.Default.WindowPositionY = this.Location.Y;
            Properties.Settings.Default.WindowWidth = this.Size.Width;
            Properties.Settings.Default.WindowHeight = this.Size.Height;

            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //base.OnLoad(e);

            this.Location = new Point(Properties.Settings.Default.WindowPositionX, Properties.Settings.Default.WindowPositionY);
            this.Size = new Size(Properties.Settings.Default.WindowWidth, Properties.Settings.Default.WindowHeight);
        }
    }
    
}