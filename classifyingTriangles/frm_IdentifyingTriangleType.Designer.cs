
namespace classifyingTriangles
{
    partial class frm_IdentifyingTriangleType
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
            this.lbl_Side1 = new System.Windows.Forms.Label();
            this.lbl_Side2 = new System.Windows.Forms.Label();
            this.lbl_Side3 = new System.Windows.Forms.Label();
            this.txt_Side1 = new System.Windows.Forms.TextBox();
            this.txt_Side2 = new System.Windows.Forms.TextBox();
            this.txt_Side3 = new System.Windows.Forms.TextBox();
            this.btn_CheckType = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_ReturnMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Side1
            // 
            this.lbl_Side1.AutoSize = true;
            this.lbl_Side1.Location = new System.Drawing.Point(30, 31);
            this.lbl_Side1.Name = "lbl_Side1";
            this.lbl_Side1.Size = new System.Drawing.Size(143, 17);
            this.lbl_Side1.TabIndex = 0;
            this.lbl_Side1.Text = "Enter length of side 1";
            // 
            // lbl_Side2
            // 
            this.lbl_Side2.AutoSize = true;
            this.lbl_Side2.Location = new System.Drawing.Point(30, 62);
            this.lbl_Side2.Name = "lbl_Side2";
            this.lbl_Side2.Size = new System.Drawing.Size(143, 17);
            this.lbl_Side2.TabIndex = 1;
            this.lbl_Side2.Text = "Enter length of side 2";
            // 
            // lbl_Side3
            // 
            this.lbl_Side3.AutoSize = true;
            this.lbl_Side3.Location = new System.Drawing.Point(30, 94);
            this.lbl_Side3.Name = "lbl_Side3";
            this.lbl_Side3.Size = new System.Drawing.Size(143, 17);
            this.lbl_Side3.TabIndex = 2;
            this.lbl_Side3.Text = "Enter length of side 3";
            // 
            // txt_Side1
            // 
            this.txt_Side1.Location = new System.Drawing.Point(193, 28);
            this.txt_Side1.Name = "txt_Side1";
            this.txt_Side1.Size = new System.Drawing.Size(136, 22);
            this.txt_Side1.TabIndex = 3;
            // 
            // txt_Side2
            // 
            this.txt_Side2.Location = new System.Drawing.Point(192, 62);
            this.txt_Side2.Name = "txt_Side2";
            this.txt_Side2.Size = new System.Drawing.Size(136, 22);
            this.txt_Side2.TabIndex = 4;
            // 
            // txt_Side3
            // 
            this.txt_Side3.Location = new System.Drawing.Point(192, 94);
            this.txt_Side3.Name = "txt_Side3";
            this.txt_Side3.Size = new System.Drawing.Size(136, 22);
            this.txt_Side3.TabIndex = 5;
            // 
            // btn_CheckType
            // 
            this.btn_CheckType.Location = new System.Drawing.Point(146, 140);
            this.btn_CheckType.Name = "btn_CheckType";
            this.btn_CheckType.Size = new System.Drawing.Size(118, 33);
            this.btn_CheckType.TabIndex = 6;
            this.btn_CheckType.Text = "Check Type";
            this.btn_CheckType.UseVisualStyleBackColor = true;
            this.btn_CheckType.Click += new System.EventHandler(this.btn_CheckType_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(270, 140);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(73, 33);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_ReturnMessage
            // 
            this.txt_ReturnMessage.Location = new System.Drawing.Point(0, 179);
            this.txt_ReturnMessage.Multiline = true;
            this.txt_ReturnMessage.Name = "txt_ReturnMessage";
            this.txt_ReturnMessage.ReadOnly = true;
            this.txt_ReturnMessage.Size = new System.Drawing.Size(417, 81);
            this.txt_ReturnMessage.TabIndex = 8;
            // 
            // frm_IdentifyingTriangleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 264);
            this.Controls.Add(this.txt_ReturnMessage);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_CheckType);
            this.Controls.Add(this.txt_Side3);
            this.Controls.Add(this.txt_Side2);
            this.Controls.Add(this.txt_Side1);
            this.Controls.Add(this.lbl_Side3);
            this.Controls.Add(this.lbl_Side2);
            this.Controls.Add(this.lbl_Side1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_IdentifyingTriangleType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Identifying Triangle Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Side1;
        private System.Windows.Forms.Label lbl_Side2;
        private System.Windows.Forms.Label lbl_Side3;
        public System.Windows.Forms.TextBox txt_Side1;
        public System.Windows.Forms.TextBox txt_Side2;
        public System.Windows.Forms.TextBox txt_Side3;
        public System.Windows.Forms.Button btn_CheckType;
        public System.Windows.Forms.Button btn_Clear;
        public System.Windows.Forms.TextBox txt_ReturnMessage;
    }
}