using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuffixValueConvertTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uint us = 200u;
            float f = 1.0f;
            long l = (long)1.3;
            ulong uLong = 100LU;
            double d = 2.5;
            decimal dm = 10m;

            textBox3.Text = SuffixValueConverter.ToSuffixValue<uint>(us, SuffixValueConverter.SuffixType.u) + "\r\n" +
                            SuffixValueConverter.ToSuffixValue<float>(f, SuffixValueConverter.SuffixType.f) + "\r\n" +
                            SuffixValueConverter.ToSuffixValue<long>(l, SuffixValueConverter.SuffixType.l) + "\r\n" +
                            SuffixValueConverter.ToSuffixValue<ulong>(uLong, SuffixValueConverter.SuffixType.LU) + "\r\n" +
                            SuffixValueConverter.ToSuffixValue<double>(d, SuffixValueConverter.SuffixType.d) + "\r\n" +
                            SuffixValueConverter.ToSuffixValue<decimal>(dm, SuffixValueConverter.SuffixType.m);
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            if (InputSuffixValueTXT.Text.Contains("U")) OutputValueTXT.Text = SuffixValueConverter.ToValue<uint>(InputSuffixValueTXT.Text).ToString();
            else if (InputSuffixValueTXT.Text.Contains("u")) OutputValueTXT.Text = SuffixValueConverter.ToValue<uint>(InputSuffixValueTXT.Text).ToString();
            else if (InputSuffixValueTXT.Text.Contains("F")) OutputValueTXT.Text = SuffixValueConverter.ToValue<float>(InputSuffixValueTXT.Text).ToString();
            else if (InputSuffixValueTXT.Text.Contains("f")) OutputValueTXT.Text = SuffixValueConverter.ToValue<float>(InputSuffixValueTXT.Text).ToString();
            else if (InputSuffixValueTXT.Text.Contains("L")) OutputValueTXT.Text = SuffixValueConverter.ToValue<long>(InputSuffixValueTXT.Text).ToString();
            else if (InputSuffixValueTXT.Text.Contains("l")) OutputValueTXT.Text = SuffixValueConverter.ToValue<long>(InputSuffixValueTXT.Text).ToString();
            else if (InputSuffixValueTXT.Text.Contains("UL")) OutputValueTXT.Text = SuffixValueConverter.ToValue<ulong>(InputSuffixValueTXT.Text).ToString();
            else if (InputSuffixValueTXT.Text.Contains("ul")) OutputValueTXT.Text = SuffixValueConverter.ToValue<ulong>(InputSuffixValueTXT.Text).ToString();
            else if (InputSuffixValueTXT.Text.Contains("LU")) OutputValueTXT.Text = SuffixValueConverter.ToValue<ulong>(InputSuffixValueTXT.Text).ToString();
            else if (InputSuffixValueTXT.Text.Contains("lu")) OutputValueTXT.Text = SuffixValueConverter.ToValue<ulong>(InputSuffixValueTXT.Text).ToString();
            else if (InputSuffixValueTXT.Text.Contains("D")) OutputValueTXT.Text = SuffixValueConverter.ToValue<double>(InputSuffixValueTXT.Text).ToString();
            else if (InputSuffixValueTXT.Text.Contains("d")) OutputValueTXT.Text = SuffixValueConverter.ToValue<double>(InputSuffixValueTXT.Text).ToString();
            else if (InputSuffixValueTXT.Text.Contains("M")) OutputValueTXT.Text = SuffixValueConverter.ToValue<decimal>(InputSuffixValueTXT.Text).ToString();
            else if (InputSuffixValueTXT.Text.Contains("m")) OutputValueTXT.Text = SuffixValueConverter.ToValue<decimal>(InputSuffixValueTXT.Text).ToString();
            else MessageBox.Show("Unknown value");

        }
    }
}
