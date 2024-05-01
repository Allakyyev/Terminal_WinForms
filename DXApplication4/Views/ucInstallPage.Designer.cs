namespace DXApplication4 {
    partial class ucInstallPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_pay = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 50F);
            this.label1.Location = new System.Drawing.Point(251, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 121);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 50F);
            this.label2.Location = new System.Drawing.Point(379, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 121);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jemi:";
            // 
            // button_pay
            // 
            this.button_pay.BackColor = System.Drawing.Color.PaleGreen;
            this.button_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pay.Font = new System.Drawing.Font("Tahoma", 35F);
            this.button_pay.Location = new System.Drawing.Point(445, 508);
            this.button_pay.Name = "button_pay";
            this.button_pay.Size = new System.Drawing.Size(556, 187);
            this.button_pay.TabIndex = 3;
            this.button_pay.Text = "Toleg gechir";
            this.button_pay.UseVisualStyleBackColor = false;
            this.button_pay.Click += new System.EventHandler(this.button_pay_Click);
            // 
            // label_total
            // 
            this.label_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Tahoma", 50F);
            this.label_total.ForeColor = System.Drawing.Color.Green;
            this.label_total.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.label_total.Location = new System.Drawing.Point(713, 329);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(330, 121);
            this.label_total.TabIndex = 4;
            this.label_total.Text = "0 man";
            // 
            // ucInstallPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.button_pay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucInstallPage";
            this.Size = new System.Drawing.Size(1715, 954);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_pay;
        private System.Windows.Forms.Label label_total;
    }
}
