using System.Windows.Forms;

namespace Fast_Clipboard_App
{
    public partial class Form1 : Form
    {
        //enum ResultCal
        //{
        //    бросил = 0, отказ, недозвон, сброс, автоотв, 
        //}
        public Form1()
        {
            InitializeComponent();
            string[] itemsAdd = { " бросил", " сброс", " отказ", " автоотв", " не брал"," не нужно", " нет страховки", " сроки вышли", " грубый отказ"," сам вернул", " непрофильный", " ошибочный номер" };
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
    }
}