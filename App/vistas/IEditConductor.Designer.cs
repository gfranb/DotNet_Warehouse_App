﻿namespace App.vistas
{
    partial class IEditConductor
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
            this.panelDatosConductor = new System.Windows.Forms.Panel();
            this.edit_conductor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.out_permiso_conductor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.out_domicilio_conductor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.out_apellido_conductor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.out_nombre_conductor = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.conductorNombre = new System.Windows.Forms.Label();
            this.in_id_conductor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDatosConductor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatosConductor
            // 
            this.panelDatosConductor.Controls.Add(this.edit_conductor);
            this.panelDatosConductor.Controls.Add(this.label3);
            this.panelDatosConductor.Controls.Add(this.out_permiso_conductor);
            this.panelDatosConductor.Controls.Add(this.label2);
            this.panelDatosConductor.Controls.Add(this.out_domicilio_conductor);
            this.panelDatosConductor.Controls.Add(this.label1);
            this.panelDatosConductor.Controls.Add(this.out_apellido_conductor);
            this.panelDatosConductor.Controls.Add(this.label4);
            this.panelDatosConductor.Controls.Add(this.out_nombre_conductor);
            this.panelDatosConductor.Location = new System.Drawing.Point(165, 164);
            this.panelDatosConductor.Margin = new System.Windows.Forms.Padding(4);
            this.panelDatosConductor.Name = "panelDatosConductor";
            this.panelDatosConductor.Size = new System.Drawing.Size(576, 347);
            this.panelDatosConductor.TabIndex = 29;
            // 
            // edit_conductor
            // 
            this.edit_conductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.edit_conductor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.edit_conductor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.edit_conductor.ForeColor = System.Drawing.Color.White;
            this.edit_conductor.Location = new System.Drawing.Point(204, 246);
            this.edit_conductor.Margin = new System.Windows.Forms.Padding(4);
            this.edit_conductor.Name = "edit_conductor";
            this.edit_conductor.Size = new System.Drawing.Size(191, 52);
            this.edit_conductor.TabIndex = 18;
            this.edit_conductor.Text = "Editar";
            this.edit_conductor.UseVisualStyleBackColor = false;
            this.edit_conductor.Click += new System.EventHandler(this.edit_conductor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Permiso de conducir";
            // 
            // out_permiso_conductor
            // 
            this.out_permiso_conductor.Location = new System.Drawing.Point(204, 137);
            this.out_permiso_conductor.Margin = new System.Windows.Forms.Padding(4);
            this.out_permiso_conductor.Name = "out_permiso_conductor";
            this.out_permiso_conductor.Size = new System.Drawing.Size(331, 22);
            this.out_permiso_conductor.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Domicilio";
            // 
            // out_domicilio_conductor
            // 
            this.out_domicilio_conductor.Location = new System.Drawing.Point(204, 105);
            this.out_domicilio_conductor.Margin = new System.Windows.Forms.Padding(4);
            this.out_domicilio_conductor.Name = "out_domicilio_conductor";
            this.out_domicilio_conductor.Size = new System.Drawing.Size(331, 22);
            this.out_domicilio_conductor.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Apellido";
            // 
            // out_apellido_conductor
            // 
            this.out_apellido_conductor.Location = new System.Drawing.Point(204, 73);
            this.out_apellido_conductor.Margin = new System.Windows.Forms.Padding(4);
            this.out_apellido_conductor.Name = "out_apellido_conductor";
            this.out_apellido_conductor.Size = new System.Drawing.Size(331, 22);
            this.out_apellido_conductor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre";
            // 
            // out_nombre_conductor
            // 
            this.out_nombre_conductor.Location = new System.Drawing.Point(204, 41);
            this.out_nombre_conductor.Margin = new System.Windows.Forms.Padding(4);
            this.out_nombre_conductor.Name = "out_nombre_conductor";
            this.out_nombre_conductor.Size = new System.Drawing.Size(331, 22);
            this.out_nombre_conductor.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(603, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 54);
            this.button2.TabIndex = 28;
            this.button2.Text = "Buscar Conductor";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // conductorNombre
            // 
            this.conductorNombre.AutoSize = true;
            this.conductorNombre.Location = new System.Drawing.Point(161, 121);
            this.conductorNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conductorNombre.Name = "conductorNombre";
            this.conductorNombre.Size = new System.Drawing.Size(84, 16);
            this.conductorNombre.TabIndex = 27;
            this.conductorNombre.Text = "ID Conductor";
            // 
            // in_id_conductor
            // 
            this.in_id_conductor.Location = new System.Drawing.Point(263, 117);
            this.in_id_conductor.Margin = new System.Windows.Forms.Padding(4);
            this.in_id_conductor.Name = "in_id_conductor";
            this.in_id_conductor.Size = new System.Drawing.Size(331, 22);
            this.in_id_conductor.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IEditConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 620);
            this.Controls.Add(this.panelDatosConductor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.conductorNombre);
            this.Controls.Add(this.in_id_conductor);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IEditConductor";
            this.Text = "IEditConductor";
            this.panelDatosConductor.ResumeLayout(false);
            this.panelDatosConductor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDatosConductor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label conductorNombre;
        private System.Windows.Forms.TextBox in_id_conductor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button edit_conductor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox out_permiso_conductor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox out_domicilio_conductor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox out_apellido_conductor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox out_nombre_conductor;
    }
}