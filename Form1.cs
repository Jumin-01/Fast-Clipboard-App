using System.Windows.Forms;


namespace Fast_Clipboard_App
{
    public partial class Form1 : Form
    {
        //enum ResultCal
        //{
        //    ������ = 0, �����, ��������, �����, �������, 
        //}
        public Form1()
        {
            InitializeComponent();
            string[] itemsAdd = File.ReadAllLines("result.txt");
            //string[] itemsAdd = { " ������", " �����", " �����", " �������", " �� ����"," �� �����", " ��� ���������", " ����� �����", " ������ �����"," ��� ������", " ������������", " ��������� �����" };
            listBox1.Items.AddRange(itemsAdd);
            
           

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
    }
}