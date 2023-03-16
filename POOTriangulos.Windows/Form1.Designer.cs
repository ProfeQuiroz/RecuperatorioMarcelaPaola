
namespace POOTriangulos.Windows
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CantidaddeTriangulosTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OrdenartoolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ascendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltrartoolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.TriangulosDataGridView = new System.Windows.Forms.DataGridView();
            this.ColLadoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colladob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLadoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColColordeRelleno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipodeTringulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriangulosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CantidaddeTriangulosTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TriangulosDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 87;
            this.splitContainer1.TabIndex = 0;
            // 
            // CantidaddeTriangulosTextBox
            // 
            this.CantidaddeTriangulosTextBox.Location = new System.Drawing.Point(451, 59);
            this.CantidaddeTriangulosTextBox.Name = "CantidaddeTriangulosTextBox";
            this.CantidaddeTriangulosTextBox.ReadOnly = true;
            this.CantidaddeTriangulosTextBox.Size = new System.Drawing.Size(37, 20);
            this.CantidaddeTriangulosTextBox.TabIndex = 2;
            this.CantidaddeTriangulosTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de triángulos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.SalirToolStripButton,
            this.BorrartoolStripButton,
            this.EditartoolStripButton,
            this.toolStripSeparator1,
            this.OrdenartoolStripDropDownButton,
            this.FiltrartoolStripDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = global::POOTriangulos.Windows.Properties.Resources.new_copy_30px;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 35);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SalirToolStripButton.Image = global::POOTriangulos.Windows.Properties.Resources.export_30px;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(33, 35);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // BorrartoolStripButton
            // 
            this.BorrartoolStripButton.Image = global::POOTriangulos.Windows.Properties.Resources.Remove_30px;
            this.BorrartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrartoolStripButton.Name = "BorrartoolStripButton";
            this.BorrartoolStripButton.Size = new System.Drawing.Size(43, 35);
            this.BorrartoolStripButton.Text = "Borrar";
            this.BorrartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrartoolStripButton.Click += new System.EventHandler(this.BorrartoolStripButton_Click);
            // 
            // EditartoolStripButton
            // 
            this.EditartoolStripButton.Image = global::POOTriangulos.Windows.Properties.Resources.edit_property_30px;
            this.EditartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditartoolStripButton.Name = "EditartoolStripButton";
            this.EditartoolStripButton.Size = new System.Drawing.Size(41, 35);
            this.EditartoolStripButton.Text = "Editar";
            this.EditartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditartoolStripButton.Click += new System.EventHandler(this.EditartoolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // OrdenartoolStripDropDownButton
            // 
            this.OrdenartoolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.ascendenteToolStripMenuItem,
            this.descendenteToolStripMenuItem});
            this.OrdenartoolStripDropDownButton.Image = global::POOTriangulos.Windows.Properties.Resources.descending_sorting_30px;
            this.OrdenartoolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenartoolStripDropDownButton.Name = "OrdenartoolStripDropDownButton";
            this.OrdenartoolStripDropDownButton.Size = new System.Drawing.Size(63, 35);
            this.OrdenartoolStripDropDownButton.Text = "Ordenar";
            this.OrdenartoolStripDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // ascendenteToolStripMenuItem
            // 
            this.ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            this.ascendenteToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ascendenteToolStripMenuItem.Text = "ascendente";
            // 
            // descendenteToolStripMenuItem
            // 
            this.descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            this.descendenteToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.descendenteToolStripMenuItem.Text = "descendente";
            // 
            // FiltrartoolStripDropDownButton
            // 
            this.FiltrartoolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.FiltrartoolStripDropDownButton.Image = global::POOTriangulos.Windows.Properties.Resources.filter_30px;
            this.FiltrartoolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrartoolStripDropDownButton.Name = "FiltrartoolStripDropDownButton";
            this.FiltrartoolStripDropDownButton.Size = new System.Drawing.Size(50, 35);
            this.FiltrartoolStripDropDownButton.Text = "Filtrar";
            this.FiltrartoolStripDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // TriangulosDataGridView
            // 
            this.TriangulosDataGridView.AllowUserToAddRows = false;
            this.TriangulosDataGridView.AllowUserToDeleteRows = false;
            this.TriangulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TriangulosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLadoa,
            this.Colladob,
            this.ColLadoc,
            this.ColTrazo,
            this.ColColordeRelleno,
            this.ColTipodeTringulo,
            this.ColArea,
            this.ColPerimetro});
            this.TriangulosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TriangulosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TriangulosDataGridView.MultiSelect = false;
            this.TriangulosDataGridView.Name = "TriangulosDataGridView";
            this.TriangulosDataGridView.ReadOnly = true;
            this.TriangulosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TriangulosDataGridView.Size = new System.Drawing.Size(800, 359);
            this.TriangulosDataGridView.TabIndex = 0;
            // 
            // ColLadoa
            // 
            this.ColLadoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColLadoa.HeaderText = "Lado a";
            this.ColLadoa.Name = "ColLadoa";
            this.ColLadoa.ReadOnly = true;
            // 
            // Colladob
            // 
            this.Colladob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colladob.HeaderText = "Lado b";
            this.Colladob.Name = "Colladob";
            this.Colladob.ReadOnly = true;
            // 
            // ColLadoc
            // 
            this.ColLadoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColLadoc.HeaderText = "Lado c";
            this.ColLadoc.Name = "ColLadoc";
            this.ColLadoc.ReadOnly = true;
            // 
            // ColTrazo
            // 
            this.ColTrazo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTrazo.HeaderText = "Trazo";
            this.ColTrazo.Name = "ColTrazo";
            this.ColTrazo.ReadOnly = true;
            // 
            // ColColordeRelleno
            // 
            this.ColColordeRelleno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColColordeRelleno.HeaderText = "Color de relleno";
            this.ColColordeRelleno.Name = "ColColordeRelleno";
            this.ColColordeRelleno.ReadOnly = true;
            // 
            // ColTipodeTringulo
            // 
            this.ColTipodeTringulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTipodeTringulo.HeaderText = "Tipo de triángulo";
            this.ColTipodeTringulo.Name = "ColTipodeTringulo";
            this.ColTipodeTringulo.ReadOnly = true;
            // 
            // ColArea
            // 
            this.ColArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColArea.HeaderText = "Area";
            this.ColArea.Name = "ColArea";
            this.ColArea.ReadOnly = true;
            // 
            // ColPerimetro
            // 
            this.ColPerimetro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPerimetro.HeaderText = "Perimetro";
            this.ColPerimetro.Name = "ColPerimetro";
            this.ColPerimetro.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriangulosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.DataGridView TriangulosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLadoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colladob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLadoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColColordeRelleno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipodeTringulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPerimetro;
        private System.Windows.Forms.TextBox CantidaddeTriangulosTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton BorrartoolStripButton;
        private System.Windows.Forms.ToolStripButton EditartoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton OrdenartoolStripDropDownButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ascendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton FiltrartoolStripDropDownButton;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

