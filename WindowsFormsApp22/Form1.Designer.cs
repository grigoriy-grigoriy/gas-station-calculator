
namespace WindowsFormsApp22
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.toCount = new System.Windows.Forms.Button();
            this.HotDogCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButtonSum = new System.Windows.Forms.RadioButton();
            this.radioButtonCount = new System.Windows.Forms.RadioButton();
            this.textBoxRadioCount = new System.Windows.Forms.TextBox();
            this.textBoxRadioSum = new System.Windows.Forms.TextBox();
            this.textBoxFuelPrice = new System.Windows.Forms.TextBox();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.groupBoxFuel = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toPayGasStation = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CokoColaCount = new System.Windows.Forms.TextBox();
            this.CokoColaPrice = new System.Windows.Forms.TextBox();
            this.FrenchFriesCount = new System.Windows.Forms.TextBox();
            this.FrenchFriesPrice = new System.Windows.Forms.TextBox();
            this.HamburgerCount = new System.Windows.Forms.TextBox();
            this.HamburgerPrice = new System.Windows.Forms.TextBox();
            this.HotDogCount = new System.Windows.Forms.TextBox();
            this.HotDogPrice = new System.Windows.Forms.TextBox();
            this.CokoColaCheckBox = new System.Windows.Forms.CheckBox();
            this.FrenchFriesCheckBox = new System.Windows.Forms.CheckBox();
            this.HamburgerCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toPayCafe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.toPayTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBoxFuel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 

            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цена";
            // 

            this.toCount.ForeColor = System.Drawing.Color.Black;
            this.toCount.Location = new System.Drawing.Point(72, 24);
            this.toCount.Name = "toCount";
            this.toCount.Size = new System.Drawing.Size(148, 60);
            this.toCount.TabIndex = 1;
            this.toCount.Text = "Рассчитать";
            this.toCount.UseVisualStyleBackColor = true;
            // 

            this.HotDogCheckBox.AutoSize = true;
            this.HotDogCheckBox.ForeColor = System.Drawing.Color.Black;
            this.HotDogCheckBox.Location = new System.Drawing.Point(6, 37);
            this.HotDogCheckBox.Name = "HotDogCheckBox";
            this.HotDogCheckBox.Size = new System.Drawing.Size(64, 17);
            this.HotDogCheckBox.TabIndex = 2;
            this.HotDogCheckBox.Text = "Хот-дог";
            this.HotDogCheckBox.UseVisualStyleBackColor = true;
            // 
        }

        #endregion
    }
}

