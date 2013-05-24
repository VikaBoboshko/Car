namespace car
{
    partial class Model
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Model));
            this.dataGridViewModel = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorModel = new System.Windows.Forms.BindingNavigator(this.components);
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveModelsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewMaker = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.addBrandToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveBrandtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteBrandToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteModelToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorModel)).BeginInit();
            this.bindingNavigatorModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewModel
            // 
            this.dataGridViewModel.AllowUserToAddRows = false;
            this.dataGridViewModel.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.number1,
            this.name});
            this.dataGridViewModel.Location = new System.Drawing.Point(423, 32);
            this.dataGridViewModel.Name = "dataGridViewModel";
            this.dataGridViewModel.Size = new System.Drawing.Size(400, 410);
            this.dataGridViewModel.TabIndex = 0;
            this.dataGridViewModel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModel_CellContentClick);
            this.dataGridViewModel.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewModel_CellMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "№";
            this.id.Name = "id";
            this.id.Width = 55;
            // 
            // number1
            // 
            this.number1.HeaderText = "namber";
            this.number1.Name = "number1";
            this.number1.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Назва";
            this.name.Name = "name";
            this.name.Width = 300;
            // 
            // bindingNavigatorModel
            // 
            this.bindingNavigatorModel.AddNewItem = null;
            this.bindingNavigatorModel.CountItem = null;
            this.bindingNavigatorModel.DeleteItem = null;
            this.bindingNavigatorModel.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorModel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.saveModelsToolStripButton,
            this.toolStripSeparator,
            this.deleteModelToolStripButton});
            this.bindingNavigatorModel.Location = new System.Drawing.Point(423, 1);
            this.bindingNavigatorModel.MoveFirstItem = null;
            this.bindingNavigatorModel.MoveLastItem = null;
            this.bindingNavigatorModel.MoveNextItem = null;
            this.bindingNavigatorModel.MovePreviousItem = null;
            this.bindingNavigatorModel.Name = "bindingNavigatorModel";
            this.bindingNavigatorModel.PositionItem = null;
            this.bindingNavigatorModel.Size = new System.Drawing.Size(87, 25);
            this.bindingNavigatorModel.TabIndex = 2;
            this.bindingNavigatorModel.Text = "bindingNavigator2";
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.RightToLeftAutoMirrorImage = true;
            this.addToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addToolStripButton.Text = "Add new";
            this.addToolStripButton.ToolTipText = "Додати";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButton_Click);
            // 
            // saveModelsToolStripButton
            // 
            this.saveModelsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveModelsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveModelsToolStripButton.Image")));
            this.saveModelsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveModelsToolStripButton.Name = "saveModelsToolStripButton";
            this.saveModelsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveModelsToolStripButton.Text = "&Save";
            this.saveModelsToolStripButton.ToolTipText = "Зберегти";
            this.saveModelsToolStripButton.Click += new System.EventHandler(this.saveModelsToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridViewMaker
            // 
            this.dataGridViewMaker.AllowUserToAddRows = false;
            this.dataGridViewMaker.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewMaker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewMaker.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewMaker.Location = new System.Drawing.Point(6, 32);
            this.dataGridViewMaker.Name = "dataGridViewMaker";
            this.dataGridViewMaker.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMaker.Size = new System.Drawing.Size(400, 410);
            this.dataGridViewMaker.TabIndex = 3;
            this.dataGridViewMaker.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMaker_CellMouseClick);
            // 
            // number
            // 
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.Width = 55;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBrandToolStripButton,
            this.saveBrandtoolStripButton,
            this.toolStripSeparator4,
            this.deleteBrandToolStripButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(1, 1);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(87, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // addBrandToolStripButton
            // 
            this.addBrandToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addBrandToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addBrandToolStripButton.Image")));
            this.addBrandToolStripButton.Name = "addBrandToolStripButton";
            this.addBrandToolStripButton.RightToLeftAutoMirrorImage = true;
            this.addBrandToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addBrandToolStripButton.Text = "Add new";
            this.addBrandToolStripButton.ToolTipText = "Додати";
            this.addBrandToolStripButton.Click += new System.EventHandler(this.addBrandToolStripButton_Click);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteBrandToolStripButton
            // 
            this.deleteBrandToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteBrandToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteBrandToolStripButton.Image")));
            this.deleteBrandToolStripButton.Name = "deleteBrandToolStripButton";
            this.deleteBrandToolStripButton.RightToLeftAutoMirrorImage = true;
            this.deleteBrandToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteBrandToolStripButton.Text = "Delete";
            this.deleteBrandToolStripButton.ToolTipText = "Видалити";
            this.deleteBrandToolStripButton.Click += new System.EventHandler(this.deleteBrandToolStripButton_Click);
            // 
            // deleteModelToolStripButton
            // 
            this.deleteModelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteModelToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteModelToolStripButton.Image")));
            this.deleteModelToolStripButton.Name = "deleteModelToolStripButton";
            this.deleteModelToolStripButton.RightToLeftAutoMirrorImage = true;
            this.deleteModelToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteModelToolStripButton.Text = "Delete";
            this.deleteModelToolStripButton.ToolTipText = "Видалити";
            this.deleteModelToolStripButton.Click += new System.EventHandler(this.deleteModelToolStripButton_Click);
            // 
            // Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(825, 442);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridViewMaker);
            this.Controls.Add(this.bindingNavigatorModel);
            this.Controls.Add(this.dataGridViewModel);
            this.Name = "Model";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моделі";
            this.Load += new System.EventHandler(this.Model_Load);
            this.Shown += new System.EventHandler(this.Model_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorModel)).EndInit();
            this.bindingNavigatorModel.ResumeLayout(false);
            this.bindingNavigatorModel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewModel;
        private System.Windows.Forms.BindingNavigator bindingNavigatorModel;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripButton saveModelsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.DataGridView dataGridViewMaker;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton addBrandToolStripButton;
        private System.Windows.Forms.ToolStripButton saveBrandtoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton deleteBrandToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.ToolStripButton deleteModelToolStripButton;
    }
}