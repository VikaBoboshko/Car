namespace car
{
    partial class ViewModels
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewModels));
            this.dataGridViewModels = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_baseProperties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V_motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.norma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pruvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingNavigatorAddress = new System.Windows.Forms.BindingNavigator(this.components);
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.checkBoxDZ = new System.Windows.Forms.CheckBox();
            this.checkBoxE = new System.Windows.Forms.CheckBox();
            this.checkBoxSP = new System.Windows.Forms.CheckBox();
            this.checkBoxCZ = new System.Windows.Forms.CheckBox();
            this.checkBoxPF = new System.Windows.Forms.CheckBox();
            this.checkBoxPC = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxPPS = new System.Windows.Forms.CheckBox();
            this.checkBoxPZS = new System.Windows.Forms.CheckBox();
            this.groupBoxComplex = new System.Windows.Forms.GroupBox();
            this.textBoxSizeS = new System.Windows.Forms.TextBox();
            this.textBoxVB = new System.Windows.Forms.TextBox();
            this.textBoxZT = new System.Windows.Forms.TextBox();
            this.textBoxGasCombi = new System.Windows.Forms.TextBox();
            this.textBoxKliners = new System.Windows.Forms.TextBox();
            this.textBoxSizeCar = new System.Windows.Forms.TextBox();
            this.textBoxPT = new System.Windows.Forms.TextBox();
            this.textBoxPP = new System.Windows.Forms.TextBox();
            this.textBoxZP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGasCity = new System.Windows.Forms.TextBox();
            this.textBoxGasRoad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxVBag = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxYears = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAddress)).BeginInit();
            this.bindingNavigatorAddress.SuspendLayout();
            this.groupBoxComplex.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewModels
            // 
            this.dataGridViewModels.AllowUserToAddRows = false;
            this.dataGridViewModels.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.id_model,
            this.id_type,
            this.id_color,
            this.name,
            this.id_baseProperties,
            this.gas,
            this.V_motor,
            this.zul,
            this.norma,
            this.box,
            this.pruvid});
            this.dataGridViewModels.Location = new System.Drawing.Point(186, 28);
            this.dataGridViewModels.Name = "dataGridViewModels";
            this.dataGridViewModels.ReadOnly = true;
            this.dataGridViewModels.Size = new System.Drawing.Size(883, 401);
            this.dataGridViewModels.TabIndex = 0;
            this.dataGridViewModels.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewModels_CellMouseClick);
            // 
            // number
            // 
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 50;
            // 
            // id_model
            // 
            this.id_model.HeaderText = "model";
            this.id_model.Name = "id_model";
            this.id_model.ReadOnly = true;
            this.id_model.Visible = false;
            // 
            // id_type
            // 
            this.id_type.HeaderText = "type";
            this.id_type.Name = "id_type";
            this.id_type.ReadOnly = true;
            this.id_type.Visible = false;
            // 
            // id_color
            // 
            this.id_color.HeaderText = "color";
            this.id_color.Name = "id_color";
            this.id_color.ReadOnly = true;
            this.id_color.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Назва моделі";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // id_baseProperties
            // 
            this.id_baseProperties.HeaderText = "baseProperties";
            this.id_baseProperties.Name = "id_baseProperties";
            this.id_baseProperties.ReadOnly = true;
            this.id_baseProperties.Visible = false;
            // 
            // gas
            // 
            this.gas.HeaderText = "Тип двигуна";
            this.gas.Name = "gas";
            this.gas.ReadOnly = true;
            // 
            // V_motor
            // 
            this.V_motor.HeaderText = "Об\'єм двигуна";
            this.V_motor.Name = "V_motor";
            this.V_motor.ReadOnly = true;
            // 
            // zul
            // 
            this.zul.HeaderText = "Кількість циліндрів";
            this.zul.Name = "zul";
            this.zul.ReadOnly = true;
            this.zul.Width = 70;
            // 
            // norma
            // 
            this.norma.HeaderText = "Норма токсичності";
            this.norma.Name = "norma";
            this.norma.ReadOnly = true;
            this.norma.Width = 70;
            // 
            // box
            // 
            this.box.HeaderText = "Коробка передач";
            this.box.Name = "box";
            this.box.ReadOnly = true;
            this.box.Width = 150;
            // 
            // pruvid
            // 
            this.pruvid.HeaderText = "Привід";
            this.pruvid.Name = "pruvid";
            this.pruvid.ReadOnly = true;
            this.pruvid.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Виберіть марку";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.BackColor = System.Drawing.Color.MintCream;
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(15, 51);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(132, 21);
            this.comboBoxBrand.TabIndex = 2;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Передня підвіска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Задня підвіска";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Передні тормоза:";
            // 
            // bindingNavigatorAddress
            // 
            this.bindingNavigatorAddress.AddNewItem = null;
            this.bindingNavigatorAddress.CountItem = null;
            this.bindingNavigatorAddress.DeleteItem = null;
            this.bindingNavigatorAddress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.deleteToolStripButton});
            this.bindingNavigatorAddress.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorAddress.MoveFirstItem = null;
            this.bindingNavigatorAddress.MoveLastItem = null;
            this.bindingNavigatorAddress.MoveNextItem = null;
            this.bindingNavigatorAddress.MovePreviousItem = null;
            this.bindingNavigatorAddress.Name = "bindingNavigatorAddress";
            this.bindingNavigatorAddress.PositionItem = null;
            this.bindingNavigatorAddress.Size = new System.Drawing.Size(1073, 25);
            this.bindingNavigatorAddress.TabIndex = 7;
            this.bindingNavigatorAddress.Text = "bindingNavigator2";
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditToolStripButton.Image = global::car.Properties.Resources._1_2699;
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.EditToolStripButton.Text = "Редагувати";
            this.EditToolStripButton.ToolTipText = "Редагувати";
            this.EditToolStripButton.Click += new System.EventHandler(this.EditToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.ToolTipText = "Зберегти";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.RightToLeftAutoMirrorImage = true;
            this.deleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.ToolTipText = "Видалити";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // checkBoxDZ
            // 
            this.checkBoxDZ.AutoSize = true;
            this.checkBoxDZ.Checked = true;
            this.checkBoxDZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBoxDZ.Location = new System.Drawing.Point(15, 236);
            this.checkBoxDZ.Name = "checkBoxDZ";
            this.checkBoxDZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxDZ.Size = new System.Drawing.Size(104, 17);
            this.checkBoxDZ.TabIndex = 46;
            this.checkBoxDZ.Text = "Дитячий замок";
            this.checkBoxDZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDZ.UseVisualStyleBackColor = true;
            // 
            // checkBoxE
            // 
            this.checkBoxE.AutoSize = true;
            this.checkBoxE.Checked = true;
            this.checkBoxE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBoxE.Location = new System.Drawing.Point(15, 132);
            this.checkBoxE.Name = "checkBoxE";
            this.checkBoxE.Size = new System.Drawing.Size(125, 17);
            this.checkBoxE.TabIndex = 42;
            this.checkBoxE.Text = "Електропідсилювач";
            this.checkBoxE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxE.UseVisualStyleBackColor = true;
            // 
            // checkBoxSP
            // 
            this.checkBoxSP.AutoSize = true;
            this.checkBoxSP.Checked = true;
            this.checkBoxSP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBoxSP.Location = new System.Drawing.Point(15, 54);
            this.checkBoxSP.Name = "checkBoxSP";
            this.checkBoxSP.Size = new System.Drawing.Size(150, 17);
            this.checkBoxSP.TabIndex = 45;
            this.checkBoxSP.Text = "Склопідйомник передній";
            this.checkBoxSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSP.UseVisualStyleBackColor = true;
            // 
            // checkBoxCZ
            // 
            this.checkBoxCZ.AutoSize = true;
            this.checkBoxCZ.Checked = true;
            this.checkBoxCZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBoxCZ.Location = new System.Drawing.Point(15, 28);
            this.checkBoxCZ.Name = "checkBoxCZ";
            this.checkBoxCZ.Size = new System.Drawing.Size(128, 17);
            this.checkBoxCZ.TabIndex = 38;
            this.checkBoxCZ.Text = "Центральний замок";
            this.checkBoxCZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxCZ.UseVisualStyleBackColor = true;
            // 
            // checkBoxPF
            // 
            this.checkBoxPF.AutoSize = true;
            this.checkBoxPF.Checked = true;
            this.checkBoxPF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBoxPF.Location = new System.Drawing.Point(15, 80);
            this.checkBoxPF.Name = "checkBoxPF";
            this.checkBoxPF.Size = new System.Drawing.Size(124, 17);
            this.checkBoxPF.TabIndex = 44;
            this.checkBoxPF.Text = "Протитуманні фари";
            this.checkBoxPF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPF.UseVisualStyleBackColor = true;
            // 
            // checkBoxPC
            // 
            this.checkBoxPC.AutoSize = true;
            this.checkBoxPC.Checked = true;
            this.checkBoxPC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBoxPC.Location = new System.Drawing.Point(15, 210);
            this.checkBoxPC.Name = "checkBoxPC";
            this.checkBoxPC.Size = new System.Drawing.Size(143, 17);
            this.checkBoxPC.TabIndex = 39;
            this.checkBoxPC.Text = "Маршрутний компютер";
            this.checkBoxPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPC.UseVisualStyleBackColor = true;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Checked = true;
            this.checkBoxC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBoxC.Location = new System.Drawing.Point(15, 106);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(89, 17);
            this.checkBoxC.TabIndex = 43;
            this.checkBoxC.Text = "Кондиціонер";
            this.checkBoxC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxC.UseVisualStyleBackColor = true;
            // 
            // checkBoxPPS
            // 
            this.checkBoxPPS.AutoSize = true;
            this.checkBoxPPS.Checked = true;
            this.checkBoxPPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBoxPPS.Location = new System.Drawing.Point(15, 184);
            this.checkBoxPPS.Name = "checkBoxPPS";
            this.checkBoxPPS.Size = new System.Drawing.Size(144, 17);
            this.checkBoxPPS.TabIndex = 40;
            this.checkBoxPPS.Text = "Підігрів передніг сидінь";
            this.checkBoxPPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPPS.UseVisualStyleBackColor = true;
            // 
            // checkBoxPZS
            // 
            this.checkBoxPZS.AutoSize = true;
            this.checkBoxPZS.Checked = true;
            this.checkBoxPZS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPZS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBoxPZS.Location = new System.Drawing.Point(15, 158);
            this.checkBoxPZS.Name = "checkBoxPZS";
            this.checkBoxPZS.Size = new System.Drawing.Size(140, 17);
            this.checkBoxPZS.TabIndex = 41;
            this.checkBoxPZS.Text = "Підігрів заднього скла";
            this.checkBoxPZS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPZS.UseVisualStyleBackColor = true;
            // 
            // groupBoxComplex
            // 
            this.groupBoxComplex.Controls.Add(this.checkBoxCZ);
            this.groupBoxComplex.Controls.Add(this.checkBoxDZ);
            this.groupBoxComplex.Controls.Add(this.checkBoxPZS);
            this.groupBoxComplex.Controls.Add(this.checkBoxE);
            this.groupBoxComplex.Controls.Add(this.checkBoxPPS);
            this.groupBoxComplex.Controls.Add(this.checkBoxSP);
            this.groupBoxComplex.Controls.Add(this.checkBoxC);
            this.groupBoxComplex.Controls.Add(this.checkBoxPC);
            this.groupBoxComplex.Controls.Add(this.checkBoxPF);
            this.groupBoxComplex.Enabled = false;
            this.groupBoxComplex.Location = new System.Drawing.Point(5, 166);
            this.groupBoxComplex.Name = "groupBoxComplex";
            this.groupBoxComplex.Size = new System.Drawing.Size(175, 263);
            this.groupBoxComplex.TabIndex = 47;
            this.groupBoxComplex.TabStop = false;
            this.groupBoxComplex.Text = "Комплектація";
            // 
            // textBoxSizeS
            // 
            this.textBoxSizeS.BackColor = System.Drawing.Color.MintCream;
            this.textBoxSizeS.Location = new System.Drawing.Point(902, 439);
            this.textBoxSizeS.Name = "textBoxSizeS";
            this.textBoxSizeS.ReadOnly = true;
            this.textBoxSizeS.Size = new System.Drawing.Size(100, 20);
            this.textBoxSizeS.TabIndex = 56;
            // 
            // textBoxVB
            // 
            this.textBoxVB.BackColor = System.Drawing.Color.MintCream;
            this.textBoxVB.Location = new System.Drawing.Point(695, 491);
            this.textBoxVB.Name = "textBoxVB";
            this.textBoxVB.ReadOnly = true;
            this.textBoxVB.Size = new System.Drawing.Size(100, 20);
            this.textBoxVB.TabIndex = 54;
            // 
            // textBoxZT
            // 
            this.textBoxZT.BackColor = System.Drawing.Color.MintCream;
            this.textBoxZT.Location = new System.Drawing.Point(116, 518);
            this.textBoxZT.Name = "textBoxZT";
            this.textBoxZT.ReadOnly = true;
            this.textBoxZT.Size = new System.Drawing.Size(100, 20);
            this.textBoxZT.TabIndex = 53;
            // 
            // textBoxGasCombi
            // 
            this.textBoxGasCombi.BackColor = System.Drawing.Color.MintCream;
            this.textBoxGasCombi.Location = new System.Drawing.Point(433, 492);
            this.textBoxGasCombi.Name = "textBoxGasCombi";
            this.textBoxGasCombi.ReadOnly = true;
            this.textBoxGasCombi.Size = new System.Drawing.Size(100, 20);
            this.textBoxGasCombi.TabIndex = 52;
            // 
            // textBoxKliners
            // 
            this.textBoxKliners.BackColor = System.Drawing.Color.MintCream;
            this.textBoxKliners.Location = new System.Drawing.Point(695, 465);
            this.textBoxKliners.Name = "textBoxKliners";
            this.textBoxKliners.ReadOnly = true;
            this.textBoxKliners.Size = new System.Drawing.Size(100, 20);
            this.textBoxKliners.TabIndex = 51;
            // 
            // textBoxSizeCar
            // 
            this.textBoxSizeCar.BackColor = System.Drawing.Color.MintCream;
            this.textBoxSizeCar.Location = new System.Drawing.Point(695, 439);
            this.textBoxSizeCar.Name = "textBoxSizeCar";
            this.textBoxSizeCar.ReadOnly = true;
            this.textBoxSizeCar.Size = new System.Drawing.Size(100, 20);
            this.textBoxSizeCar.TabIndex = 50;
            // 
            // textBoxPT
            // 
            this.textBoxPT.BackColor = System.Drawing.Color.MintCream;
            this.textBoxPT.Location = new System.Drawing.Point(116, 491);
            this.textBoxPT.Name = "textBoxPT";
            this.textBoxPT.ReadOnly = true;
            this.textBoxPT.Size = new System.Drawing.Size(100, 20);
            this.textBoxPT.TabIndex = 49;
            // 
            // textBoxPP
            // 
            this.textBoxPP.BackColor = System.Drawing.Color.MintCream;
            this.textBoxPP.Location = new System.Drawing.Point(116, 439);
            this.textBoxPP.Name = "textBoxPP";
            this.textBoxPP.ReadOnly = true;
            this.textBoxPP.Size = new System.Drawing.Size(100, 20);
            this.textBoxPP.TabIndex = 48;
            // 
            // textBoxZP
            // 
            this.textBoxZP.BackColor = System.Drawing.Color.MintCream;
            this.textBoxZP.Location = new System.Drawing.Point(116, 465);
            this.textBoxZP.Name = "textBoxZP";
            this.textBoxZP.ReadOnly = true;
            this.textBoxZP.Size = new System.Drawing.Size(100, 20);
            this.textBoxZP.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Задні тормоза:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Розхід в місті";
            // 
            // textBoxGasCity
            // 
            this.textBoxGasCity.BackColor = System.Drawing.Color.MintCream;
            this.textBoxGasCity.Location = new System.Drawing.Point(433, 439);
            this.textBoxGasCity.Name = "textBoxGasCity";
            this.textBoxGasCity.ReadOnly = true;
            this.textBoxGasCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxGasCity.TabIndex = 60;
            // 
            // textBoxGasRoad
            // 
            this.textBoxGasRoad.BackColor = System.Drawing.Color.MintCream;
            this.textBoxGasRoad.Location = new System.Drawing.Point(433, 465);
            this.textBoxGasRoad.Name = "textBoxGasRoad";
            this.textBoxGasRoad.ReadOnly = true;
            this.textBoxGasRoad.Size = new System.Drawing.Size(100, 20);
            this.textBoxGasRoad.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "За мыстом";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "За мыстом";
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.BackColor = System.Drawing.Color.MintCream;
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(433, 518);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.ReadOnly = true;
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxSpeed.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Максимальна швидкість";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(551, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Розміри";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(553, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Клінерс";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(553, 499);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 68;
            this.label12.Text = "Обєм бака";
            // 
            // textBoxVBag
            // 
            this.textBoxVBag.BackColor = System.Drawing.Color.MintCream;
            this.textBoxVBag.Location = new System.Drawing.Point(695, 518);
            this.textBoxVBag.Name = "textBoxVBag";
            this.textBoxVBag.ReadOnly = true;
            this.textBoxVBag.Size = new System.Drawing.Size(100, 20);
            this.textBoxVBag.TabIndex = 69;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(553, 521);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 70;
            this.label13.Text = "Обєм багажника";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(814, 446);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 71;
            this.label14.Text = "Розмір шин";
            // 
            // textBoxYears
            // 
            this.textBoxYears.BackColor = System.Drawing.Color.MintCream;
            this.textBoxYears.Location = new System.Drawing.Point(902, 465);
            this.textBoxYears.Name = "textBoxYears";
            this.textBoxYears.ReadOnly = true;
            this.textBoxYears.Size = new System.Drawing.Size(100, 20);
            this.textBoxYears.TabIndex = 72;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.MintCream;
            this.textBoxPrice.Location = new System.Drawing.Point(902, 491);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 73;
            // 
            // buttonClose
            // 
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(902, 520);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 23);
            this.buttonClose.TabIndex = 74;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(814, 472);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 75;
            this.label15.Text = "Рік випуску";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(814, 498);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 76;
            this.label16.Text = "Ціна";
            // 
            // ViewModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1073, 561);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxYears);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxVBag);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxGasRoad);
            this.Controls.Add(this.textBoxGasCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxZP);
            this.Controls.Add(this.textBoxSizeS);
            this.Controls.Add(this.textBoxVB);
            this.Controls.Add(this.textBoxZT);
            this.Controls.Add(this.textBoxGasCombi);
            this.Controls.Add(this.textBoxKliners);
            this.Controls.Add(this.textBoxSizeCar);
            this.Controls.Add(this.textBoxPT);
            this.Controls.Add(this.textBoxPP);
            this.Controls.Add(this.groupBoxComplex);
            this.Controls.Add(this.bindingNavigatorAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewModels);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "ViewModels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перегляд моделей";
            this.Load += new System.EventHandler(this.ViewModels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAddress)).EndInit();
            this.bindingNavigatorAddress.ResumeLayout(false);
            this.bindingNavigatorAddress.PerformLayout();
            this.groupBoxComplex.ResumeLayout(false);
            this.groupBoxComplex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewModels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingNavigator bindingNavigatorAddress;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        public System.Windows.Forms.CheckBox checkBoxDZ;
        public System.Windows.Forms.CheckBox checkBoxE;
        public System.Windows.Forms.CheckBox checkBoxSP;
        public System.Windows.Forms.CheckBox checkBoxCZ;
        public System.Windows.Forms.CheckBox checkBoxPF;
        public System.Windows.Forms.CheckBox checkBoxPC;
        public System.Windows.Forms.CheckBox checkBoxC;
        public System.Windows.Forms.CheckBox checkBoxPPS;
        public System.Windows.Forms.CheckBox checkBoxPZS;
        private System.Windows.Forms.GroupBox groupBoxComplex;
        public System.Windows.Forms.TextBox textBoxSizeS;
        public System.Windows.Forms.TextBox textBoxVB;
        public System.Windows.Forms.TextBox textBoxZT;
        public System.Windows.Forms.TextBox textBoxGasCombi;
        public System.Windows.Forms.TextBox textBoxKliners;
        public System.Windows.Forms.TextBox textBoxSizeCar;
        public System.Windows.Forms.TextBox textBoxPT;
        public System.Windows.Forms.TextBox textBoxZP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxGasCity;
        public System.Windows.Forms.TextBox textBoxGasRoad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox textBoxVBag;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxYears;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxPP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_baseProperties;
        private System.Windows.Forms.DataGridViewTextBoxColumn gas;
        private System.Windows.Forms.DataGridViewTextBoxColumn V_motor;
        private System.Windows.Forms.DataGridViewTextBoxColumn zul;
        private System.Windows.Forms.DataGridViewTextBoxColumn norma;
        private System.Windows.Forms.DataGridViewTextBoxColumn box;
        private System.Windows.Forms.DataGridViewTextBoxColumn pruvid;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
    }
}