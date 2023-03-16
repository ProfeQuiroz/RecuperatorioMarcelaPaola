
namespace POOTriangulos.Windows
{
    partial class NuevoTriangulo
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
            this.components = new System.ComponentModel.Container();
            this.RayasRadioButton = new System.Windows.Forms.RadioButton();
            this.PuntosRadioButton = new System.Windows.Forms.RadioButton();
            this.ContinuoRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ladoatextBox = new System.Windows.Forms.TextBox();
            this.ladobtextBox = new System.Windows.Forms.TextBox();
            this.ladoctextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.Confirmarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // RayasRadioButton
            // 
            this.RayasRadioButton.AutoSize = true;
            this.RayasRadioButton.Checked = true;
            this.RayasRadioButton.Location = new System.Drawing.Point(113, 69);
            this.RayasRadioButton.Name = "RayasRadioButton";
            this.RayasRadioButton.Size = new System.Drawing.Size(55, 17);
            this.RayasRadioButton.TabIndex = 0;
            this.RayasRadioButton.TabStop = true;
            this.RayasRadioButton.Text = "Rayas";
            this.RayasRadioButton.UseVisualStyleBackColor = true;
            // 
            // PuntosRadioButton
            // 
            this.PuntosRadioButton.AutoSize = true;
            this.PuntosRadioButton.Location = new System.Drawing.Point(207, 69);
            this.PuntosRadioButton.Name = "PuntosRadioButton";
            this.PuntosRadioButton.Size = new System.Drawing.Size(58, 17);
            this.PuntosRadioButton.TabIndex = 1;
            this.PuntosRadioButton.Text = "Puntos";
            this.PuntosRadioButton.UseVisualStyleBackColor = true;
            this.PuntosRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ContinuoRadioButton
            // 
            this.ContinuoRadioButton.AutoSize = true;
            this.ContinuoRadioButton.Location = new System.Drawing.Point(303, 69);
            this.ContinuoRadioButton.Name = "ContinuoRadioButton";
            this.ContinuoRadioButton.Size = new System.Drawing.Size(67, 17);
            this.ContinuoRadioButton.TabIndex = 2;
            this.ContinuoRadioButton.Text = "Continuo";
            this.ContinuoRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de trazo";
            // 
            // ladoatextBox
            // 
            this.ladoatextBox.Location = new System.Drawing.Point(68, 147);
            this.ladoatextBox.Name = "ladoatextBox";
            this.ladoatextBox.Size = new System.Drawing.Size(100, 20);
            this.ladoatextBox.TabIndex = 4;
            // 
            // ladobtextBox
            // 
            this.ladobtextBox.Location = new System.Drawing.Point(273, 144);
            this.ladobtextBox.Name = "ladobtextBox";
            this.ladobtextBox.Size = new System.Drawing.Size(100, 20);
            this.ladobtextBox.TabIndex = 5;
            // 
            // ladoctextBox
            // 
            this.ladoctextBox.Location = new System.Drawing.Point(456, 144);
            this.ladoctextBox.Name = "ladoctextBox";
            this.ladoctextBox.Size = new System.Drawing.Size(100, 20);
            this.ladoctextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "lado a";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "lado b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "lado c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(94, 236);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorComboBox.TabIndex = 11;
            // 
            // Confirmarbutton
            // 
            this.Confirmarbutton.Location = new System.Drawing.Point(312, 234);
            this.Confirmarbutton.Name = "Confirmarbutton";
            this.Confirmarbutton.Size = new System.Drawing.Size(75, 23);
            this.Confirmarbutton.TabIndex = 12;
            this.Confirmarbutton.Text = "Confirmar";
            this.Confirmarbutton.UseVisualStyleBackColor = true;
            this.Confirmarbutton.Click += new System.EventHandler(this.Confirmarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(456, 234);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton.TabIndex = 13;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // NuevoTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 274);
            this.ControlBox = false;
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Confirmarbutton);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ladoctextBox);
            this.Controls.Add(this.ladobtextBox);
            this.Controls.Add(this.ladoatextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContinuoRadioButton);
            this.Controls.Add(this.PuntosRadioButton);
            this.Controls.Add(this.RayasRadioButton);
            this.MaximumSize = new System.Drawing.Size(592, 313);
            this.MinimumSize = new System.Drawing.Size(592, 313);
            this.Name = "NuevoTriangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoTriangulo";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RayasRadioButton;
        private System.Windows.Forms.RadioButton PuntosRadioButton;
        private System.Windows.Forms.RadioButton ContinuoRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ladoatextBox;
        private System.Windows.Forms.TextBox ladobtextBox;
        private System.Windows.Forms.TextBox ladoctextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Button Confirmarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}