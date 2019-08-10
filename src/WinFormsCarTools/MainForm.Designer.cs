namespace WinFormsCarTools
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gaugeControl1 = new WinFormsCarTools.GaugeControl();
            this.gForceVisualizerControl1 = new WinFormsCarTools.GForceVisualizerControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gaugeControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gForceVisualizerControl1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gaugeControl1.Location = new System.Drawing.Point(585, 11);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(519, 481);
            this.gaugeControl1.TabIndex = 0;
            this.gaugeControl1.Text = "gaugeControl1";
            // 
            // gForceVisualizerControl1
            // 
            this.gForceVisualizerControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gForceVisualizerControl1.Location = new System.Drawing.Point(18, 3);
            this.gForceVisualizerControl1.Name = "gForceVisualizerControl1";
            this.gForceVisualizerControl1.Size = new System.Drawing.Size(526, 497);
            this.gForceVisualizerControl1.TabIndex = 1;
            this.gForceVisualizerControl1.Text = "gForceVisualizerControl1";
            this.gForceVisualizerControl1.XGforce = 0F;
            this.gForceVisualizerControl1.YGforce = 0F;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 582);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WinForms CarTools";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GaugeControl gaugeControl1;
        private GForceVisualizerControl gForceVisualizerControl1;
    }
}

