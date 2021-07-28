using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsiteMailScraping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            foreach (var adresler in txtAdresler.Lines)
            {
                islemYap(adresler);
            }
        }
        private async void islemYap(string adres)
        {
            var kaynak = new MemoryStream();
            var webReq = (HttpWebRequest)WebRequest.Create(adres);
            using (var resp = await webReq.GetResponseAsync())
            {
                using (Stream respStream = resp.GetResponseStream())
                    await respStream.CopyToAsync(kaynak);
            }

            Regex mailDeseni = new Regex("[\\w-]+(?:\\.[\\w-]+)*@(?:[\\w-]+\\.)+[a-zA-Z]{2,7}");

            foreach (Match isim in mailDeseni.Matches(Encoding.ASCII.GetString(kaynak.ToArray()))) lbxAdresler.Items.Add(isim.Value);
        }
    }
}
