using System;
using System.Windows.Forms;
using POOTriangulos.Entidades;

namespace POOTriangulos.Windows
{
    public partial class NuevoTriangulo : Form
    {
        public NuevoTriangulo()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LlenarComboBox();
            if (Triangulo != null)
            {
                ladoatextBox.Text = Triangulo.ladoa.ToString();
                ladobtextBox.Text = Triangulo.ladob.ToString();
                ladoctextBox.Text = Triangulo.ladoc.ToString();
                if(Triangulo.Trazo==Trazo.continuo)
                {
                    ContinuoRadioButton.Checked=true;
                }
                else
                {
                    if (Triangulo.Trazo == Trazo.puntos)
                    {
                        PuntosRadioButton.Checked = true;
                    }
                    else
                    {
                        RayasRadioButton.Checked = true;
                    }
                    
                }
                ColorComboBox.SelectedItem = (ColordeRelleno)Triangulo.ColordeRelleno;
                
            }



        }
        private triangulo Triangulo;
        private void LlenarComboBox()
        {
            ColorComboBox.DataSource=Enum.GetValues(typeof(ColordeRelleno)) ;
            ColorComboBox.SelectedItem =0;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Confirmarbutton_Click(object sender, EventArgs e)
        {
           if( ValidarDatos())
            {
              if (Triangulo == null)
                {
                    Triangulo = new triangulo();

                }
                Triangulo.ladoa = double.Parse(ladoatextBox.Text);
                Triangulo.ladob = double.Parse(ladobtextBox.Text);
                Triangulo.ladoc = double.Parse(ladoctextBox.Text);
                Triangulo.ColordeRelleno = (ColordeRelleno)ColorComboBox.SelectedItem;
                if (RayasRadioButton.Checked == true)
                {
                    Triangulo.Trazo=Trazo.rayas;
                }
                else
                {
                    if(PuntosRadioButton.Checked == true)
                    {
                        Triangulo.Trazo = Trazo.puntos;
                    }
                    else
                    {
                        Triangulo.Trazo = Trazo.continuo;
                    }
                }
                if (Triangulo.ValidarTriangulo())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Los lados no conforman un triangulo",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal triangulo GetTriangulo()
        {
            return Triangulo;
            
        }

        private bool ValidarDatos()
        {
            ErrorProvider.Clear();

           bool valido = true;
          if(!double.TryParse(ladoatextBox.Text,out double ladoa))
                {
                valido = false;
                ErrorProvider.SetError(ladoatextBox, "Debe ingresar un número");
                }
          else
            {
             if (ladoa<=0)
                {
                    valido = false;
                    ErrorProvider.SetError(ladoatextBox, "El valor debe ser mayor a cero");
                }
            }
            if (!double.TryParse(ladobtextBox.Text, out double ladob))
            {
                valido = false;
                ErrorProvider.SetError(ladobtextBox, "Debe ingresar un número");
            }
            else
            {
                if (ladob <= 0)
                {
                    valido = false;
                    ErrorProvider.SetError(ladobtextBox, "El valor debe ser mayor a cero");
                }
            }
            if (!double.TryParse(ladoctextBox.Text, out double ladoc))
            {
                valido = false;
                ErrorProvider.SetError(ladoctextBox, "Debe ingresar un número");
            }
            else
            {
                if (ladoc <= 0)
                {
                    valido = false;
                    ErrorProvider.SetError(ladoctextBox, "El valor debe ser mayor a cero");
                }
            }
            return valido;
        }

        internal void SetearTriangulo(triangulo triangulo)
        {
          Triangulo=triangulo;
        }
    }
}
