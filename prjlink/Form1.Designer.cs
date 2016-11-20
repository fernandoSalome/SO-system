namespace prjlink
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
            System.Windows.Forms.Label idCliLabel;
            System.Windows.Forms.Label cliNomeLabel;
            System.Windows.Forms.Label cliCEPLabel;
            System.Windows.Forms.Label cliEndLabel;
            System.Windows.Forms.Label cliCidLabel;
            System.Windows.Forms.Label cliBairroLabel;
            System.Windows.Forms.Label cliUFLabel;
            System.Windows.Forms.Label cliNumLabel;
            System.Windows.Forms.Label cliComplementoLabel;
            System.Windows.Forms.Label cliFone1Label;
            System.Windows.Forms.Label cliFone2Label;
            System.Windows.Forms.Label cliCPFLabel;
            System.Windows.Forms.Label cliEmailLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label cliObsLabel;
            System.Windows.Forms.Label cliSexLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbClientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tbClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLoginDataSet = new prjlink.DBLoginDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbClientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idCliTextBox = new System.Windows.Forms.TextBox();
            this.cliNomeTextBox = new System.Windows.Forms.TextBox();
            this.cliCEPTextBox = new System.Windows.Forms.TextBox();
            this.cliEndTextBox = new System.Windows.Forms.TextBox();
            this.cliCidTextBox = new System.Windows.Forms.TextBox();
            this.cliBairroTextBox = new System.Windows.Forms.TextBox();
            this.cliUFComboBox = new System.Windows.Forms.ComboBox();
            this.cliNumTextBox = new System.Windows.Forms.TextBox();
            this.cliComplementoTextBox = new System.Windows.Forms.TextBox();
            this.cliFone1TextBox = new System.Windows.Forms.TextBox();
            this.cliFone2TextBox = new System.Windows.Forms.TextBox();
            this.cliCPFTextBox = new System.Windows.Forms.TextBox();
            this.cliEmailTextBox = new System.Windows.Forms.TextBox();
            this.cliObsTextBox = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.cliSexComboBox = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.tbClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClientesTableAdapter = new prjlink.DBLoginDataSetTableAdapters.tbClientesTableAdapter();
            this.tableAdapterManager = new prjlink.DBLoginDataSetTableAdapters.TableAdapterManager();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            idCliLabel = new System.Windows.Forms.Label();
            cliNomeLabel = new System.Windows.Forms.Label();
            cliCEPLabel = new System.Windows.Forms.Label();
            cliEndLabel = new System.Windows.Forms.Label();
            cliCidLabel = new System.Windows.Forms.Label();
            cliBairroLabel = new System.Windows.Forms.Label();
            cliUFLabel = new System.Windows.Forms.Label();
            cliNumLabel = new System.Windows.Forms.Label();
            cliComplementoLabel = new System.Windows.Forms.Label();
            cliFone1Label = new System.Windows.Forms.Label();
            cliFone2Label = new System.Windows.Forms.Label();
            cliCPFLabel = new System.Windows.Forms.Label();
            cliEmailLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            cliObsLabel = new System.Windows.Forms.Label();
            cliSexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingNavigator)).BeginInit();
            this.tbClientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idCliLabel
            // 
            idCliLabel.AutoSize = true;
            idCliLabel.Location = new System.Drawing.Point(70, 275);
            idCliLabel.Name = "idCliLabel";
            idCliLabel.Size = new System.Drawing.Size(16, 13);
            idCliLabel.TabIndex = 1;
            idCliLabel.Text = "Id";
            // 
            // cliNomeLabel
            // 
            cliNomeLabel.AutoSize = true;
            cliNomeLabel.Location = new System.Drawing.Point(230, 275);
            cliNomeLabel.Name = "cliNomeLabel";
            cliNomeLabel.Size = new System.Drawing.Size(42, 13);
            cliNomeLabel.TabIndex = 3;
            cliNomeLabel.Text = "* Nome";
            // 
            // cliCEPLabel
            // 
            cliCEPLabel.AutoSize = true;
            cliCEPLabel.Location = new System.Drawing.Point(296, 324);
            cliCEPLabel.Name = "cliCEPLabel";
            cliCEPLabel.Size = new System.Drawing.Size(31, 13);
            cliCEPLabel.TabIndex = 7;
            cliCEPLabel.Text = "CEP:";
            // 
            // cliEndLabel
            // 
            cliEndLabel.AutoSize = true;
            cliEndLabel.Location = new System.Drawing.Point(36, 369);
            cliEndLabel.Name = "cliEndLabel";
            cliEndLabel.Size = new System.Drawing.Size(60, 13);
            cliEndLabel.TabIndex = 9;
            cliEndLabel.Text = "* Endereço";
            // 
            // cliCidLabel
            // 
            cliCidLabel.AutoSize = true;
            cliCidLabel.Location = new System.Drawing.Point(391, 406);
            cliCidLabel.Name = "cliCidLabel";
            cliCidLabel.Size = new System.Drawing.Size(47, 13);
            cliCidLabel.TabIndex = 11;
            cliCidLabel.Text = "* Cidade";
            // 
            // cliBairroLabel
            // 
            cliBairroLabel.AutoSize = true;
            cliBairroLabel.Location = new System.Drawing.Point(52, 407);
            cliBairroLabel.Name = "cliBairroLabel";
            cliBairroLabel.Size = new System.Drawing.Size(41, 13);
            cliBairroLabel.TabIndex = 13;
            cliBairroLabel.Text = "* Bairro";
            // 
            // cliUFLabel
            // 
            cliUFLabel.AutoSize = true;
            cliUFLabel.Location = new System.Drawing.Point(691, 407);
            cliUFLabel.Name = "cliUFLabel";
            cliUFLabel.Size = new System.Drawing.Size(28, 13);
            cliUFLabel.TabIndex = 15;
            cliUFLabel.Text = "* UF";
            // 
            // cliNumLabel
            // 
            cliNumLabel.AutoSize = true;
            cliNumLabel.Location = new System.Drawing.Point(493, 365);
            cliNumLabel.Name = "cliNumLabel";
            cliNumLabel.Size = new System.Drawing.Size(51, 13);
            cliNumLabel.TabIndex = 17;
            cliNumLabel.Text = "* Número";
            // 
            // cliComplementoLabel
            // 
            cliComplementoLabel.AutoSize = true;
            cliComplementoLabel.Location = new System.Drawing.Point(647, 365);
            cliComplementoLabel.Name = "cliComplementoLabel";
            cliComplementoLabel.Size = new System.Drawing.Size(74, 13);
            cliComplementoLabel.TabIndex = 19;
            cliComplementoLabel.Text = "Complemento:";
            // 
            // cliFone1Label
            // 
            cliFone1Label.AutoSize = true;
            cliFone1Label.Location = new System.Drawing.Point(48, 457);
            cliFone1Label.Name = "cliFone1Label";
            cliFone1Label.Size = new System.Drawing.Size(44, 13);
            cliFone1Label.TabIndex = 21;
            cliFone1Label.Text = "* Fone1";
            // 
            // cliFone2Label
            // 
            cliFone2Label.AutoSize = true;
            cliFone2Label.Location = new System.Drawing.Point(263, 457);
            cliFone2Label.Name = "cliFone2Label";
            cliFone2Label.Size = new System.Drawing.Size(40, 13);
            cliFone2Label.TabIndex = 23;
            cliFone2Label.Text = "Fone2:";
            // 
            // cliCPFLabel
            // 
            cliCPFLabel.AutoSize = true;
            cliCPFLabel.Location = new System.Drawing.Point(537, 460);
            cliCPFLabel.Name = "cliCPFLabel";
            cliCPFLabel.Size = new System.Drawing.Size(30, 13);
            cliCPFLabel.TabIndex = 25;
            cliCPFLabel.Text = "CPF:";
            // 
            // cliEmailLabel
            // 
            cliEmailLabel.AutoSize = true;
            cliEmailLabel.Location = new System.Drawing.Point(54, 497);
            cliEmailLabel.Name = "cliEmailLabel";
            cliEmailLabel.Size = new System.Drawing.Size(35, 13);
            cliEmailLabel.TabIndex = 27;
            cliEmailLabel.Text = "Email:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(696, 110);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(28, 13);
            fotoLabel.TabIndex = 29;
            fotoLabel.Text = "foto:";
            // 
            // cliObsLabel
            // 
            cliObsLabel.AutoSize = true;
            cliObsLabel.Location = new System.Drawing.Point(24, 538);
            cliObsLabel.Name = "cliObsLabel";
            cliObsLabel.Size = new System.Drawing.Size(65, 13);
            cliObsLabel.TabIndex = 31;
            cliObsLabel.Text = "Observação";
            // 
            // cliSexLabel
            // 
            cliSexLabel.AutoSize = true;
            cliSexLabel.Location = new System.Drawing.Point(58, 325);
            cliSexLabel.Name = "cliSexLabel";
            cliSexLabel.Size = new System.Drawing.Size(31, 13);
            cliSexLabel.TabIndex = 36;
            cliSexLabel.Text = "Sexo";
            // 
            // tbClientesBindingNavigator
            // 
            this.tbClientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbClientesBindingNavigator.BindingSource = this.tbClientesBindingSource;
            this.tbClientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbClientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbClientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbClientesBindingNavigatorSaveItem});
            this.tbClientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbClientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbClientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbClientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbClientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbClientesBindingNavigator.Name = "tbClientesBindingNavigator";
            this.tbClientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbClientesBindingNavigator.Size = new System.Drawing.Size(856, 25);
            this.tbClientesBindingNavigator.TabIndex = 0;
            this.tbClientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tbClientesBindingSource
            // 
            this.tbClientesBindingSource.DataMember = "tbClientes";
            this.tbClientesBindingSource.DataSource = this.dBLoginDataSet;
            // 
            // dBLoginDataSet
            // 
            this.dBLoginDataSet.DataSetName = "DBLoginDataSet";
            this.dBLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbClientesBindingNavigatorSaveItem
            // 
            this.tbClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbClientesBindingNavigatorSaveItem.Enabled = false;
            this.tbClientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbClientesBindingNavigatorSaveItem.Image")));
            this.tbClientesBindingNavigatorSaveItem.Name = "tbClientesBindingNavigatorSaveItem";
            this.tbClientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbClientesBindingNavigatorSaveItem.Text = "Save Data";
            this.tbClientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbClientesBindingNavigatorSaveItem_Click);
            // 
            // idCliTextBox
            // 
            this.idCliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "idCli", true));
            this.idCliTextBox.Location = new System.Drawing.Point(108, 272);
            this.idCliTextBox.Name = "idCliTextBox";
            this.idCliTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCliTextBox.TabIndex = 2;
            // 
            // cliNomeTextBox
            // 
            this.cliNomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliNome", true));
            this.cliNomeTextBox.Location = new System.Drawing.Point(287, 272);
            this.cliNomeTextBox.Name = "cliNomeTextBox";
            this.cliNomeTextBox.Size = new System.Drawing.Size(369, 20);
            this.cliNomeTextBox.TabIndex = 4;
            // 
            // cliCEPTextBox
            // 
            this.cliCEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliCEP", true));
            this.cliCEPTextBox.Location = new System.Drawing.Point(346, 321);
            this.cliCEPTextBox.Name = "cliCEPTextBox";
            this.cliCEPTextBox.Size = new System.Drawing.Size(109, 20);
            this.cliCEPTextBox.TabIndex = 8;
            // 
            // cliEndTextBox
            // 
            this.cliEndTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliEnd", true));
            this.cliEndTextBox.Location = new System.Drawing.Point(107, 362);
            this.cliEndTextBox.Name = "cliEndTextBox";
            this.cliEndTextBox.Size = new System.Drawing.Size(370, 20);
            this.cliEndTextBox.TabIndex = 10;
            // 
            // cliCidTextBox
            // 
            this.cliCidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliCid", true));
            this.cliCidTextBox.Location = new System.Drawing.Point(444, 403);
            this.cliCidTextBox.Name = "cliCidTextBox";
            this.cliCidTextBox.Size = new System.Drawing.Size(205, 20);
            this.cliCidTextBox.TabIndex = 12;
            // 
            // cliBairroTextBox
            // 
            this.cliBairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliBairro", true));
            this.cliBairroTextBox.Location = new System.Drawing.Point(108, 404);
            this.cliBairroTextBox.Name = "cliBairroTextBox";
            this.cliBairroTextBox.Size = new System.Drawing.Size(251, 20);
            this.cliBairroTextBox.TabIndex = 14;
            // 
            // cliUFComboBox
            // 
            this.cliUFComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliUF", true));
            this.cliUFComboBox.FormattingEnabled = true;
            this.cliUFComboBox.Items.AddRange(new object[] {
            "AM",
            "SP",
            "RJ",
            "MG",
            "AL",
            "BA"});
            this.cliUFComboBox.Location = new System.Drawing.Point(725, 403);
            this.cliUFComboBox.Name = "cliUFComboBox";
            this.cliUFComboBox.Size = new System.Drawing.Size(75, 21);
            this.cliUFComboBox.TabIndex = 16;
            // 
            // cliNumTextBox
            // 
            this.cliNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliNum", true));
            this.cliNumTextBox.Location = new System.Drawing.Point(546, 362);
            this.cliNumTextBox.Name = "cliNumTextBox";
            this.cliNumTextBox.Size = new System.Drawing.Size(83, 20);
            this.cliNumTextBox.TabIndex = 18;
            // 
            // cliComplementoTextBox
            // 
            this.cliComplementoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliComplemento", true));
            this.cliComplementoTextBox.Location = new System.Drawing.Point(744, 362);
            this.cliComplementoTextBox.Name = "cliComplementoTextBox";
            this.cliComplementoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cliComplementoTextBox.TabIndex = 20;
            // 
            // cliFone1TextBox
            // 
            this.cliFone1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliFone1", true));
            this.cliFone1TextBox.Location = new System.Drawing.Point(107, 454);
            this.cliFone1TextBox.Name = "cliFone1TextBox";
            this.cliFone1TextBox.Size = new System.Drawing.Size(100, 20);
            this.cliFone1TextBox.TabIndex = 22;
            // 
            // cliFone2TextBox
            // 
            this.cliFone2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliFone2", true));
            this.cliFone2TextBox.Location = new System.Drawing.Point(322, 454);
            this.cliFone2TextBox.Name = "cliFone2TextBox";
            this.cliFone2TextBox.Size = new System.Drawing.Size(100, 20);
            this.cliFone2TextBox.TabIndex = 24;
            // 
            // cliCPFTextBox
            // 
            this.cliCPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliCPF", true));
            this.cliCPFTextBox.Location = new System.Drawing.Point(586, 457);
            this.cliCPFTextBox.Name = "cliCPFTextBox";
            this.cliCPFTextBox.Size = new System.Drawing.Size(176, 20);
            this.cliCPFTextBox.TabIndex = 26;
            // 
            // cliEmailTextBox
            // 
            this.cliEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliEmail", true));
            this.cliEmailTextBox.Location = new System.Drawing.Point(108, 494);
            this.cliEmailTextBox.Name = "cliEmailTextBox";
            this.cliEmailTextBox.Size = new System.Drawing.Size(685, 20);
            this.cliEmailTextBox.TabIndex = 28;
            // 
            // cliObsTextBox
            // 
            this.cliObsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliObs", true));
            this.cliObsTextBox.Location = new System.Drawing.Point(108, 535);
            this.cliObsTextBox.Multiline = true;
            this.cliObsTextBox.Name = "cliObsTextBox";
            this.cliObsTextBox.Size = new System.Drawing.Size(692, 60);
            this.cliObsTextBox.TabIndex = 32;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(279, 631);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 33;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(398, 631);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(531, 631);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(703, 258);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(118, 23);
            this.btnFoto.TabIndex = 36;
            this.btnFoto.Text = "Adicionar Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // cliSexComboBox
            // 
            this.cliSexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cliSex", true));
            this.cliSexComboBox.FormattingEnabled = true;
            this.cliSexComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.cliSexComboBox.Location = new System.Drawing.Point(108, 322);
            this.cliSexComboBox.Name = "cliSexComboBox";
            this.cliSexComboBox.Size = new System.Drawing.Size(121, 21);
            this.cliSexComboBox.TabIndex = 37;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(27, 38);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(222, 20);
            this.txtPesquisar.TabIndex = 38;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // tbClientesDataGridView
            // 
            this.tbClientesDataGridView.AutoGenerateColumns = false;
            this.tbClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn15});
            this.tbClientesDataGridView.DataSource = this.tbClientesBindingSource;
            this.tbClientesDataGridView.Location = new System.Drawing.Point(23, 75);
            this.tbClientesDataGridView.Name = "tbClientesDataGridView";
            this.tbClientesDataGridView.Size = new System.Drawing.Size(633, 165);
            this.tbClientesDataGridView.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idCli";
            this.dataGridViewTextBoxColumn1.HeaderText = "idCli";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cliNome";
            this.dataGridViewTextBoxColumn2.HeaderText = "cliNome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cliSex";
            this.dataGridViewTextBoxColumn3.HeaderText = "cliSex";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cliCEP";
            this.dataGridViewTextBoxColumn4.HeaderText = "cliCEP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cliEnd";
            this.dataGridViewTextBoxColumn5.HeaderText = "cliEnd";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cliCid";
            this.dataGridViewTextBoxColumn6.HeaderText = "cliCid";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cliBairro";
            this.dataGridViewTextBoxColumn7.HeaderText = "cliBairro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "cliUF";
            this.dataGridViewTextBoxColumn8.HeaderText = "cliUF";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "cliNum";
            this.dataGridViewTextBoxColumn9.HeaderText = "cliNum";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "cliComplemento";
            this.dataGridViewTextBoxColumn10.HeaderText = "cliComplemento";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "cliFone1";
            this.dataGridViewTextBoxColumn11.HeaderText = "cliFone1";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "cliFone2";
            this.dataGridViewTextBoxColumn12.HeaderText = "cliFone2";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "cliCPF";
            this.dataGridViewTextBoxColumn13.HeaderText = "cliCPF";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "cliEmail";
            this.dataGridViewTextBoxColumn14.HeaderText = "cliEmail";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "foto";
            this.dataGridViewImageColumn1.HeaderText = "foto";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "cliObs";
            this.dataGridViewTextBoxColumn15.HeaderText = "cliObs";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::prjlink.Properties.Resources.check;
            this.pictureBox2.Location = new System.Drawing.Point(768, 454);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjlink.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(266, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tbClientesBindingSource, "foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(699, 126);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(128, 128);
            this.fotoPictureBox.TabIndex = 30;
            this.fotoPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "* Campos obrigatórios";
            // 
            // tbClientesTableAdapter
            // 
            this.tbClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClientesTableAdapter = this.tbClientesTableAdapter;
            this.tableAdapterManager.tbUsuariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjlink.DBLoginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbClientesDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(cliSexLabel);
            this.Controls.Add(this.cliSexComboBox);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(cliObsLabel);
            this.Controls.Add(this.cliObsTextBox);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(cliEmailLabel);
            this.Controls.Add(this.cliEmailTextBox);
            this.Controls.Add(cliCPFLabel);
            this.Controls.Add(this.cliCPFTextBox);
            this.Controls.Add(cliFone2Label);
            this.Controls.Add(this.cliFone2TextBox);
            this.Controls.Add(cliFone1Label);
            this.Controls.Add(this.cliFone1TextBox);
            this.Controls.Add(cliComplementoLabel);
            this.Controls.Add(this.cliComplementoTextBox);
            this.Controls.Add(cliNumLabel);
            this.Controls.Add(this.cliNumTextBox);
            this.Controls.Add(cliUFLabel);
            this.Controls.Add(this.cliUFComboBox);
            this.Controls.Add(cliBairroLabel);
            this.Controls.Add(this.cliBairroTextBox);
            this.Controls.Add(cliCidLabel);
            this.Controls.Add(this.cliCidTextBox);
            this.Controls.Add(cliEndLabel);
            this.Controls.Add(this.cliEndTextBox);
            this.Controls.Add(cliCEPLabel);
            this.Controls.Add(this.cliCEPTextBox);
            this.Controls.Add(cliNomeLabel);
            this.Controls.Add(this.cliNomeTextBox);
            this.Controls.Add(idCliLabel);
            this.Controls.Add(this.idCliTextBox);
            this.Controls.Add(this.tbClientesBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingNavigator)).EndInit();
            this.tbClientesBindingNavigator.ResumeLayout(false);
            this.tbClientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBLoginDataSet dBLoginDataSet;
        private System.Windows.Forms.BindingSource tbClientesBindingSource;
        private DBLoginDataSetTableAdapters.tbClientesTableAdapter tbClientesTableAdapter;
        private DBLoginDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbClientesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbClientesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idCliTextBox;
        private System.Windows.Forms.TextBox cliNomeTextBox;
        private System.Windows.Forms.TextBox cliCEPTextBox;
        private System.Windows.Forms.TextBox cliEndTextBox;
        private System.Windows.Forms.TextBox cliCidTextBox;
        private System.Windows.Forms.TextBox cliBairroTextBox;
        private System.Windows.Forms.ComboBox cliUFComboBox;
        private System.Windows.Forms.TextBox cliNumTextBox;
        private System.Windows.Forms.TextBox cliComplementoTextBox;
        private System.Windows.Forms.TextBox cliFone1TextBox;
        private System.Windows.Forms.TextBox cliFone2TextBox;
        private System.Windows.Forms.TextBox cliCPFTextBox;
        private System.Windows.Forms.TextBox cliEmailTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.TextBox cliObsTextBox;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.ComboBox cliSexComboBox;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tbClientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

