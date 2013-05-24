namespace car
{
    partial class Type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Type));
            this.dataGridViewType = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.addTypeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveBrandtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteTypeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewType
            // 
            this.dataGridViewType.AllowUserToAddRows = false;
            this.dataGridViewType.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.number,
            this.name});
            this.dataGridViewType.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewType.Name = "dataGridViewType";
            this.dataGridViewType.Size = new System.Drawing.Size(399, 392);
            this.dataGridViewType.TabIndex = 0;
            this.dataGridViewType.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewType_CellMouseClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTypeToolStripButton,
            this.saveBrandtoolStripButton,
            this.deleteTypeToolStripButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(403, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // addTypeToolStripButton
            // 
            this.addTypeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTypeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addTypeToolStripButton.Image")));
            this.addTypeToolStripButton.Name = "addTypeToolStripButton";
            this.addTypeToolStripButton.RightToLeftAutoMirrorImage = true;
            this.addTypeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addTypeToolStripButton.Text = "Add new";
            this.addTypeToolStripButton.ToolTipText = "Додати";
            this.addTypeToolStripButton.Click += new System.EventHandler(this.addTypeToolStripButton_Click);
            // 
            // saveBrandtoolStripButton
            // 
            this.saveBrandtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBrandtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveBrandtoolStripButton.Image")));
            this.saveBrandtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBrandtoolStripButton.Name = "saveBrandtoolStripButton";
            this.saveBrandtoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveBrandtoolStripButton.Text = "&Save";
            this.saveBrandtoolStripButton.ToolTipText = "Зберегти";
            this.saveBrandtoolStripButton.Click += new System.EventHandler(this.saveBrandtoolStripButton_Click);
            // 
            // deleteTypeToolStripButton
            // 
            this.deleteTypeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTypeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteTypeToolStripButton.Image")));
            this.deleteTypeToolStripButton.Name = "deleteTypeToolStripButton";
            this.deleteTypeToolStripButton.RightToLeftAutoMirrorImage = true;
            this.deleteTypeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteTypeToolStripButton.Text = "Delete";
            this.deleteTypeToolStripButton.ToolTipText = "Видалити";
            this.deleteTypeToolStripButton.Click += new System.EventHandler(this.deleteTypeToolStripButton_Click);
            // 
            // id
            // 
            this.id.HeaderText = "№";
            this.id.Name = "id";
            this.id.Width = 55;
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
            this.name.Width = 300;
            // 
            // Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(403, 420);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridViewType);
            this.Name = "Type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тип кузова";
            this.Shown += new System.EventHandler(this.Type_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewType;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton addTypeToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteTypeToolStripButton;
        private System.Windows.Forms.ToolStripButton saveBrandtoolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}