
namespace Administracion_pizzeria
{
    partial class formulario_login
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
            this.cb_usuariologin = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_contraseñalogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_aceptarlogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_usuariologin
            // 
            this.cb_usuariologin.FormattingEnabled = true;
            this.cb_usuariologin.Location = new System.Drawing.Point(145, 56);
            this.cb_usuariologin.Name = "cb_usuariologin";
            this.cb_usuariologin.Size = new System.Drawing.Size(191, 21);
            this.cb_usuariologin.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 192);
            this.panel1.TabIndex = 1;
            // 
            // tb_contraseñalogin
            // 
            this.tb_contraseñalogin.Location = new System.Drawing.Point(145, 95);
            this.tb_contraseñalogin.Name = "tb_contraseñalogin";
            this.tb_contraseñalogin.Size = new System.Drawing.Size(191, 20);
            this.tb_contraseñalogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // bt_aceptarlogin
            // 
            this.bt_aceptarlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.bt_aceptarlogin.FlatAppearance.BorderSize = 0;
            this.bt_aceptarlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_aceptarlogin.ForeColor = System.Drawing.Color.Black;
            this.bt_aceptarlogin.Location = new System.Drawing.Point(187, 135);
            this.bt_aceptarlogin.Name = "bt_aceptarlogin";
            this.bt_aceptarlogin.Size = new System.Drawing.Size(120, 30);
            this.bt_aceptarlogin.TabIndex = 3;
            this.bt_aceptarlogin.Text = "Aceptar";
            this.bt_aceptarlogin.UseVisualStyleBackColor = false;
            // 
            // formulario_login
            // 
            this.AcceptButton = this.bt_aceptarlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(164)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(353, 192);
            this.Controls.Add(this.bt_aceptarlogin);
            this.Controls.Add(this.tb_contraseñalogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_usuariologin);
            this.Name = "formulario_login";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_usuariologin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_contraseñalogin;
        private System.Windows.Forms.Button bt_aceptarlogin;
    }
}