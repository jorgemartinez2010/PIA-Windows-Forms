using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using Newtonsoft.Json;
using static PIA.Visita;

namespace PIA
{
    public partial class RegistroE : Form
    {
        ArchivoJson<Visita> AJ = new ArchivoJson<Visita>(@"D:\PIA Programacion\PIA\bin\debug\Visita.json");

        public RegistroE()
        {
            InitializeComponent();
            AJ.CargarArchivo();
        }

        private void btn_salida_Click(object sender, EventArgs e)
        {
            RegistroS form = new RegistroS();
            form.Show();
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Se necesita el nombre del visitante");
            }
            else
            {
                if (txt_apellido.Text == "")
                {
                    MessageBox.Show("Se necesita el apellido del visitante");
                }
                else
                {
                    if (txt_matricula.Text == "")
                    {
                        MessageBox.Show("Se necesita la matricula");
                    }
                    else
                    {
                        if (txt_modelo.Text == "")
                        {
                            MessageBox.Show("Se necesita el modelo del automovil");
                        }
                        else
                        {
                            if (txt_nombre_r.Text == "")
                            {
                                MessageBox.Show("Se necesita el nombre del residente");
                            }
                            else
                            {
                                if (txt_apellido_r.Text == "")
                                {
                                    MessageBox.Show("Se necesita el apellido del residente");
                                }
                                else
                                {
                                    if (txt_calle.Text == "")
                                    {
                                        MessageBox.Show("Se necesita la calle");
                                    }
                                    else
                                    {
                                        if (txt_numero.Text == "")
                                        {
                                            MessageBox.Show("Se necesita el numero");
                                        }
                                        else
                                        {
                                            if (txt_codigo.Text == "")
                                            {
                                                MessageBox.Show("Se necesita el codigo de identificacion");
                                            }
                                            else
                                            {
                                                int id = int.Parse(txt_codigo.Text);
                                                int numero = int.Parse(txt_numero.Text);
                                                var lista = AJ.Buscar(v => v.Codigo == id);
                                                var list = new List<int>();

                                                foreach (Visita v in lista)
                                                {
                                                    list.Add(v.Codigo);
                                                }

                                                var exists = list.Contains(id);
                                                if (exists == true)
                                                {
                                                    MessageBox.Show("Codigo ya registrado, favor de introducir una nuevo");
                                                }
                                                else
                                                {
                                                    string EST = "Adentro";
                                                    //Guardado de informacion
                                                    Visita v = new Visita(id, txt_nombre.Text, txt_apellido.Text, txt_matricula.Text, txt_modelo.Text,
                                                    EST, txt_nombre_r.Text, txt_apellido_r.Text, txt_calle.Text, numero);
                                                    AJ.Agregar(v);
                                                    txt_codigo.Text = " ";
                                                    txt_nombre.Text = "";
                                                    txt_apellido.Text = "";
                                                    txt_matricula.Text = "";
                                                    txt_modelo.Text = "";
                                                    txt_nombre_r.Text = "";
                                                    txt_apellido_r.Text = "";
                                                    txt_calle.Text = "";
                                                    txt_numero.Text = "";
                                                    MessageBox.Show("Visita registrada");
                                                }
                                               
                                            }
                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_modelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_nombre_r_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_apellido_r_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void RegistroE_Load(object sender, EventArgs e)
        {

        }
    }
}
