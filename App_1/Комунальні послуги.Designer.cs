namespace App_1
{
    partial class Form7
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
            System.Windows.Forms.Label назва_послугиLabel;
            System.Windows.Forms.Label цінаLabel;
            System.Windows.Forms.Label сплатити_доLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.servicesDataSet = new App_1.ServicesDataSet();
            this.listOfServices1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listOfServices1TableAdapter = new App_1.ServicesDataSetTableAdapters.ListOfServices1TableAdapter();
            this.tableAdapterManager = new App_1.ServicesDataSetTableAdapters.TableAdapterManager();
            this.назва_послугиTextBox = new System.Windows.Forms.TextBox();
            this.цінаTextBox = new System.Windows.Forms.TextBox();
            this.сплатити_доDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.listOfServices1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            назва_послугиLabel = new System.Windows.Forms.Label();
            цінаLabel = new System.Windows.Forms.Label();
            сплатити_доLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfServices1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfServices1BindingNavigator)).BeginInit();
            this.listOfServices1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // назва_послугиLabel
            // 
            назва_послугиLabel.AutoSize = true;
            назва_послугиLabel.Location = new System.Drawing.Point(9, 40);
            назва_послугиLabel.Name = "назва_послугиLabel";
            назва_послугиLabel.Size = new System.Drawing.Size(85, 13);
            назва_послугиLabel.TabIndex = 28;
            назва_послугиLabel.Text = "Назва послуги:";
            // 
            // цінаLabel
            // 
            цінаLabel.AutoSize = true;
            цінаLabel.Location = new System.Drawing.Point(9, 66);
            цінаLabel.Name = "цінаLabel";
            цінаLabel.Size = new System.Drawing.Size(32, 13);
            цінаLabel.TabIndex = 30;
            цінаLabel.Text = "Ціна:";
            // 
            // сплатити_доLabel
            // 
            сплатити_доLabel.AutoSize = true;
            сплатити_доLabel.Location = new System.Drawing.Point(9, 93);
            сплатити_доLabel.Name = "сплатити_доLabel";
            сплатити_доLabel.Size = new System.Drawing.Size(72, 13);
            сплатити_доLabel.TabIndex = 32;
            сплатити_доLabel.Text = "Сплатити до:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 26);
            this.button4.TabIndex = 26;
            this.button4.Text = "Оплатити";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 26);
            this.button1.TabIndex = 27;
            this.button1.Text = "В меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // servicesDataSet
            // 
            this.servicesDataSet.DataSetName = "ServicesDataSet";
            this.servicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listOfServices1BindingSource
            // 
            this.listOfServices1BindingSource.DataMember = "ListOfServices1";
            this.listOfServices1BindingSource.DataSource = this.servicesDataSet;
            // 
            // listOfServices1TableAdapter
            // 
            this.listOfServices1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ListOfServices1TableAdapter = this.listOfServices1TableAdapter;
            this.tableAdapterManager.UpdateOrder = App_1.ServicesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // назва_послугиTextBox
            // 
            this.назва_послугиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listOfServices1BindingSource, "Назва послуги", true));
            this.назва_послугиTextBox.Enabled = false;
            this.назва_послугиTextBox.Location = new System.Drawing.Point(100, 37);
            this.назва_послугиTextBox.Name = "назва_послугиTextBox";
            this.назва_послугиTextBox.ReadOnly = true;
            this.назва_послугиTextBox.Size = new System.Drawing.Size(200, 20);
            this.назва_послугиTextBox.TabIndex = 29;
            // 
            // цінаTextBox
            // 
            this.цінаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listOfServices1BindingSource, "Ціна", true));
            this.цінаTextBox.Enabled = false;
            this.цінаTextBox.Location = new System.Drawing.Point(100, 63);
            this.цінаTextBox.Name = "цінаTextBox";
            this.цінаTextBox.ReadOnly = true;
            this.цінаTextBox.Size = new System.Drawing.Size(200, 20);
            this.цінаTextBox.TabIndex = 31;
            // 
            // сплатити_доDateTimePicker
            // 
            this.сплатити_доDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listOfServices1BindingSource, "Сплатити до", true));
            this.сплатити_доDateTimePicker.Enabled = false;
            this.сплатити_доDateTimePicker.Location = new System.Drawing.Point(100, 89);
            this.сплатити_доDateTimePicker.Name = "сплатити_доDateTimePicker";
            this.сплатити_доDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.сплатити_доDateTimePicker.TabIndex = 33;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // listOfServices1BindingNavigator
            // 
            this.listOfServices1BindingNavigator.AddNewItem = null;
            this.listOfServices1BindingNavigator.BindingSource = this.listOfServices1BindingSource;
            this.listOfServices1BindingNavigator.CountItem = null;
            this.listOfServices1BindingNavigator.DeleteItem = null;
            this.listOfServices1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem});
            this.listOfServices1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listOfServices1BindingNavigator.MoveFirstItem = null;
            this.listOfServices1BindingNavigator.MoveLastItem = null;
            this.listOfServices1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listOfServices1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listOfServices1BindingNavigator.Name = "listOfServices1BindingNavigator";
            this.listOfServices1BindingNavigator.PositionItem = null;
            this.listOfServices1BindingNavigator.Size = new System.Drawing.Size(311, 25);
            this.listOfServices1BindingNavigator.TabIndex = 28;
            this.listOfServices1BindingNavigator.Text = "bindingNavigator1";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(311, 173);
            this.Controls.Add(this.listOfServices1BindingNavigator);
            this.Controls.Add(назва_послугиLabel);
            this.Controls.Add(this.назва_послугиTextBox);
            this.Controls.Add(цінаLabel);
            this.Controls.Add(this.цінаTextBox);
            this.Controls.Add(сплатити_доLabel);
            this.Controls.Add(this.сплатити_доDateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.Text = "Комунальні послуги";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfServices1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfServices1BindingNavigator)).EndInit();
            this.listOfServices1BindingNavigator.ResumeLayout(false);
            this.listOfServices1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private ServicesDataSet servicesDataSet;
        private System.Windows.Forms.BindingSource listOfServices1BindingSource;
        private ServicesDataSetTableAdapters.ListOfServices1TableAdapter listOfServices1TableAdapter;
        private ServicesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox назва_послугиTextBox;
        private System.Windows.Forms.TextBox цінаTextBox;
        private System.Windows.Forms.DateTimePicker сплатити_доDateTimePicker;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.BindingNavigator listOfServices1BindingNavigator;
    }
}