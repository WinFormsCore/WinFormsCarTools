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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gyroXLabel = new System.Windows.Forms.Label();
            this.gyroYLabel = new System.Windows.Forms.Label();
            this.gyroZLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.DialLength = 20F;
            this.gaugeControl1.DialOffsetAngle = 90F;
            this.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gaugeControl1.Location = new System.Drawing.Point(566, 3);
            this.gaugeControl1.MaxValue = 260F;
            this.gaugeControl1.MinValue = 0F;
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.SeperationStepValue = 20F;
            this.gaugeControl1.Size = new System.Drawing.Size(558, 448);
            this.gaugeControl1.TabIndex = 0;
            this.gaugeControl1.Text = "gaugeControl1";
            this.gaugeControl1.UnitTextOffset = 45F;
            this.gaugeControl1.Value = 0F;
            this.gaugeControl1.ValueHandEnd = 140F;
            this.gaugeControl1.ValueHandStart = 30F;
            // 
            // gForceVisualizerControl1
            // 
            this.gForceVisualizerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gForceVisualizerControl1.Location = new System.Drawing.Point(3, 3);
            this.gForceVisualizerControl1.Name = "gForceVisualizerControl1";
            this.gForceVisualizerControl1.Size = new System.Drawing.Size(557, 448);
            this.gForceVisualizerControl1.TabIndex = 1;
            this.gForceVisualizerControl1.Text = "gForceVisualizerControl1";
            this.gForceVisualizerControl1.XGforce = 0F;
            this.gForceVisualizerControl1.YGforce = 0F;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.gyroZLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.gyroYLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gyroXLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 457);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1121, 94);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // gyroXLabel
            // 
            this.gyroXLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gyroXLabel.AutoSize = true;
            this.gyroXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gyroXLabel.Location = new System.Drawing.Point(119, 24);
            this.gyroXLabel.Name = "gyroXLabel";
            this.gyroXLabel.Size = new System.Drawing.Size(134, 46);
            this.gyroXLabel.TabIndex = 0;
            this.gyroXLabel.Text = "GyroX";
            // 
            // gyroYLabel
            // 
            this.gyroYLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gyroYLabel.AutoSize = true;
            this.gyroYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gyroYLabel.Location = new System.Drawing.Point(493, 24);
            this.gyroYLabel.Name = "gyroYLabel";
            this.gyroYLabel.Size = new System.Drawing.Size(133, 46);
            this.gyroYLabel.TabIndex = 1;
            this.gyroYLabel.Text = "GyroY";
            // 
            // gyroZLabel
            // 
            this.gyroZLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gyroZLabel.AutoSize = true;
            this.gyroZLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gyroZLabel.Location = new System.Drawing.Point(868, 24);
            this.gyroZLabel.Name = "gyroZLabel";
            this.gyroZLabel.Size = new System.Drawing.Size(131, 46);
            this.gyroZLabel.TabIndex = 2;
            this.gyroZLabel.Text = "GyroZ";
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GaugeControl gaugeControl1;
        private GForceVisualizerControl gForceVisualizerControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label gyroZLabel;
        private System.Windows.Forms.Label gyroYLabel;
        private System.Windows.Forms.Label gyroXLabel;
    }
}

