
namespace translate.Forms
{
    partial class EmptyDictForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empty_dict = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите языки нового  словаря";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Язык 1";
            // 
            // tb_1
            // 
            this.tb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_1.Location = new System.Drawing.Point(228, 133);
            this.tb_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(526, 48);
            this.tb_1.TabIndex = 5;
            // 
            // tb_2
            // 
            this.tb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_2.Location = new System.Drawing.Point(229, 201);
            this.tb_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(526, 48);
            this.tb_2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Язык 2";
            // 
            // empty_dict
            // 
            this.empty_dict.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empty_dict.Location = new System.Drawing.Point(266, 291);
            this.empty_dict.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.empty_dict.Name = "empty_dict";
            this.empty_dict.Size = new System.Drawing.Size(266, 69);
            this.empty_dict.TabIndex = 8;
            this.empty_dict.Text = "Применить";
            this.empty_dict.UseVisualStyleBackColor = true;
            this.empty_dict.Click += new System.EventHandler(this.empty_dict_Click);
            // 
            // EmptyDictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.empty_dict);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmptyDictForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового пустого словаря";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button empty_dict;
    }
}