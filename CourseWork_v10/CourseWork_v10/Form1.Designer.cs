namespace CourseWork_v10
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label childNameLabel;
            System.Windows.Forms.Label childAddressLabel;
            System.Windows.Forms.Label childBirthDateLabel;
            System.Windows.Forms.Label childWeightLabel;
            System.Windows.Forms.Label childCategoryLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.childrenDataSet = new CourseWork_v10.ChildrenDataSet();
            this.tb_ChildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ChildTableAdapter = new CourseWork_v10.ChildrenDataSetTableAdapters.tb_ChildTableAdapter();
            this.tableAdapterManager = new CourseWork_v10.ChildrenDataSetTableAdapters.TableAdapterManager();
            this.tb_ChildBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tb_ChildBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.childNameTextBox = new System.Windows.Forms.TextBox();
            this.childAddressTextBox = new System.Windows.Forms.TextBox();
            this.childBirthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.GroupBox();
            this.dtpNewDB = new System.Windows.Forms.DateTimePicker();
            this.tbxNewAddress = new System.Windows.Forms.TextBox();
            this.tbxNewName = new System.Windows.Forms.TextBox();
            this.cmbNewCategory = new System.Windows.Forms.ComboBox();
            this.nudNewWeight = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbChildCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ChildCategoryTableAdapter = new CourseWork_v10.ChildrenDataSetTableAdapters.tb_ChildCategoryTableAdapter();
            this.tbChildCategorytbChildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbChildCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            childNameLabel = new System.Windows.Forms.Label();
            childAddressLabel = new System.Windows.Forms.Label();
            childBirthDateLabel = new System.Windows.Forms.Label();
            childWeightLabel = new System.Windows.Forms.Label();
            childCategoryLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.childrenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ChildBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ChildBindingNavigator)).BeginInit();
            this.tb_ChildBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildCategorytbChildBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildCategoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // childrenDataSet
            // 
            this.childrenDataSet.DataSetName = "ChildrenDataSet";
            this.childrenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ChildBindingSource
            // 
            this.tb_ChildBindingSource.DataMember = "tb_Child";
            this.tb_ChildBindingSource.DataSource = this.childrenDataSet;
            this.tb_ChildBindingSource.CurrentChanged += new System.EventHandler(this.tb_ChildBindingSource_CurrentChanged);
            // 
            // tb_ChildTableAdapter
            // 
            this.tb_ChildTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_ChildCategoryTableAdapter = this.tb_ChildCategoryTableAdapter;
            this.tableAdapterManager.tb_ChildTableAdapter = this.tb_ChildTableAdapter;
            this.tableAdapterManager.UpdateOrder = CourseWork_v10.ChildrenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_ChildBindingNavigator
            // 
            this.tb_ChildBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_ChildBindingNavigator.BindingSource = this.tb_ChildBindingSource;
            this.tb_ChildBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_ChildBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_ChildBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_ChildBindingNavigatorSaveItem});
            this.tb_ChildBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_ChildBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_ChildBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_ChildBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_ChildBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_ChildBindingNavigator.Name = "tb_ChildBindingNavigator";
            this.tb_ChildBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_ChildBindingNavigator.Size = new System.Drawing.Size(980, 25);
            this.tb_ChildBindingNavigator.TabIndex = 0;
            this.tb_ChildBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tb_ChildBindingNavigatorSaveItem
            // 
            this.tb_ChildBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_ChildBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_ChildBindingNavigatorSaveItem.Image")));
            this.tb_ChildBindingNavigatorSaveItem.Name = "tb_ChildBindingNavigatorSaveItem";
            this.tb_ChildBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_ChildBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_ChildBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_ChildBindingNavigatorSaveItem_Click);
            // 
            // childNameLabel
            // 
            childNameLabel.AutoSize = true;
            childNameLabel.Location = new System.Drawing.Point(224, 90);
            childNameLabel.Name = "childNameLabel";
            childNameLabel.Size = new System.Drawing.Size(64, 13);
            childNameLabel.TabIndex = 3;
            childNameLabel.Text = "Child Name:";
            // 
            // childNameTextBox
            // 
            this.childNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ChildBindingSource, "ChildName", true));
            this.childNameTextBox.Location = new System.Drawing.Point(313, 87);
            this.childNameTextBox.Name = "childNameTextBox";
            this.childNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.childNameTextBox.TabIndex = 4;
            this.childNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.childNameTextBox_Validating);
            // 
            // childAddressLabel
            // 
            childAddressLabel.AutoSize = true;
            childAddressLabel.Location = new System.Drawing.Point(224, 116);
            childAddressLabel.Name = "childAddressLabel";
            childAddressLabel.Size = new System.Drawing.Size(74, 13);
            childAddressLabel.TabIndex = 5;
            childAddressLabel.Text = "Child Address:";
            // 
            // childAddressTextBox
            // 
            this.childAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ChildBindingSource, "ChildAddress", true));
            this.childAddressTextBox.Location = new System.Drawing.Point(313, 113);
            this.childAddressTextBox.Name = "childAddressTextBox";
            this.childAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.childAddressTextBox.TabIndex = 6;
            // 
            // childBirthDateLabel
            // 
            childBirthDateLabel.AutoSize = true;
            childBirthDateLabel.Location = new System.Drawing.Point(224, 143);
            childBirthDateLabel.Name = "childBirthDateLabel";
            childBirthDateLabel.Size = new System.Drawing.Size(83, 13);
            childBirthDateLabel.TabIndex = 7;
            childBirthDateLabel.Text = "Child Birth Date:";
            // 
            // childBirthDateDateTimePicker
            // 
            this.childBirthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_ChildBindingSource, "ChildBirthDate", true));
            this.childBirthDateDateTimePicker.Location = new System.Drawing.Point(313, 139);
            this.childBirthDateDateTimePicker.Name = "childBirthDateDateTimePicker";
            this.childBirthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.childBirthDateDateTimePicker.TabIndex = 8;
            // 
            // childWeightLabel
            // 
            childWeightLabel.AutoSize = true;
            childWeightLabel.Location = new System.Drawing.Point(224, 168);
            childWeightLabel.Name = "childWeightLabel";
            childWeightLabel.Size = new System.Drawing.Size(70, 13);
            childWeightLabel.TabIndex = 9;
            childWeightLabel.Text = "Child Weight:";
            // 
            // childCategoryLabel
            // 
            childCategoryLabel.AutoSize = true;
            childCategoryLabel.Location = new System.Drawing.Point(224, 194);
            childCategoryLabel.Name = "childCategoryLabel";
            childCategoryLabel.Size = new System.Drawing.Size(78, 13);
            childCategoryLabel.TabIndex = 11;
            childCategoryLabel.Text = "Child Category:";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tb_ChildBindingSource;
            this.listBox1.DisplayMember = "ChildName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 121);
            this.listBox1.TabIndex = 13;
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(12, 61);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(206, 20);
            this.tbxFilter.TabIndex = 14;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_ChildBindingSource, "ChildCategory", true));
            this.comboBox1.DataSource = this.tbChildCategoryBindingSource;
            this.comboBox1.DisplayMember = "ChildCategoryName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(313, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "ID";
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(313, 165);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(200, 20);
            this.nudWeight.TabIndex = 16;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 217);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(47, 23);
            this.btnFirst.TabIndex = 17;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(65, 217);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(47, 23);
            this.btnPrevious.TabIndex = 18;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(118, 217);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(47, 23);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(171, 217);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(47, 23);
            this.btnLast.TabIndex = 20;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(307, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(413, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Add
            // 
            this.Add.Controls.Add(this.btnAdd);
            this.Add.Controls.Add(this.dtpNewDB);
            this.Add.Controls.Add(label1);
            this.Add.Controls.Add(label2);
            this.Add.Controls.Add(label3);
            this.Add.Controls.Add(this.tbxNewAddress);
            this.Add.Controls.Add(label4);
            this.Add.Controls.Add(this.tbxNewName);
            this.Add.Controls.Add(this.nudNewWeight);
            this.Add.Controls.Add(label5);
            this.Add.Controls.Add(this.cmbNewCategory);
            this.Add.Location = new System.Drawing.Point(565, 61);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(324, 183);
            this.Add.TabIndex = 23;
            this.Add.TabStop = false;
            this.Add.Text = "Add";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 130);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 13);
            label1.TabIndex = 11;
            label1.Text = "Child Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 104);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 13);
            label2.TabIndex = 9;
            label2.Text = "Child Weight:";
            // 
            // dtpNewDB
            // 
            this.dtpNewDB.Location = new System.Drawing.Point(101, 75);
            this.dtpNewDB.Name = "dtpNewDB";
            this.dtpNewDB.Size = new System.Drawing.Size(200, 20);
            this.dtpNewDB.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 79);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 13);
            label3.TabIndex = 7;
            label3.Text = "Child Birth Date:";
            // 
            // tbxNewAddress
            // 
            this.tbxNewAddress.Location = new System.Drawing.Point(101, 49);
            this.tbxNewAddress.Name = "tbxNewAddress";
            this.tbxNewAddress.Size = new System.Drawing.Size(200, 20);
            this.tbxNewAddress.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 52);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(74, 13);
            label4.TabIndex = 5;
            label4.Text = "Child Address:";
            // 
            // tbxNewName
            // 
            this.tbxNewName.Location = new System.Drawing.Point(101, 23);
            this.tbxNewName.Name = "tbxNewName";
            this.tbxNewName.Size = new System.Drawing.Size(200, 20);
            this.tbxNewName.TabIndex = 4;
            this.tbxNewName.Validating += new System.ComponentModel.CancelEventHandler(this.tbxNewName_Validating);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 26);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(64, 13);
            label5.TabIndex = 3;
            label5.Text = "Child Name:";
            // 
            // cmbNewCategory
            // 
            this.cmbNewCategory.DataSource = this.tbChildCategoryBindingSource1;
            this.cmbNewCategory.DisplayMember = "ChildCategoryName";
            this.cmbNewCategory.FormattingEnabled = true;
            this.cmbNewCategory.Location = new System.Drawing.Point(101, 130);
            this.cmbNewCategory.Name = "cmbNewCategory";
            this.cmbNewCategory.Size = new System.Drawing.Size(200, 21);
            this.cmbNewCategory.TabIndex = 15;
            // 
            // nudNewWeight
            // 
            this.nudNewWeight.Location = new System.Drawing.Point(101, 101);
            this.nudNewWeight.Name = "nudNewWeight";
            this.nudNewWeight.Size = new System.Drawing.Size(200, 20);
            this.nudNewWeight.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(226, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbChildCategoryBindingSource
            // 
            this.tbChildCategoryBindingSource.DataMember = "tb_ChildCategory";
            this.tbChildCategoryBindingSource.DataSource = this.childrenDataSet;
            // 
            // tb_ChildCategoryTableAdapter
            // 
            this.tb_ChildCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tbChildCategorytbChildBindingSource
            // 
            this.tbChildCategorytbChildBindingSource.DataMember = "tb_ChildCategorytb_Child";
            this.tbChildCategorytbChildBindingSource.DataSource = this.tbChildCategoryBindingSource;
            // 
            // tbChildCategoryBindingSource1
            // 
            this.tbChildCategoryBindingSource1.DataMember = "tb_ChildCategory";
            this.tbChildCategoryBindingSource1.DataSource = this.childrenDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 457);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(childNameLabel);
            this.Controls.Add(this.childNameTextBox);
            this.Controls.Add(childAddressLabel);
            this.Controls.Add(this.childAddressTextBox);
            this.Controls.Add(childBirthDateLabel);
            this.Controls.Add(this.childBirthDateDateTimePicker);
            this.Controls.Add(childWeightLabel);
            this.Controls.Add(childCategoryLabel);
            this.Controls.Add(this.tb_ChildBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.childrenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ChildBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ChildBindingNavigator)).EndInit();
            this.tb_ChildBindingNavigator.ResumeLayout(false);
            this.tb_ChildBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildCategorytbChildBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildCategoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChildrenDataSet childrenDataSet;
        private System.Windows.Forms.BindingSource tb_ChildBindingSource;
        private ChildrenDataSetTableAdapters.tb_ChildTableAdapter tb_ChildTableAdapter;
        private ChildrenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_ChildBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_ChildBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox childNameTextBox;
        private System.Windows.Forms.TextBox childAddressTextBox;
        private System.Windows.Forms.DateTimePicker childBirthDateDateTimePicker;
        private System.Windows.Forms.ListBox listBox1;
        private ChildrenDataSetTableAdapters.tb_ChildCategoryTableAdapter tb_ChildCategoryTableAdapter;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox Add;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpNewDB;
        private System.Windows.Forms.TextBox tbxNewAddress;
        private System.Windows.Forms.TextBox tbxNewName;
        private System.Windows.Forms.NumericUpDown nudNewWeight;
        private System.Windows.Forms.ComboBox cmbNewCategory;
        private System.Windows.Forms.BindingSource tbChildCategoryBindingSource;
        private System.Windows.Forms.BindingSource tbChildCategoryBindingSource1;
        private System.Windows.Forms.BindingSource tbChildCategorytbChildBindingSource;
    }
}

