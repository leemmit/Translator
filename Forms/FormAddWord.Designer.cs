
namespace translate.Forms
{
    partial class FormAddWord
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
            this.fa_cb_to = new System.Windows.Forms.ComboBox();
            this.fa_cb_from = new System.Windows.Forms.ComboBox();
            this.fa_tb_to = new System.Windows.Forms.TextBox();
            this.fa_btn_add = new System.Windows.Forms.Button();
            this.fa_tb_from = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fa_btn_changeLang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавить новое слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите перевод слова";
            // 
            // fa_cb_to
            // 
            this.fa_cb_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fa_cb_to.FormattingEnabled = true;
            this.fa_cb_to.Location = new System.Drawing.Point(320, 91);
            this.fa_cb_to.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fa_cb_to.Name = "fa_cb_to";
            this.fa_cb_to.Size = new System.Drawing.Size(191, 28);
            this.fa_cb_to.TabIndex = 14;
            // 
            // fa_cb_from
            // 
            this.fa_cb_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fa_cb_from.FormattingEnabled = true;
            this.fa_cb_from.Location = new System.Drawing.Point(22, 91);
            this.fa_cb_from.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fa_cb_from.Name = "fa_cb_from";
            this.fa_cb_from.Size = new System.Drawing.Size(191, 28);
            this.fa_cb_from.TabIndex = 13;
            // 
            // fa_tb_to
            // 
            this.fa_tb_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fa_tb_to.Location = new System.Drawing.Point(283, 136);
            this.fa_tb_to.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fa_tb_to.Multiline = true;
            this.fa_tb_to.Name = "fa_tb_to";
            this.fa_tb_to.Size = new System.Drawing.Size(228, 27);
            this.fa_tb_to.TabIndex = 12;
            this.fa_tb_to.TextChanged += new System.EventHandler(this.fa_tb_to_TextChanged);
            this.fa_tb_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fa_tb_to_KeyPress);
            // 
            // fa_btn_add
            // 
            this.fa_btn_add.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fa_btn_add.Location = new System.Drawing.Point(283, 178);
            this.fa_btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fa_btn_add.Name = "fa_btn_add";
            this.fa_btn_add.Size = new System.Drawing.Size(90, 33);
            this.fa_btn_add.TabIndex = 11;
            this.fa_btn_add.Text = "Добавить";
            this.fa_btn_add.UseVisualStyleBackColor = true;
            this.fa_btn_add.Click += new System.EventHandler(this.fa_btn_add_Click);
            // 
            // fa_tb_from
            // 
            this.fa_tb_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fa_tb_from.Location = new System.Drawing.Point(22, 136);
            this.fa_tb_from.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fa_tb_from.Multiline = true;
            this.fa_tb_from.Name = "fa_tb_from";
            this.fa_tb_from.Size = new System.Drawing.Size(231, 27);
            this.fa_tb_from.TabIndex = 10;
            this.fa_tb_from.TextChanged += new System.EventHandler(this.fa_tb_from_TextChanged);
            this.fa_tb_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fa_tb_from_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(421, 178);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fa_btn_changeLang
            // 
            this.fa_btn_changeLang.Font = new System.Drawing.Font("Calibri", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fa_btn_changeLang.Image = global::perevodchik.Properties.Resources.icons8_change_24;
            this.fa_btn_changeLang.Location = new System.Drawing.Point(230, 91);
            this.fa_btn_changeLang.Name = "fa_btn_changeLang";
            this.fa_btn_changeLang.Size = new System.Drawing.Size(76, 28);
            this.fa_btn_changeLang.TabIndex = 18;
            this.fa_btn_changeLang.UseVisualStyleBackColor = true;
            this.fa_btn_changeLang.Click += new System.EventHandler(this.fa_btn_changeLang_Click);
            // 
            // FormAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 227);
            this.Controls.Add(this.fa_btn_changeLang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fa_cb_to);
            this.Controls.Add(this.fa_cb_from);
            this.Controls.Add(this.fa_tb_to);
            this.Controls.Add(this.fa_btn_add);
            this.Controls.Add(this.fa_tb_from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fa_cb_to;
        private System.Windows.Forms.ComboBox fa_cb_from;
        private System.Windows.Forms.TextBox fa_tb_to;
        private System.Windows.Forms.Button fa_btn_add;
        private System.Windows.Forms.TextBox fa_tb_from;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button fa_btn_changeLang;
    }
}