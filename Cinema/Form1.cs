using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Oturacaq> oturacaqList { get; set; }
        public List<Button> buttons { get; set; }
        public List<ReservedButton> reservedList { get; set; }
        int countRow = 1;
        public int findRow { get; set; }

        public int findPrice { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            oturacaqList = new List<Oturacaq>();
            buttons = new List<Button>();
            reservedList = new List<ReservedButton>();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            while (countRow > 0)
            {
                for (int k = 1; k <= 36; k++)
                {
                    Oturacaq YeniOturacaq = new Oturacaq();
                    //YeniOturacaq.ID = k;
                    //YeniOturacaq.Name = ("A" + k).ToString();
                    //YeniOturacaq.Row = k;
                    //YeniOturacaq.Column = countRow;
                    //YeniOturacaq.Price = "50AZN";
                    oturacaqList.Add(YeniOturacaq);
                }
                var left = 1;
                for (var i = 1; i <= oturacaqList.Count(); i++)
                {
                    Button button = new Button();
                    button.Text = i.ToString();
                    button.Top = 20;
                    button.BackColor = Color.Gray;
                    button.Name = ("BtnTest" + i).ToString();
                    button.Width = 60;
                    button.Height = 60;
                    button.Left = left += (10 + button.Width);
                    flowLayoutPanel1.Controls.Add(button);
                    buttons.Add(button);
                    button.Click += Yeni;
                }
                countRow--;
            }
        }
        private void Yeni(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.Gray)
            {
                button.BackColor = Color.Red;
            }
            else if (button.BackColor == Color.Red)
            {
                button.BackColor = Color.Gray;
            }
        }
        private void btnReserve_Click(object sender, EventArgs e)
        {
            for (int o = 0; o < buttons.Count(); o++)
            {
                if ((buttons[o].BackColor == Color.Red) && (buttons[o].Enabled == true))
                {
                    ReservedButton reserved = new ReservedButton();
                    reserved.Nomre = (o + 1);
                    reserved.Yer = (o + 1);
                    if (axsam.Checked)
                    {
                        btnClean.Visible = true;
                        buttons[o].Enabled = false;
                        reserved.Seans = "Axsham";
                        if ((o + 1) < 10)
                        {
                            reserved.Sira = 4;
                            reserved.Qiymet = 7;
                        }
                        else if ((o + 1) > 9 && (o + 1) < 19)
                        {
                            reserved.Sira = 3;
                            reserved.Qiymet = 12;
                        }
                        else if ((o + 1) > 18 && (o + 1) < 28)
                        {
                            reserved.Sira = 2;
                            reserved.Qiymet = 18;
                        }
                        else if ((o + 1) > 27 && (o + 1) < 37)
                        {
                            reserved.Sira = 1;
                            reserved.Qiymet = 20;
                        }
                        reservedList.Add(reserved);
                        info();
                    }
                    else if (Gunuz.Checked)
                    {
                        buttons[o].Enabled = false;
                        btnClean.Visible = true;
                        reserved.Seans = "Gunuz";
                        if ((o + 1) < 10)
                        {
                            reserved.Sira = 4;
                            reserved.Qiymet = 5;
                        }
                        else if ((o + 1) > 9 && (o + 1) < 19)
                        {
                            reserved.Sira = 3;
                            reserved.Qiymet = 6;
                        }
                        else if ((o + 1) > 18 && (o + 1) < 28)
                        {
                            reserved.Sira = 2;
                            reserved.Qiymet = 8;
                        }
                        else if ((o + 1) > 27 && (o + 1) < 37)
                        {
                            reserved.Sira = 1;
                            reserved.Qiymet = 10;
                        }
                        reservedList.Add(reserved);
                        info();
                    }
                    else
                    {
                        MessageBox.Show("Seans-i Shechin!!!");
                    }
                }
            }
        }
        private void dataGridViewSelected_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            findRow = Convert.ToInt32(dataGridViewSelected.Rows[e.RowIndex].Cells[1].Value);
            findPrice = Convert.ToInt32(dataGridViewSelected.Rows[e.RowIndex].Cells[3].Value); //istifade etmedim(
            var selectedRow = reservedList.Where(w => w.Yer == findRow).FirstOrDefault();
            
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            var selectedRow = reservedList.FirstOrDefault(f => f.Yer == findRow);
            for (int i = 0; i < buttons.Count(); i++)
            {
                if (buttons[i].Text == findRow.ToString())
                {
                    buttons[i].Enabled = true;
                    buttons[i].BackColor = Color.Gray;
                }
            }

            reservedList.Remove(selectedRow);
            info();
        }
        public void info()
        {
            dataGridViewSelected.DataSource = null;
            dataGridViewSelected.DataSource = reservedList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int TotalPrice = 0;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < reservedList.Count(); i++)
            {
                TotalPrice += reservedList[i].Qiymet;
            }
            tbxTtoalPrice.Text = (TotalPrice+" "+ "AZN").ToString();
        }

        
    }
}
