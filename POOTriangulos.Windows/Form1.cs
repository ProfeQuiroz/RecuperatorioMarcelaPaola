using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POOTriangulos.Datos;
using POOTriangulos.Entidades;

namespace POOTriangulos.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Cantidad;
        private List<triangulo> ListaTriangulo;
        private RepositoriodeTriangulos Repo = new RepositoriodeTriangulos();
        


        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere salir?","Salir" ,
            MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            NuevoTriangulo Frm = new NuevoTriangulo();
            DialogResult dr = Frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            triangulo Triangulo = Frm.GetTriangulo();
            Repo.Agregar(Triangulo);
            DataGridViewRow r = Construirfila();
            SetearFila(Triangulo, r);
            AgregarFila(r);
            Cantidad = Repo.GetCantidad();
            MostrarTotal();
            Repo.Guardar();

        }

        private void MostrarTotal()
        {
            CantidaddeTriangulosTextBox.Text = Cantidad.ToString();
            
        }

        private void AgregarFila(DataGridViewRow r)
        {
            TriangulosDataGridView.Rows.Add(r);
        }

        private void SetearFila(triangulo triangulo, DataGridViewRow r)
        {
            r.Cells[ColLadoa.Index].Value=triangulo.ladoa.ToString();
            r.Cells[Colladob.Index].Value = triangulo.ladob.ToString();
            r.Cells[ColLadoc.Index].Value = triangulo.ladoc.ToString();
            r.Cells[ColTrazo.Index].Value = triangulo.Trazo.ToString();
            r.Cells[ColColordeRelleno.Index].Value = triangulo.ColordeRelleno.ToString();

            r.Cells[ColArea.Index].Value = triangulo.GetArea().ToString();
            r.Cells[ColPerimetro.Index].Value = triangulo.GetPerimetro().ToString();
            r.Cells[ColTipodeTringulo.Index].Value = triangulo.Tipodetriangulo();
            r.Tag = triangulo;
        }

        private DataGridViewRow Construirfila()
        {
            var r=new DataGridViewRow();
            r.CreateCells(TriangulosDataGridView);
            return r;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Repo = new RepositoriodeTriangulos();
            ListaTriangulo = Repo.GetLista();
            Cantidad = Repo.GetCantidad();
            if (Cantidad <= 0)
            {
                MessageBox.Show("El repositorio esta vacio","Mensaje",MessageBoxButtons.OK);
            }
            else
            {
                ListaTriangulo = Repo.GetLista();
                MostrarLista();
            }
            MostrarTotal();
        }

        private void MostrarLista()
        {
            TriangulosDataGridView.Rows.Clear();
            foreach (var triangulo in ListaTriangulo)
            {
                var r = Construirfila();
                SetearFila(triangulo,r);
                AgregarFila(r);
            }
        }

        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {
            if (TriangulosDataGridView.Rows.Count == 0)
            {
                return;
            } 
            var r = TriangulosDataGridView.SelectedRows[0];
            triangulo Triangulo = r.Tag as triangulo;
            DialogResult dr = MessageBox.Show("¿Estás seguro que quieres borrar este triángulo",
                "Confirma Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(dr == DialogResult.No)
            {
                return;
            }
            if (Repo.Borrar(Triangulo))
            {
                ListaTriangulo.Remove(Triangulo);
                TriangulosDataGridView.Rows.Remove(r);
                Cantidad = Repo.GetCantidad();
                MostrarTotal();
                Repo.Guardar(); 
            }

        }

        private void EditartoolStripButton_Click(object sender, EventArgs e)
        {
            if (TriangulosDataGridView.Rows.Count == 0)
            {
                return;
            }
            var r = TriangulosDataGridView.SelectedRows[0];
            triangulo Triangulo = r.Tag as triangulo;
            NuevoTriangulo Frm = new NuevoTriangulo();
            Frm.SetearTriangulo(Triangulo);
            DialogResult dr = Frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Triangulo = Frm.GetTriangulo();
            Repo.Editar(Triangulo);
            SetearFila(Triangulo, r);
            ListaTriangulo = Repo.GetLista();
            MostrarLista();
            Repo.Guardar();

        }
    }
}
