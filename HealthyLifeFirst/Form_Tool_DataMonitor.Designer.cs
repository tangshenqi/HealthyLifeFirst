namespace HealthyLifeFirst
{
    partial class Form_Tool_DataMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Tool_DataMonitor));
            this.cbx_TableSelector = new System.Windows.Forms.ComboBox();
            this.dgv_DisplayRecord = new System.Windows.Forms.DataGridView();
            this.btn_RefreshDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DisplayRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_TableSelector
            // 
            this.cbx_TableSelector.FormattingEnabled = true;
            this.cbx_TableSelector.Location = new System.Drawing.Point(8, 8);
            this.cbx_TableSelector.Name = "cbx_TableSelector";
            this.cbx_TableSelector.Size = new System.Drawing.Size(200, 24);
            this.cbx_TableSelector.TabIndex = 0;
            // 
            // dgv_DisplayRecord
            // 
            this.dgv_DisplayRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DisplayRecord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_DisplayRecord.Location = new System.Drawing.Point(0, 44);
            this.dgv_DisplayRecord.Name = "dgv_DisplayRecord";
            this.dgv_DisplayRecord.Size = new System.Drawing.Size(1184, 717);
            this.dgv_DisplayRecord.TabIndex = 1;
            // 
            // btn_RefreshDGV
            // 
            this.btn_RefreshDGV.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshDGV.Location = new System.Drawing.Point(212, 8);
            this.btn_RefreshDGV.Name = "btn_RefreshDGV";
            this.btn_RefreshDGV.Size = new System.Drawing.Size(75, 25);
            this.btn_RefreshDGV.TabIndex = 2;
            this.btn_RefreshDGV.Text = "Go";
            this.btn_RefreshDGV.UseVisualStyleBackColor = true;
            this.btn_RefreshDGV.Click += new System.EventHandler(this.btn_RefreshDGV_Click);
            // 
            // Form_Tool_DataMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btn_RefreshDGV);
            this.Controls.Add(this.dgv_DisplayRecord);
            this.Controls.Add(this.cbx_TableSelector);
            this.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Tool_DataMonitor";
            this.Text = "Data Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DisplayRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_TableSelector;
        private System.Windows.Forms.DataGridView dgv_DisplayRecord;
        private System.Windows.Forms.Button btn_RefreshDGV;
    }
}