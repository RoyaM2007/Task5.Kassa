namespace Task5.Kassa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Xanalar sıfırlansınmı?",
       "Bildiriş",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstCart.Items.Clear();
                txtPayment.Clear();
                txtTotal.Text = "0";
                lblChange.Text = "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPayment.Clear();
            lblChange.Text = "0";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Kofe - 3 AZN");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Burger - 6 AZN");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Basket - 8 AZN");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Hotdog - 5 AZN");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Pizza - 10 AZN");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Chicken - 7 AZN");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Cake - 4 AZN");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Lemonad - 3 AZN");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Drink - 2 AZN");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Tea - 2 AZN");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedIndex == -1)
            {
                MessageBox.Show("Zəhmət olmasa, səbətdən silmək üçün yemək seçin!");
                return;
            }

            string selectedFood = lstCart.SelectedItem.ToString();

            lstCart.Items.RemoveAt(lstCart.SelectedIndex);

            MessageBox.Show(selectedFood + " səbətdən silindi");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (lstCart.Items.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!");
                return;
            }

            double total = 0;

            foreach (string item in lstCart.Items)
            {
                string[] parts = item.Split('-');

                string priceText = parts[1].Replace("AZN", "").Trim();

                total += double.Parse(priceText);
            }

            txtTotal.Text = total.ToString("0.00") + " AZN";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtPayment.Text == "")
            {
                MessageBox.Show("Məbləği daxil edin!");
                return;
            }

            double total = double.Parse(txtTotal.Text.Replace("AZN", "").Trim());
            double payment = double.Parse(txtPayment.Text);

            if (payment < total)
            {
                MessageBox.Show("Daxil edilən məbləğ hesabdan azdır");
                return;
            }

            double change = payment - total;

            lblChange.Text = change.ToString("0.00");
        }
    }
}
