﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulup klp=new FrmKulup();
            klp.Show();
        }

        private void BtnDers_Click(object sender, EventArgs e)
        {
            FrmDersler frm = new FrmDersler();
            frm.Show();
        }

        private void BtnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            FrmOgrenci frm= new FrmOgrenci();
            frm.Show();
        }

        private void BtnSinavNotlar_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar frm= new FrmSinavNotlar();
            frm.Show();
        }
    }
}
