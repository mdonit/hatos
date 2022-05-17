using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VikingLotto0515Db;

namespace VikingLotto0515Szimulacio
{
    public partial class LottoTabla : Form
    {
        VikingContext db = new VikingContext();
        List<int> tippek = new List<int>();

        public LottoTabla()
        {
            InitializeComponent();
        }

        private void chkSzam_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;

            if (box.Checked)
            {
                tippek.Add(Convert.ToInt32(box.Text));

                if (tippek.Count() == 6)
                {
                    foreach (CheckBox item in tarolo.Controls)
                    {
                        if (!item.Checked)
                        {
                            item.Enabled = false;
                        }
                    }

                    btnSorsol.Enabled = true;
                }
            }
            else
            {
                tippek.Remove(Convert.ToInt32(box.Text));

                if (tippek.Count() == 5)
                {
                    foreach (CheckBox item in tarolo.Controls)
                    {
                        item.Enabled = true;
                    }

                    btnSorsol.Enabled = false;
                }
            }
        }

        private void btnSorsol_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            HashSet<int> szamHalmaz = new HashSet<int>();

            do
            {
                szamHalmaz.Add(rand.Next(1, 49));
            } while (szamHalmaz.Count() != 6);

            db.Huzasok.Add(new Huzas(string.Join(";", szamHalmaz)));
            db.SaveChanges();

            MessageBox.Show($"{szamHalmaz.Intersect(tippek).Count()} db találatod lett!");
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LottoTabla_Load(object sender, EventArgs e)
        {
            btnSorsol.Enabled = false;
            tarolo.Size = new Size(490, 370);

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    CheckBox box = new CheckBox();

                    box.AutoSize = true;
                    box.Location = new Point(j * 50 + 50, i * 50 + 50);
                    box.Text = (i * 8 + j + 1).ToString();
                    box.CheckedChanged += chkSzam_CheckedChanged;
                    tarolo.Controls.Add(box);
                }
            }
        }
    }
}
