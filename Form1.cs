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
            
            checkBox1.Text = " ������";
            checkBox2.Text = " �����";
            checkBox3.Text = " �����";
            checkBox4.Text = " �������";
            checkBox5.Text = " �� ����";
            checkBox6.Text = " �� �����";
            checkBox7.Text = " ��� ���������";
            checkBox8.Text = " ����� �����";
            checkBox9.Text = " ������ �����";
            checkBox10.Text = " ��� ������";
            checkBox11.Text = " ������������";
            checkBox12.Text = " ��������� �����";
            CheckChecked();
           
        }
        public  void CheckChecked() 
        {
        
          
              foreach (CheckBox item in flowLayoutPanel1.Controls)
              {
                  if (item.Text == Clipboard.GetText())
                  {
                      item.Checked = true;
                  }
                  else item.Checked = false;
              }
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            Clipboard.SetText(checkBox1.Text);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(checkBox2.Text);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(checkBox3.Text);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(checkBox4.Text);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(checkBox5.Text);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(checkBox6.Text);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(checkBox7.Text);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(checkBox8.Text);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(checkBox9.Text);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(checkBox10.Text);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(checkBox11.Text);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(checkBox12.Text);
        }
    }
}