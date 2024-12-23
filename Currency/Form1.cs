using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;  //XML okuyucu

namespace Currency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblkur.Visible = false;
            lblsonuc.Visible = false;
            comboKur.DropDownStyle = ComboBoxStyle.DropDownList;  //combobox kapalı
        }


        private void butonCevir_Click(object sender, EventArgs e)
        {
            string excelDosyaYolu = " ";//Kur excelin dosya yolu

            using (var paket = new ExcelPackage(new FileInfo(excelDosyaYolu)))
            {
                ExcelWorksheet sayfa = paket.Workbook.Worksheets[0];

                decimal miktar;
                if (!decimal.TryParse(txtMiktar.Text, out miktar))
                {
                    MessageBox.Show("Lütfen geçerli bir miktar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string kuradi;
                decimal kur;
                if (comboKur.SelectedIndex == 0)
                {
                    kur = Convert.ToDecimal(sayfa.Cells["A3"].Value); // USD
                    kuradi = "USD";
                }
                else
                {
                    kur = Convert.ToDecimal(sayfa.Cells["B3"].Value); // Euro
                    kuradi = "Euro";
                }
                lblkur.Visible = true;
                lblsonuc.Visible=true; 
                decimal sonuc = miktar * kur;

                lblkur.Text = $"{kuradi} Kuru: {kur}";
                lblsonuc.Text = $"{sonuc} TL'dir.";
            }
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Enterle
                butonCevir.PerformClick(); // Enter ile butonu aktifleştir
            }
        }

       //Emre Eser Karacabey saygılarımla...
    }
}
