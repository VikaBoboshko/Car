namespace car
{
    partial class Address
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Address));
            this.dataGridViewAddress = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddress = new System.Windows.Forms.BindingNavigator(this.components);
            this.addToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.EdittoolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeletetoolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAddress)).BeginInit();
            this.bindingNavigatorAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAddress
            // 
            this.dataGridViewAddress.AllowUserToAddRows = false;
            this.dataGridViewAddress.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.number,
            this.name,
            this.addressa,
            this.tel});
            this.dataGridViewAddress.Location = new System.Drawing.Point(1, 26);
            this.dataGridViewAddress.Name = "dataGridViewAddress";
            this.dataGridViewAddress.Size = new System.Drawing.Size(795, 450);
            this.dataGridViewAddress.TabIndex = 0;
            this.dataGridViewAddress.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAddress_CellMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "№";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // number
            // 
            this.number.HeaderText = "number";
            this.number.Name = "number";
            this.number.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Назва";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // addressa
            // 
            this.addressa.HeaderText = "Адреса";
            this.addressa.Name = "addressa";
            this.addressa.Width = 350;
            // 
            // tel
            // 
            this.tel.HeaderText = "Телефон";
            this.tel.Name = "tel";
            this.tel.Width = 150;
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.RightToLeftAutoMirrorImage = true;
            this.addToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addToolStripButton.Text = "Додати";
            this.addToolStripButton.ToolTipText = "Додати";
            //this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButton_Click);
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
            // 
            // bindingNavigatorAddress
            // 
            this.bindingNavigatorAddress.AddNewItem = null;
            this.bindingNavigatorAddress.CountItem = null;
            this.bindingNavigatorAddress.DeleteItem = null;
            this.bindingNavigatorAddress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton1,
            this.EdittoolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.DeletetoolStripButton4});
            this.bindingNavigatorAddress.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorAddress.MoveFirstItem = null;
            this.bindingNavigatorAddress.MoveLastItem = null;
            this.bindingNavigatorAddress.MoveNextItem = null;
            this.bindingNavigatorAddress.MovePreviousItem = null;
            this.bindingNavigatorAddress.Name = "bindingNavigatorAddress";
            this.bindingNavigatorAddress.PositionItem = null;
            this.bindingNavigatorAddress.Size = new System.Drawing.Size(798, 25);
            this.bindingNavigatorAddress.TabIndex = 3;
            this.bindingNavigatorAddress.Text = "bindingNavigator2";
            // 
            // addToolStripButton1
            // 
            this.addToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton1.Image")));
            this.addToolStripButton1.Name = "addToolStripButton1";
            this.addToolStripButton1.RightToLeftAutoMirrorImage = true;
            this.addToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.addToolStripButton1.Text = "Додати";
            this.addToolStripButton1.ToolTipText = "Додати";
            this.addToolStripButton1.Click += new System.EventHandler(this.addToolStripButton1_Click);
            // 
            // EdittoolStripButton2
            // 
            this.EdittoolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EdittoolStripButton2.Image = global::car.Properties.Resources._1_2699;
            this.EdittoolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EdittoolStripButton2.Name = "EdittoolStripButton2";
            this.EdittoolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.EdittoolStripButton2.Text = "Редагувати";
            this.EdittoolStripButton2.ToolTipText = "Редагувати";
            this.EdittoolStripButton2.Click += new System.EventHandler(this.EdittoolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "&Save";
            this.toolStripButton3.ToolTipText = "Зберегти";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // DeletetoolStripButton4
            // 
            this.DeletetoolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeletetoolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("DeletetoolStripButton4.Image")));
            this.DeletetoolStripButton4.Name = "DeletetoolStripButton4";
            this.DeletetoolStripButton4.RightToLeftAutoMirrorImage = true;
            this.DeletetoolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.DeletetoolStripButton4.Text = "Delete";
            this.DeletetoolStripButton4.ToolTipText = "Видалити";
            this.DeletetoolStripButton4.Click += new System.EventHandler(this.DeletetoolStripButton4_Click);
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 478);
            this.Controls.Add(this.bindingNavigatorAddress);
            this.Controls.Add(this.dataGridViewAddress);
            this.Name = "Address";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автосалони";
            this.Shown += new System.EventHandler(this.Address_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAddress)).EndInit();
            this.bindingNavigatorAddress.ResumeLayout(false);
            this.bindingNavigatorAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAddress;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.BindingNavigator bindingNavigatorAddress;
        private System.Windows.Forms.ToolStripButton addToolStripButton1;
        private System.Windows.Forms.ToolStripButton EdittoolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DeletetoolStripButton4;
    }
}