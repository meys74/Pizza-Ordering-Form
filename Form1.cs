using System.Windows.Forms;

namespace siparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int SiparisUcret = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbbxPizzaBoy.SelectedIndex = 0;
            cmbbxIcecek.SelectedIndex = 0;
        }

        private void lblIcecek_Click(object sender, EventArgs e)
        {

        }

        private void lblAdres_Click(object sender, EventArgs e)
        {

        }

        private void lblEkstra_Click(object sender, EventArgs e)
        {

        }

        private void btnSiparisAl_Click(object sender, EventArgs e)
        {
            lstbxAd.Items.Add(txtbxAd.Text);
            lstbxTel.Items.Add(txtbxTel.Text);
            lstbxAdres.Items.Add(txtbxAdres.Text);
            lstbxPizzaBoyveAdet.Items.Add($"{cmbbxPizzaBoy.SelectedItem} Boy | {numPizzaAdet.Value} Adet");
            lstbxIcecekveAdet.Items.Add($"{cmbbxIcecek.SelectedItem} | {numIcecekAdet.Value} Adet");

            string secilenMalzemeler = "";

            foreach (Control arac in grpbxEkstra.Controls)
            {

                if (arac is CheckBox && ((CheckBox)arac).Checked)
                {
                    secilenMalzemeler += arac.Text + " ";
                }
            }
            lstbxEkstra.Items.Add(secilenMalzemeler);

            switch (cmbbxPizzaBoy.SelectedIndex)
            {
                case 1:
                    SiparisUcret += 329 * (int)numPizzaAdet.Value;
                    break;
                case 2:
                    SiparisUcret += 389 * (int)numPizzaAdet.Value;
                    break;
                case 3:
                    SiparisUcret += 449 * (int)numPizzaAdet.Value;
                    break;
            }

            switch (cmbbxIcecek.SelectedIndex)
            {
                case 1:
                    SiparisUcret += 10 * (int)numIcecekAdet.Value;
                    break;
                case 2:
                    SiparisUcret += 40 * (int)numIcecekAdet.Value;
                    break;
                case 3:
                    SiparisUcret += 45 * (int)numIcecekAdet.Value;
                    break;
                case 4:
                    SiparisUcret += 45 * (int)numIcecekAdet.Value;
                    break;
                case 5:
                    SiparisUcret += 55 * (int)numIcecekAdet.Value;
                    break;
                case 6:
                    SiparisUcret += 55 * (int)numIcecekAdet.Value;
                    break;
                case 7:
                    SiparisUcret += 50 * (int)numIcecekAdet.Value;
                    break;
            }

            foreach (Control arac in grpbxEkstra.Controls)
            {

                if (arac is CheckBox && ((CheckBox)arac).Checked)
                {
                    SiparisUcret += 5;
                }
            }

            lstbxUcret.Items.Add(SiparisUcret + "TL");
        }

        private void cmbbxPizzaBoy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxPizzaBoy.SelectedIndex != 0)
            {
                numPizzaAdet.Value = 1;
            }
            else
            {
                numPizzaAdet.Value = 0;
            }

           
        }

        private void cmbbxIcecek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxIcecek.SelectedIndex != 0)
            {
                numIcecekAdet.Value = 1;
            }
            else
            {
                numIcecekAdet.Value = 0;
            }
        }

        private void chckbxSucuk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnHepsiniTemizle_Click(object sender, EventArgs e)
        {
            lstbxAd.Items.Clear();
            lstbxTel.Items.Clear();
            lstbxAdres.Items.Clear();
            lstbxPizzaBoyveAdet.Items.Clear();
            lstbxIcecekveAdet.Items.Clear();
            lstbxEkstra.Items.Clear();
            lstbxUcret.Items.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtbxAd.Clear();
            txtbxTel.Clear();
            txtbxAdres.Clear();
            cmbbxPizzaBoy.SelectedIndex = 0;
            cmbbxIcecek.SelectedIndex = 0;
            numPizzaAdet.Value = 0;
            numIcecekAdet.Value = 0;

            //bu donguyu diger clear ve sifirlama islemlerinde de kullanabiliriz ama boyle kalsin
            foreach (Control arac in grpbxEkstra.Controls)
            {

                if (arac is CheckBox && ((CheckBox)arac).Checked)
                {
                    ((CheckBox)arac).Checked = false;
                }
            }

            /*chckbxSucuk.Checked = false;
            chckbxKiyma.Checked = false;
            chckbxMantar.Checked = false;
            chckbxPeynir.Checked = false;
            chckbxZeytin.Checked = false;
            chckbxSosis.Checked = false;*/
        }

        private void numPizzaAdet_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
