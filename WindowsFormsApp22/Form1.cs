using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        double PayGasStation { get; set; } = 0;//сумма покупки топлива
        double PayCafe { get; set; } = 0;//сумма покупки в кафе
        double PayTotal { get; set; } = 0;//общая сумма
        double cHot, cHam, cCol, cFri = 0;//переменные для хранения кол-во товаров кафе
        double[] oil = { 25.50, 24.00, 30.50, 32.50, 18.80 };//цена топлива
        int tempTimer = 0;//итератор таймера
        public Form1()
        {
            InitializeComponent();
            this.Load += FormLoad;
        }
        private void FormLoad(object sender, EventArgs e)
        {
            comboBoxFuel.SelectedIndex = 0;//выбор определенного вида горючего
            textBoxFuelPrice.Text = $"{oil[0]}";//цена на данный вид продукта

            //переключение кнопок RadioButton
            radioButtonCount.CheckedChanged += RadioButtonCheckedChanged;
            radioButtonSum.CheckedChanged += RadioButtonCheckedChanged;

            //соб. выбора топлива
            comboBoxFuel.SelectedValueChanged += ComboBoxFuel_SelectedValueChanged;

            //соб. при входе на текстовое поле и выходе из него
            textBoxRadioCount.Enter += TextBox_Enter;
            textBoxRadioCount.Leave += TextBox_Leave;
            textBoxRadioSum.Enter += TextBox_Enter;
            textBoxRadioSum.Leave += TextBox_Leave;
            HotDogCount.Enter += TextBox_Enter;
            HotDogCount.Leave += TextBox_Leave;
            FrenchFriesCount.Enter += TextBox_Enter;
            FrenchFriesCount.Leave += TextBox_Leave;
            CokoColaCount.Enter += TextBox_Enter;
            CokoColaCount.Leave += TextBox_Leave;
            HamburgerCount.Enter += TextBox_Enter;
            HamburgerCount.Leave += TextBox_Leave;

            //соб. изменения значений в полях покупки топлива и подсчет суммы
            textBoxRadioCount.TextChanged += Radio_TextChanged;
            textBoxRadioSum.TextChanged += Radio_TextChanged;

            //соб. CheckBox-сов и изменение значений полей ReadOnly
            HotDogCheckBox.CheckedChanged += HotDogCheckBox_CheckedChanged;
            CokoColaCheckBox.CheckedChanged += CokoColaCheckBox_CheckedChanged;
            FrenchFriesCheckBox.CheckedChanged += FrenchFriesCheckBox_CheckedChanged;
            HamburgerCheckBox.CheckedChanged += HamburgerCheckBox_CheckedChanged;

            //соб. изменения значений в полях покупки товаров в кафе и подсчет суммы
            HamburgerCount.TextChanged += HamburgerCount_TextChanged;
            HotDogCount.TextChanged += HotDogCount_TextChanged;
            CokoColaCount.TextChanged += CokoColaCount_TextChanged;
            FrenchFriesCount.TextChanged += FrenchFriesCount_TextChanged;

            //соб. проверка на изменения значения вывода основной суммы
            toPayCafe.TextChanged += ToPayCafe_TextChanged;

            //соб. на нажатую кнопку рассчитать
            toCount.Click += ToCount_Click;

            //соб. начало работы таймера
            timer.Tick += Timer_Tick;

            this.FormClosing += Form1_FormClosing;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PayTotal == 0)
            {
                MessageBox.Show($"Продаж нет!", "Завершение программы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Общие продажи за {DateTime.Now.ToShortDateString()} = {Math.Round(PayTotal, 2)} грн.", "Завершение программы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer s = sender as Timer;
            tempTimer++;
            if (tempTimer == 10)
            {
                DialogResult result = MessageBox.Show("Завершить работу с этим клиентом?", "Очистить форму?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    PayTotal += PayGasStation + PayCafe;
                    timer.Stop();
                    Text = $"BestOil Общие продажи за {DateTime.Now.ToShortDateString()} = {Math.Round(PayTotal, 2)} грн.";
                    CokoColaCheckBox.Checked = false;
                    HamburgerCheckBox.Checked = false;
                    HotDogCheckBox.Checked = false;
                    FrenchFriesCheckBox.Checked = false;
                    comboBoxFuel.SelectedIndex = 0;
                    radioButtonCount.Checked = true;
                    textBoxRadioCount.Text = "0,00";
                    tempTimer = 0;
                    toPayTotal.Text = "0,00";
                }
                else
                {
                    tempTimer = 0;
                }
            }
        }

        private void ToPayCafe_TextChanged(object sender, EventArgs e)
        {
            if (toPayCafe.Text == "0")
            {
                toPayCafe.Text = "0,00";
            }
        }
        private void HamburgerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HamburgerCheckBox.Checked)
            {
                HamburgerCount.ReadOnly = false;
                HamburgerCount.Focus();
            }
            else
            {

                PayCafe -= (double.Parse(HamburgerPrice.Text) * cHam);
                cHam = 0;
                HamburgerCount.ReadOnly = true;
                HamburgerCount.Text = "0,00";
                toPayCafe.Text = Math.Round(PayCafe, 2).ToString();
            }

        }
        private void FrenchFriesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FrenchFriesCheckBox.Checked)
            {
                FrenchFriesCount.ReadOnly = false;
                FrenchFriesCount.Focus();
            }
            else
            {

                PayCafe -= (double.Parse(FrenchFriesPrice.Text) * cFri);
                cFri = 0;
                FrenchFriesCount.ReadOnly = true;
                FrenchFriesCount.Text = "0,00";
                toPayCafe.Text = Math.Round(PayCafe, 2).ToString();

            }
        }

        private void CokoColaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CokoColaCheckBox.Checked)
            {
                CokoColaCount.ReadOnly = false;
                CokoColaCount.Focus();
            }
            else
            {
                PayCafe -= (double.Parse(CokoColaPrice.Text) * cCol);
                cCol = 0;
                CokoColaCount.ReadOnly = true;
                CokoColaCount.Text = "0,00";

                toPayCafe.Text = Math.Round(PayCafe, 2).ToString();
            }
        }
    }
}
