namespace HealthyLifeFirst
{
    partial class Form_ItemManagement
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_ItemID = new System.Windows.Forms.Label();
            this.tbx_ItemID = new System.Windows.Forms.TextBox();
            this.lbl_ItemType = new System.Windows.Forms.Label();
            this.lbl_SubCategory = new System.Windows.Forms.Label();
            this.lbl_MainCategory = new System.Windows.Forms.Label();
            this.tbx_Description = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.tbx_Brand = new System.Windows.Forms.TextBox();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.tbx_SupplierID = new System.Windows.Forms.TextBox();
            this.lbl_SupplierID = new System.Windows.Forms.Label();
            this.btn_FindSupplier = new System.Windows.Forms.Button();
            this.tbx_ActiveIngredient = new System.Windows.Forms.TextBox();
            this.lbl_ActiveIngredient = new System.Windows.Forms.Label();
            this.tbx_StoreBelowTemp = new System.Windows.Forms.TextBox();
            this.lbl_StoreBelowTemp = new System.Windows.Forms.Label();
            this.gbx_SunlightSensitive = new System.Windows.Forms.GroupBox();
            this.rdo_SunlightSensitiveNo = new System.Windows.Forms.RadioButton();
            this.rdo_SunlightSensitiveYes = new System.Windows.Forms.RadioButton();
            this.lbl_SunlightSensitive = new System.Windows.Forms.Label();
            this.lbl_DosageFrequency = new System.Windows.Forms.Label();
            this.dgv_ItemManagement = new System.Windows.Forms.DataGridView();
            this.cbx_ItemType = new System.Windows.Forms.ComboBox();
            this.cbx_MainCategory = new System.Windows.Forms.ComboBox();
            this.cbx_SubCategory = new System.Windows.Forms.ComboBox();
            this.cbx_DosageFrequency = new System.Windows.Forms.ComboBox();
            this.lbl_CauseDrowsiness = new System.Windows.Forms.Label();
            this.gbx_CauseDrowsiness = new System.Windows.Forms.GroupBox();
            this.rdo_CauseDrowsinessNo = new System.Windows.Forms.RadioButton();
            this.rdo_CauseDrowsinessYes = new System.Windows.Forms.RadioButton();
            this.lbl_CauseGastric = new System.Windows.Forms.Label();
            this.gbx_CauseGastric = new System.Windows.Forms.GroupBox();
            this.rdo_CauseGastricNo = new System.Windows.Forms.RadioButton();
            this.rdo_CauseGastricYes = new System.Windows.Forms.RadioButton();
            this.lbl_ByCourse = new System.Windows.Forms.Label();
            this.gbx_ByCourse = new System.Windows.Forms.GroupBox();
            this.rdo_ByCourseNo = new System.Windows.Forms.RadioButton();
            this.rdo_ByCourseYes = new System.Windows.Forms.RadioButton();
            this.tbx_SalesPrice = new System.Windows.Forms.TextBox();
            this.lbl_SalesPrice = new System.Windows.Forms.Label();
            this.tbx_Remarks = new System.Windows.Forms.TextBox();
            this.lbl_Remarks = new System.Windows.Forms.Label();
            this.gbx_SunlightSensitive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemManagement)).BeginInit();
            this.gbx_CauseDrowsiness.SuspendLayout();
            this.gbx_CauseGastric.SuspendLayout();
            this.gbx_ByCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.lbl_Title.Location = new System.Drawing.Point(12, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(188, 31);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Item Management";
            // 
            // lbl_ItemID
            // 
            this.lbl_ItemID.AutoSize = true;
            this.lbl_ItemID.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_ItemID.Location = new System.Drawing.Point(16, 56);
            this.lbl_ItemID.Name = "lbl_ItemID";
            this.lbl_ItemID.Size = new System.Drawing.Size(43, 17);
            this.lbl_ItemID.TabIndex = 1;
            this.lbl_ItemID.Text = "Item ID";
            // 
            // tbx_ItemID
            // 
            this.tbx_ItemID.Location = new System.Drawing.Point(100, 52);
            this.tbx_ItemID.Name = "tbx_ItemID";
            this.tbx_ItemID.Size = new System.Drawing.Size(150, 23);
            this.tbx_ItemID.TabIndex = 2;
            // 
            // lbl_ItemType
            // 
            this.lbl_ItemType.AutoSize = true;
            this.lbl_ItemType.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_ItemType.Location = new System.Drawing.Point(16, 84);
            this.lbl_ItemType.Name = "lbl_ItemType";
            this.lbl_ItemType.Size = new System.Drawing.Size(57, 17);
            this.lbl_ItemType.TabIndex = 3;
            this.lbl_ItemType.Text = "Item Type";
            // 
            // lbl_SubCategory
            // 
            this.lbl_SubCategory.AutoSize = true;
            this.lbl_SubCategory.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_SubCategory.Location = new System.Drawing.Point(16, 140);
            this.lbl_SubCategory.Name = "lbl_SubCategory";
            this.lbl_SubCategory.Size = new System.Drawing.Size(75, 17);
            this.lbl_SubCategory.TabIndex = 7;
            this.lbl_SubCategory.Text = "Sub Category";
            // 
            // lbl_MainCategory
            // 
            this.lbl_MainCategory.AutoSize = true;
            this.lbl_MainCategory.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_MainCategory.Location = new System.Drawing.Point(16, 112);
            this.lbl_MainCategory.Name = "lbl_MainCategory";
            this.lbl_MainCategory.Size = new System.Drawing.Size(80, 17);
            this.lbl_MainCategory.TabIndex = 5;
            this.lbl_MainCategory.Text = "Main Category";
            // 
            // tbx_Description
            // 
            this.tbx_Description.Location = new System.Drawing.Point(100, 192);
            this.tbx_Description.Multiline = true;
            this.tbx_Description.Name = "tbx_Description";
            this.tbx_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Description.Size = new System.Drawing.Size(150, 100);
            this.tbx_Description.TabIndex = 12;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_Description.Location = new System.Drawing.Point(16, 196);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(62, 17);
            this.lbl_Description.TabIndex = 11;
            this.lbl_Description.Text = "Description";
            // 
            // tbx_Brand
            // 
            this.tbx_Brand.Location = new System.Drawing.Point(100, 164);
            this.tbx_Brand.Name = "tbx_Brand";
            this.tbx_Brand.Size = new System.Drawing.Size(150, 23);
            this.tbx_Brand.TabIndex = 10;
            this.tbx_Brand.WordWrap = false;
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_Brand.Location = new System.Drawing.Point(16, 168);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(38, 17);
            this.lbl_Brand.TabIndex = 9;
            this.lbl_Brand.Text = "Brand";
            // 
            // tbx_SupplierID
            // 
            this.tbx_SupplierID.Location = new System.Drawing.Point(100, 296);
            this.tbx_SupplierID.Name = "tbx_SupplierID";
            this.tbx_SupplierID.Size = new System.Drawing.Size(150, 23);
            this.tbx_SupplierID.TabIndex = 14;
            this.tbx_SupplierID.WordWrap = false;
            // 
            // lbl_SupplierID
            // 
            this.lbl_SupplierID.AutoSize = true;
            this.lbl_SupplierID.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_SupplierID.Location = new System.Drawing.Point(16, 300);
            this.lbl_SupplierID.Name = "lbl_SupplierID";
            this.lbl_SupplierID.Size = new System.Drawing.Size(62, 17);
            this.lbl_SupplierID.TabIndex = 13;
            this.lbl_SupplierID.Text = "Supplier ID";
            // 
            // btn_FindSupplier
            // 
            this.btn_FindSupplier.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btn_FindSupplier.Location = new System.Drawing.Point(220, 296);
            this.btn_FindSupplier.Name = "btn_FindSupplier";
            this.btn_FindSupplier.Size = new System.Drawing.Size(32, 23);
            this.btn_FindSupplier.TabIndex = 15;
            this.btn_FindSupplier.Text = "...";
            this.btn_FindSupplier.UseVisualStyleBackColor = true;
            // 
            // tbx_ActiveIngredient
            // 
            this.tbx_ActiveIngredient.Location = new System.Drawing.Point(380, 52);
            this.tbx_ActiveIngredient.Name = "tbx_ActiveIngredient";
            this.tbx_ActiveIngredient.Size = new System.Drawing.Size(150, 23);
            this.tbx_ActiveIngredient.TabIndex = 18;
            this.tbx_ActiveIngredient.WordWrap = false;
            // 
            // lbl_ActiveIngredient
            // 
            this.lbl_ActiveIngredient.AutoSize = true;
            this.lbl_ActiveIngredient.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_ActiveIngredient.Location = new System.Drawing.Point(272, 56);
            this.lbl_ActiveIngredient.Name = "lbl_ActiveIngredient";
            this.lbl_ActiveIngredient.Size = new System.Drawing.Size(88, 17);
            this.lbl_ActiveIngredient.TabIndex = 17;
            this.lbl_ActiveIngredient.Text = "Active Ingredient";
            // 
            // tbx_StoreBelowTemp
            // 
            this.tbx_StoreBelowTemp.Location = new System.Drawing.Point(380, 80);
            this.tbx_StoreBelowTemp.Name = "tbx_StoreBelowTemp";
            this.tbx_StoreBelowTemp.Size = new System.Drawing.Size(150, 23);
            this.tbx_StoreBelowTemp.TabIndex = 20;
            this.tbx_StoreBelowTemp.WordWrap = false;
            // 
            // lbl_StoreBelowTemp
            // 
            this.lbl_StoreBelowTemp.AutoSize = true;
            this.lbl_StoreBelowTemp.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_StoreBelowTemp.Location = new System.Drawing.Point(272, 84);
            this.lbl_StoreBelowTemp.Name = "lbl_StoreBelowTemp";
            this.lbl_StoreBelowTemp.Size = new System.Drawing.Size(99, 17);
            this.lbl_StoreBelowTemp.TabIndex = 19;
            this.lbl_StoreBelowTemp.Text = "Store Below Temp";
            // 
            // gbx_SunlightSensitive
            // 
            this.gbx_SunlightSensitive.Controls.Add(this.rdo_SunlightSensitiveNo);
            this.gbx_SunlightSensitive.Controls.Add(this.rdo_SunlightSensitiveYes);
            this.gbx_SunlightSensitive.Location = new System.Drawing.Point(384, 94);
            this.gbx_SunlightSensitive.Name = "gbx_SunlightSensitive";
            this.gbx_SunlightSensitive.Size = new System.Drawing.Size(88, 40);
            this.gbx_SunlightSensitive.TabIndex = 21;
            this.gbx_SunlightSensitive.TabStop = false;
            // 
            // rdo_SunlightSensitiveNo
            // 
            this.rdo_SunlightSensitiveNo.AutoSize = true;
            this.rdo_SunlightSensitiveNo.Location = new System.Drawing.Point(44, 16);
            this.rdo_SunlightSensitiveNo.Name = "rdo_SunlightSensitiveNo";
            this.rdo_SunlightSensitiveNo.Size = new System.Drawing.Size(40, 21);
            this.rdo_SunlightSensitiveNo.TabIndex = 1;
            this.rdo_SunlightSensitiveNo.TabStop = true;
            this.rdo_SunlightSensitiveNo.Text = "No";
            this.rdo_SunlightSensitiveNo.UseVisualStyleBackColor = true;
            // 
            // rdo_SunlightSensitiveYes
            // 
            this.rdo_SunlightSensitiveYes.AutoSize = true;
            this.rdo_SunlightSensitiveYes.Location = new System.Drawing.Point(0, 16);
            this.rdo_SunlightSensitiveYes.Name = "rdo_SunlightSensitiveYes";
            this.rdo_SunlightSensitiveYes.Size = new System.Drawing.Size(46, 21);
            this.rdo_SunlightSensitiveYes.TabIndex = 0;
            this.rdo_SunlightSensitiveYes.TabStop = true;
            this.rdo_SunlightSensitiveYes.Text = "Yes";
            this.rdo_SunlightSensitiveYes.UseVisualStyleBackColor = true;
            // 
            // lbl_SunlightSensitive
            // 
            this.lbl_SunlightSensitive.AutoSize = true;
            this.lbl_SunlightSensitive.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_SunlightSensitive.Location = new System.Drawing.Point(272, 112);
            this.lbl_SunlightSensitive.Name = "lbl_SunlightSensitive";
            this.lbl_SunlightSensitive.Size = new System.Drawing.Size(99, 17);
            this.lbl_SunlightSensitive.TabIndex = 22;
            this.lbl_SunlightSensitive.Text = "Sunlight Sensitive?";
            // 
            // lbl_DosageFrequency
            // 
            this.lbl_DosageFrequency.AutoSize = true;
            this.lbl_DosageFrequency.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_DosageFrequency.Location = new System.Drawing.Point(272, 140);
            this.lbl_DosageFrequency.Name = "lbl_DosageFrequency";
            this.lbl_DosageFrequency.Size = new System.Drawing.Size(102, 17);
            this.lbl_DosageFrequency.TabIndex = 23;
            this.lbl_DosageFrequency.Text = "Dosage Frequency";
            // 
            // dgv_ItemManagement
            // 
            this.dgv_ItemManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemManagement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_ItemManagement.Location = new System.Drawing.Point(0, 332);
            this.dgv_ItemManagement.Name = "dgv_ItemManagement";
            this.dgv_ItemManagement.Size = new System.Drawing.Size(1134, 329);
            this.dgv_ItemManagement.TabIndex = 25;
            // 
            // cbx_ItemType
            // 
            this.cbx_ItemType.FormattingEnabled = true;
            this.cbx_ItemType.Location = new System.Drawing.Point(100, 80);
            this.cbx_ItemType.Name = "cbx_ItemType";
            this.cbx_ItemType.Size = new System.Drawing.Size(150, 24);
            this.cbx_ItemType.TabIndex = 26;
            // 
            // cbx_MainCategory
            // 
            this.cbx_MainCategory.FormattingEnabled = true;
            this.cbx_MainCategory.Location = new System.Drawing.Point(100, 108);
            this.cbx_MainCategory.Name = "cbx_MainCategory";
            this.cbx_MainCategory.Size = new System.Drawing.Size(150, 24);
            this.cbx_MainCategory.TabIndex = 27;
            // 
            // cbx_SubCategory
            // 
            this.cbx_SubCategory.FormattingEnabled = true;
            this.cbx_SubCategory.Location = new System.Drawing.Point(100, 136);
            this.cbx_SubCategory.Name = "cbx_SubCategory";
            this.cbx_SubCategory.Size = new System.Drawing.Size(150, 24);
            this.cbx_SubCategory.TabIndex = 28;
            // 
            // cbx_DosageFrequency
            // 
            this.cbx_DosageFrequency.FormattingEnabled = true;
            this.cbx_DosageFrequency.Location = new System.Drawing.Point(380, 136);
            this.cbx_DosageFrequency.Name = "cbx_DosageFrequency";
            this.cbx_DosageFrequency.Size = new System.Drawing.Size(150, 24);
            this.cbx_DosageFrequency.TabIndex = 29;
            // 
            // lbl_CauseDrowsiness
            // 
            this.lbl_CauseDrowsiness.AutoSize = true;
            this.lbl_CauseDrowsiness.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_CauseDrowsiness.Location = new System.Drawing.Point(272, 168);
            this.lbl_CauseDrowsiness.Name = "lbl_CauseDrowsiness";
            this.lbl_CauseDrowsiness.Size = new System.Drawing.Size(107, 17);
            this.lbl_CauseDrowsiness.TabIndex = 31;
            this.lbl_CauseDrowsiness.Text = "Cause Drowsiness?";
            // 
            // gbx_CauseDrowsiness
            // 
            this.gbx_CauseDrowsiness.Controls.Add(this.rdo_CauseDrowsinessNo);
            this.gbx_CauseDrowsiness.Controls.Add(this.rdo_CauseDrowsinessYes);
            this.gbx_CauseDrowsiness.Location = new System.Drawing.Point(384, 150);
            this.gbx_CauseDrowsiness.Name = "gbx_CauseDrowsiness";
            this.gbx_CauseDrowsiness.Size = new System.Drawing.Size(88, 40);
            this.gbx_CauseDrowsiness.TabIndex = 30;
            this.gbx_CauseDrowsiness.TabStop = false;
            // 
            // rdo_CauseDrowsinessNo
            // 
            this.rdo_CauseDrowsinessNo.AutoSize = true;
            this.rdo_CauseDrowsinessNo.Location = new System.Drawing.Point(44, 16);
            this.rdo_CauseDrowsinessNo.Name = "rdo_CauseDrowsinessNo";
            this.rdo_CauseDrowsinessNo.Size = new System.Drawing.Size(40, 21);
            this.rdo_CauseDrowsinessNo.TabIndex = 1;
            this.rdo_CauseDrowsinessNo.TabStop = true;
            this.rdo_CauseDrowsinessNo.Text = "No";
            this.rdo_CauseDrowsinessNo.UseVisualStyleBackColor = true;
            // 
            // rdo_CauseDrowsinessYes
            // 
            this.rdo_CauseDrowsinessYes.AutoSize = true;
            this.rdo_CauseDrowsinessYes.Location = new System.Drawing.Point(0, 16);
            this.rdo_CauseDrowsinessYes.Name = "rdo_CauseDrowsinessYes";
            this.rdo_CauseDrowsinessYes.Size = new System.Drawing.Size(46, 21);
            this.rdo_CauseDrowsinessYes.TabIndex = 0;
            this.rdo_CauseDrowsinessYes.TabStop = true;
            this.rdo_CauseDrowsinessYes.Text = "Yes";
            this.rdo_CauseDrowsinessYes.UseVisualStyleBackColor = true;
            // 
            // lbl_CauseGastric
            // 
            this.lbl_CauseGastric.AutoSize = true;
            this.lbl_CauseGastric.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_CauseGastric.Location = new System.Drawing.Point(272, 196);
            this.lbl_CauseGastric.Name = "lbl_CauseGastric";
            this.lbl_CauseGastric.Size = new System.Drawing.Size(84, 17);
            this.lbl_CauseGastric.TabIndex = 33;
            this.lbl_CauseGastric.Text = "Cause Gastric?";
            // 
            // gbx_CauseGastric
            // 
            this.gbx_CauseGastric.Controls.Add(this.rdo_CauseGastricNo);
            this.gbx_CauseGastric.Controls.Add(this.rdo_CauseGastricYes);
            this.gbx_CauseGastric.Location = new System.Drawing.Point(384, 178);
            this.gbx_CauseGastric.Name = "gbx_CauseGastric";
            this.gbx_CauseGastric.Size = new System.Drawing.Size(88, 40);
            this.gbx_CauseGastric.TabIndex = 32;
            this.gbx_CauseGastric.TabStop = false;
            // 
            // rdo_CauseGastricNo
            // 
            this.rdo_CauseGastricNo.AutoSize = true;
            this.rdo_CauseGastricNo.Location = new System.Drawing.Point(44, 16);
            this.rdo_CauseGastricNo.Name = "rdo_CauseGastricNo";
            this.rdo_CauseGastricNo.Size = new System.Drawing.Size(40, 21);
            this.rdo_CauseGastricNo.TabIndex = 1;
            this.rdo_CauseGastricNo.TabStop = true;
            this.rdo_CauseGastricNo.Text = "No";
            this.rdo_CauseGastricNo.UseVisualStyleBackColor = true;
            // 
            // rdo_CauseGastricYes
            // 
            this.rdo_CauseGastricYes.AutoSize = true;
            this.rdo_CauseGastricYes.Location = new System.Drawing.Point(0, 16);
            this.rdo_CauseGastricYes.Name = "rdo_CauseGastricYes";
            this.rdo_CauseGastricYes.Size = new System.Drawing.Size(46, 21);
            this.rdo_CauseGastricYes.TabIndex = 0;
            this.rdo_CauseGastricYes.TabStop = true;
            this.rdo_CauseGastricYes.Text = "Yes";
            this.rdo_CauseGastricYes.UseVisualStyleBackColor = true;
            // 
            // lbl_ByCourse
            // 
            this.lbl_ByCourse.AutoSize = true;
            this.lbl_ByCourse.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_ByCourse.Location = new System.Drawing.Point(272, 224);
            this.lbl_ByCourse.Name = "lbl_ByCourse";
            this.lbl_ByCourse.Size = new System.Drawing.Size(67, 17);
            this.lbl_ByCourse.TabIndex = 35;
            this.lbl_ByCourse.Text = "By Course?";
            // 
            // gbx_ByCourse
            // 
            this.gbx_ByCourse.Controls.Add(this.rdo_ByCourseNo);
            this.gbx_ByCourse.Controls.Add(this.rdo_ByCourseYes);
            this.gbx_ByCourse.Location = new System.Drawing.Point(384, 206);
            this.gbx_ByCourse.Name = "gbx_ByCourse";
            this.gbx_ByCourse.Size = new System.Drawing.Size(88, 40);
            this.gbx_ByCourse.TabIndex = 34;
            this.gbx_ByCourse.TabStop = false;
            // 
            // rdo_ByCourseNo
            // 
            this.rdo_ByCourseNo.AutoSize = true;
            this.rdo_ByCourseNo.Location = new System.Drawing.Point(44, 16);
            this.rdo_ByCourseNo.Name = "rdo_ByCourseNo";
            this.rdo_ByCourseNo.Size = new System.Drawing.Size(40, 21);
            this.rdo_ByCourseNo.TabIndex = 1;
            this.rdo_ByCourseNo.TabStop = true;
            this.rdo_ByCourseNo.Text = "No";
            this.rdo_ByCourseNo.UseVisualStyleBackColor = true;
            // 
            // rdo_ByCourseYes
            // 
            this.rdo_ByCourseYes.AutoSize = true;
            this.rdo_ByCourseYes.Location = new System.Drawing.Point(0, 16);
            this.rdo_ByCourseYes.Name = "rdo_ByCourseYes";
            this.rdo_ByCourseYes.Size = new System.Drawing.Size(46, 21);
            this.rdo_ByCourseYes.TabIndex = 0;
            this.rdo_ByCourseYes.TabStop = true;
            this.rdo_ByCourseYes.Text = "Yes";
            this.rdo_ByCourseYes.UseVisualStyleBackColor = true;
            // 
            // tbx_SalesPrice
            // 
            this.tbx_SalesPrice.Location = new System.Drawing.Point(380, 248);
            this.tbx_SalesPrice.Name = "tbx_SalesPrice";
            this.tbx_SalesPrice.Size = new System.Drawing.Size(150, 23);
            this.tbx_SalesPrice.TabIndex = 37;
            this.tbx_SalesPrice.WordWrap = false;
            // 
            // lbl_SalesPrice
            // 
            this.lbl_SalesPrice.AutoSize = true;
            this.lbl_SalesPrice.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_SalesPrice.Location = new System.Drawing.Point(272, 252);
            this.lbl_SalesPrice.Name = "lbl_SalesPrice";
            this.lbl_SalesPrice.Size = new System.Drawing.Size(65, 17);
            this.lbl_SalesPrice.TabIndex = 36;
            this.lbl_SalesPrice.Text = "Sales Price";
            // 
            // tbx_Remarks
            // 
            this.tbx_Remarks.Location = new System.Drawing.Point(380, 276);
            this.tbx_Remarks.Multiline = true;
            this.tbx_Remarks.Name = "tbx_Remarks";
            this.tbx_Remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Remarks.Size = new System.Drawing.Size(150, 40);
            this.tbx_Remarks.TabIndex = 39;
            this.tbx_Remarks.WordWrap = false;
            // 
            // lbl_Remarks
            // 
            this.lbl_Remarks.AutoSize = true;
            this.lbl_Remarks.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lbl_Remarks.Location = new System.Drawing.Point(272, 280);
            this.lbl_Remarks.Name = "lbl_Remarks";
            this.lbl_Remarks.Size = new System.Drawing.Size(54, 17);
            this.lbl_Remarks.TabIndex = 38;
            this.lbl_Remarks.Text = "Remarks";
            // 
            // Form_ItemManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.tbx_Remarks);
            this.Controls.Add(this.lbl_Remarks);
            this.Controls.Add(this.tbx_SalesPrice);
            this.Controls.Add(this.lbl_SalesPrice);
            this.Controls.Add(this.cbx_DosageFrequency);
            this.Controls.Add(this.gbx_CauseDrowsiness);
            this.Controls.Add(this.gbx_CauseGastric);
            this.Controls.Add(this.lbl_ByCourse);
            this.Controls.Add(this.gbx_ByCourse);
            this.Controls.Add(this.lbl_CauseGastric);
            this.Controls.Add(this.lbl_CauseDrowsiness);
            this.Controls.Add(this.cbx_SubCategory);
            this.Controls.Add(this.cbx_MainCategory);
            this.Controls.Add(this.cbx_ItemType);
            this.Controls.Add(this.dgv_ItemManagement);
            this.Controls.Add(this.lbl_DosageFrequency);
            this.Controls.Add(this.tbx_StoreBelowTemp);
            this.Controls.Add(this.lbl_SunlightSensitive);
            this.Controls.Add(this.gbx_SunlightSensitive);
            this.Controls.Add(this.lbl_StoreBelowTemp);
            this.Controls.Add(this.tbx_ActiveIngredient);
            this.Controls.Add(this.lbl_ActiveIngredient);
            this.Controls.Add(this.btn_FindSupplier);
            this.Controls.Add(this.tbx_SupplierID);
            this.Controls.Add(this.lbl_SupplierID);
            this.Controls.Add(this.tbx_Description);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.tbx_Brand);
            this.Controls.Add(this.lbl_Brand);
            this.Controls.Add(this.lbl_SubCategory);
            this.Controls.Add(this.lbl_MainCategory);
            this.Controls.Add(this.lbl_ItemType);
            this.Controls.Add(this.tbx_ItemID);
            this.Controls.Add(this.lbl_ItemID);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Form_ItemManagement";
            this.Text = "Form_ItemManagement";
            this.gbx_SunlightSensitive.ResumeLayout(false);
            this.gbx_SunlightSensitive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemManagement)).EndInit();
            this.gbx_CauseDrowsiness.ResumeLayout(false);
            this.gbx_CauseDrowsiness.PerformLayout();
            this.gbx_CauseGastric.ResumeLayout(false);
            this.gbx_CauseGastric.PerformLayout();
            this.gbx_ByCourse.ResumeLayout(false);
            this.gbx_ByCourse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_ItemID;
        private System.Windows.Forms.TextBox tbx_ItemID;
        private System.Windows.Forms.Label lbl_ItemType;
        private System.Windows.Forms.Label lbl_SubCategory;
        private System.Windows.Forms.Label lbl_MainCategory;
        private System.Windows.Forms.TextBox tbx_Description;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox tbx_Brand;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.TextBox tbx_SupplierID;
        private System.Windows.Forms.Label lbl_SupplierID;
        private System.Windows.Forms.Button btn_FindSupplier;
        private System.Windows.Forms.TextBox tbx_ActiveIngredient;
        private System.Windows.Forms.Label lbl_ActiveIngredient;
        private System.Windows.Forms.TextBox tbx_StoreBelowTemp;
        private System.Windows.Forms.Label lbl_StoreBelowTemp;
        private System.Windows.Forms.GroupBox gbx_SunlightSensitive;
        private System.Windows.Forms.RadioButton rdo_SunlightSensitiveNo;
        private System.Windows.Forms.RadioButton rdo_SunlightSensitiveYes;
        private System.Windows.Forms.Label lbl_SunlightSensitive;
        private System.Windows.Forms.Label lbl_DosageFrequency;
        private System.Windows.Forms.DataGridView dgv_ItemManagement;
        private System.Windows.Forms.ComboBox cbx_ItemType;
        private System.Windows.Forms.ComboBox cbx_MainCategory;
        private System.Windows.Forms.ComboBox cbx_SubCategory;
        private System.Windows.Forms.ComboBox cbx_DosageFrequency;
        private System.Windows.Forms.Label lbl_CauseDrowsiness;
        private System.Windows.Forms.GroupBox gbx_CauseDrowsiness;
        private System.Windows.Forms.RadioButton rdo_CauseDrowsinessNo;
        private System.Windows.Forms.RadioButton rdo_CauseDrowsinessYes;
        private System.Windows.Forms.Label lbl_CauseGastric;
        private System.Windows.Forms.GroupBox gbx_CauseGastric;
        private System.Windows.Forms.RadioButton rdo_CauseGastricNo;
        private System.Windows.Forms.RadioButton rdo_CauseGastricYes;
        private System.Windows.Forms.Label lbl_ByCourse;
        private System.Windows.Forms.GroupBox gbx_ByCourse;
        private System.Windows.Forms.RadioButton rdo_ByCourseNo;
        private System.Windows.Forms.RadioButton rdo_ByCourseYes;
        private System.Windows.Forms.TextBox tbx_SalesPrice;
        private System.Windows.Forms.Label lbl_SalesPrice;
        private System.Windows.Forms.TextBox tbx_Remarks;
        private System.Windows.Forms.Label lbl_Remarks;
    }
}