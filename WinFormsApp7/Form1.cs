using WindowsApp7.ModelDanych;
using WinFormsApp7.ModelDanych;

namespace WinFormsApp7
{
    public partial class Form1 : Form

    {
        Pobieracz pobieracz;
        public Form1()
        {
            InitializeComponent();
            pobieracz = new Pobieracz();
            pobieracz.PobierzDanezBazy();
        }
        public void PokazDane()
        {
            richTextBox1.Clear();
            foreach (Osoba osoba in pobieracz.listaOsob)
                richTextBox1.Text += osoba.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pobieracz.listaOsob.Sort();
            PokazDane();
        }
    }
}