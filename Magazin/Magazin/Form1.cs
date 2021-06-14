using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
    public partial class magazin : Form
    {
        public magazin()
        {
            InitializeComponent();
        }

        int pret=0;

        void See()
        {
            foreach (Control Label in pnlMag.Controls.OfType<Label>()) 
            {
                if(Label.Visible == false)
                   Label.Show();
            }

            foreach (Control PictureBox in pnlMag.Controls.OfType<PictureBox>())
            {
                if (PictureBox.Visible == false)
                    PictureBox.Show();
            }

            foreach(Control Button in pnlMag.Controls.OfType<Button>())
            {
                if (Button.Visible == false)
                    Button.Show();
            }
        }

        private void picBx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblGenres_Click(object sender, EventArgs e)
        {
            ///Nothing because I'm lazy :)
        }

        private void lblAdv_Click(object sender, EventArgs e)
        {
            See();

            lbl1.Text = "Chyber Phunk";
            lbl2.Text = "Biomutant";
            lbl3.Text = "Rezident Evil";
            lbl4.Text = "Skyrim";
            lbl5.Text = "No man's sky";
            lbl6.Text = "Sekiro";

            btnBuy1.Enabled = true;
            btnBuy2.Enabled = true;
            btnBuy3.Enabled = true;
            btnBuy4.Enabled = true;
            btnBuy5.Enabled = true;
            btnBuy6.Enabled = true;

            pcBox1.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/CyberP.jpg"); 
            lblPret1.Text = "60$";

            pcBox2.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Bio.jpg"); 
            lblPret2.Text = "60$";

            pcBox3.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/RezEv.jpg"); 
            lblPret3.Text = "60$";

            pcBox4.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Sky.png"); 
            lblPret4.Text = "60$";

            pcBox5.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/NO.jpg");
            lblPret5.Text = "60$";

            pcBox6.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Sekiro.jpg");
            lblPret6.Text = "60$";

            pcBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox6.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void lblHorror_Click(object sender, EventArgs e)
        {
            See();

            lbl1.Text = "Phasmaphobia";
            lbl2.Text = "Outlast";
            lbl3.Text = "Amnesia";
            lbl4.Text = "Dead by daylight";
            lbl5.Text = "Little Nightmares";
            lbl6.Text = "Fnaf";

            btnBuy1.Enabled = true;
            btnBuy2.Enabled = true;
            btnBuy3.Enabled = true;
            btnBuy4.Enabled = true;
            btnBuy5.Enabled = true;
            btnBuy6.Enabled = true;

            pcBox1.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Horror/Ph.jpg");
            lblPret1.Text = "60$";

            pcBox2.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Horror/out.jpg"); 
            lblPret2.Text = "60$";

            pcBox3.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Horror/am.jpg"); 
            lblPret3.Text = "60$";

            pcBox4.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Horror/dbd.jpg"); 
            lblPret4.Text = "60$";

            pcBox5.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Horror/ln.png");
            lblPret5.Text = "60$";

            pcBox6.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Horror/fnaf.jpg");
            lblPret6.Text = "60$";

            pcBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lblSport_Click(object sender, EventArgs e)
        {
            See();

            pcBox1.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/CyberP.jpg"); ///price 60$
            lblPret1.Text = "60$";

            pcBox2.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Bio.jpg"); ///price 60$
            lblPret2.Text = "60$";

            pcBox3.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/RezEv.jpg"); ///price 80$
            lblPret3.Text = "80$";

            pcBox4.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Sky.png"); ///price 40$
            lblPret4.Text = "40$";

            pcBox5.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/NO.jpg"); ///price 55$
            lblPret5.Text = "55$";

            pcBox6.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Sekiro.jpg");
            lblPret6.Text = "60$";

            pcBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lblShooter_Click(object sender, EventArgs e)
        {
            See();

            pcBox1.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/CyberP.jpg"); ///price 60$
            lblPret1.Text = "60$";

            pcBox2.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Bio.jpg"); ///price 60$
            lblPret2.Text = "60$";

            pcBox3.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/RezEv.jpg"); ///price 80$
            lblPret3.Text = "80$";

            pcBox4.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Sky.png"); ///price 40$
            lblPret4.Text = "40$";

            pcBox5.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/NO.jpg"); ///price 55$
            lblPret5.Text = "55$";

            pcBox6.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Sekiro.jpg");
            lblPret6.Text = "60$";

            pcBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lblAutoChess_Click(object sender, EventArgs e)
        {
            See();

            btnBuy1.Enabled = true;
            btnBuy2.Enabled = true;
            btnBuy3.Enabled = true;
            btnBuy4.Enabled = true;
            btnBuy5.Enabled = true;
            btnBuy6.Enabled = true;

            pcBox1.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Autochess/CR.jpg");
            lblPret1.Text = "60$";

            pcBox2.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Autochess/k.jpg");
            lblPret2.Text = "60$";

            pcBox3.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Autochess/DU.jpg");
            lblPret3.Text = "60$";

            pcBox4.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Autochess/g.jpg"); 
            lblPret4.Text = "60$";

            pcBox5.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Autochess/ht.jpg");
            lblPret5.Text = "60$";

            pcBox6.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Autochess/tft.jpg");
            lblPret6.Text = "60$";

            pcBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lblTBT_Click(object sender, EventArgs e)
        {
            See();

            pcBox1.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/CyberP.jpg"); ///price 60$
            lblPret1.Text = "60$";

            pcBox2.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Bio.jpg"); ///price 60$
            lblPret2.Text = "60$";

            pcBox3.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/RezEv.jpg"); ///price 80$
            lblPret3.Text = "80$";

            pcBox4.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Sky.png"); ///price 40$
            lblPret4.Text = "40$";

            pcBox5.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/NO.jpg"); 
            lblPret5.Text = "55$";

            pcBox6.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Sekiro.jpg");
            lblPret6.Text = "60$";

            pcBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lblRacing_Click(object sender, EventArgs e)
        {
            See();

            pcBox1.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/CyberP.jpg");
            lblPret1.Text = "60$";

            pcBox2.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Bio.jpg"); 
            lblPret2.Text = "60$";

            pcBox3.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/RezEv.jpg");
            lblPret3.Text = "6$";

            pcBox4.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Sky.png"); 
            lblPret4.Text = "60$";

            pcBox5.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/NO.jpg"); 
            lblPret5.Text = "60$";

            pcBox6.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Sekiro.jpg");
            lblPret6.Text = "60$";

            pcBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lblTrivia_Click(object sender, EventArgs e)
        {
            See();

            pcBox1.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/CyberP.jpg");
            lblPret1.Text = "60$";

            pcBox2.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Bio.jpg"); 
            lblPret2.Text = "60$";

            pcBox3.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/RezEv.jpg"); 
            lblPret3.Text = "60$";

            pcBox4.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Sky.png"); 
            lblPret4.Text = "60$";

            pcBox5.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/NO.jpg"); 
            lblPret5.Text = "60$";

            pcBox6.Image = Image.FromFile("C:/Info/C#/Magazin/Magazin/bin/Debug/Poze/Adv/Sekiro.jpg");
            lblPret6.Text = "60$";

            pcBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void picBoxCos_Click(object sender, EventArgs e)
        {
            pnlCos.Size = new Size(476, 330);
            pnlCos.Location = new Point(46, 45);
            pnlCos.Visible = true;
            pnlMag.Visible = false;
        }

        private void magazin_Load(object sender, EventArgs e)
        {
            this.pnlMag.Location = new Point(12,12);
            this.pnlMag.Size = new Size(744,457);
        }

        private void pcBack_Click(object sender, EventArgs e)
        {
            pnlCos.Visible = false;
            pnlMag.Visible = true;
        }

        private void btnBuy1_Click(object sender, EventArgs e)
        {
            btnBuy1.Enabled = false;
            pret += 60;
            lstBoxProduse.Items.Add(lbl1.Text);
            lblPtotal.Text =pret.ToString() + "$";
        }

        private void btnBuy2_Click(object sender, EventArgs e)
        {
            btnBuy2.Enabled = false;
            btnBuy2.Enabled = false;
            pret += 60;
            lstBoxProduse.Items.Add(lbl2.Text);
            lblPtotal.Text = pret.ToString() + "$";
        }

        private void btnBuy3_Click(object sender, EventArgs e)
        {
            btnBuy3.Enabled = false;
            btnBuy3.Enabled = false;
            pret += 60;
            lstBoxProduse.Items.Add(lbl3.Text);
            lblPtotal.Text = pret.ToString() + "$";
        }

        private void btnBuy4_Click(object sender, EventArgs e)
        {
            btnBuy4.Enabled = false;
            btnBuy4.Enabled = false;
            pret += 60;
            lstBoxProduse.Items.Add(lbl4.Text);
            lblPtotal.Text = pret.ToString() + "$";
        }

        private void btnBuy5_Click(object sender, EventArgs e)
        {
            btnBuy5.Enabled = false;
            btnBuy5.Enabled = false;
            pret += 60;
            lstBoxProduse.Items.Add(lbl5.Text);
            lblPtotal.Text = pret.ToString() + "$";
        }

        private void btnBuy6_Click(object sender, EventArgs e)
        {
            btnBuy6.Enabled = false;
            btnBuy6.Enabled = false;
            pret += 60;
            lstBoxProduse.Items.Add(lbl6.Text);
            lblPtotal.Text = pret.ToString() + "$";
        }

        private void btnCumpara_Click(object sender, EventArgs e)
        {
            if(lstBoxProduse.Items.Count!=0)
                MessageBox.Show("Comanda inregistrata cu succes!");

            lstBoxProduse.Items.Clear();
            pret = 0;
            lblPtotal.Text = pret.ToString() + "$";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBoxProduse.Items.Clear();
            pret = 0;
            lblPtotal.Text = pret.ToString() + "$";
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection SO = new ListBox.SelectedObjectCollection(lstBoxProduse);
            if(lstBoxProduse.SelectedIndex!=-1)
            {
                for(int i=SO.Count-1;i>=0;i--)
                {
                    lstBoxProduse.Items.Remove(SO[i]);
                }
            }

            if(pret>0)
            {
                pret -= 60;
                lblPtotal.Text = pret.ToString() + "$";
            }
        }
    }
}
