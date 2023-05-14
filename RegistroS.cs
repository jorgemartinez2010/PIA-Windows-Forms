using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PIA.RegistroE;
using static PIA.Visita;

namespace PIA
{
    public partial class RegistroS : Form
    {
        ArchivoJson<Visita> AJ = new ArchivoJson<Visita>(@"D:\PIA Programacion\PIA\bin\debug\Visita.json");
        public RegistroS()
        {
            InitializeComponent();
            AJ.CargarArchivo();
            VerInfo(AJ.Arreglo);
        }

        private void RegistroS_Load(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
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
                                                MessageBox.Show("Favor de introducir un codigo de identificacion");
                                            }
                                            else
                                            {
                                                int id = int.Parse(txt_codigo.Text);
                                                int numero = int.Parse(txt_numero.Text);
                                                var list = new List<int>();
                                                var lista = AJ.Buscar(v => v.Codigo == id);

                                                foreach (Visita v in lista)
                                                {
                                                    list.Add(v.Codigo);
                                                }
                                                var exists = list.Contains(id);
                                                if (exists == true)
                                                {
                                                   
                                                    Visita v = new Visita(id, txt_nombre.Text, txt_apellido.Text, txt_matricula.Text, txt_modelo.Text,
                                                                            txt_estado.Text, txt_nombre_r.Text, txt_apellido_r.Text, txt_calle.Text, numero);
                                                    AJ.Actualizar(i => i.Codigo == id, v);
                                                    VerInfo(AJ.Arreglo);
                                                    txt_codigo.Text = " ";
                                                    txt_nombre.Text = "";
                                                    txt_apellido.Text = "";
                                                    txt_matricula.Text = "";
                                                    txt_modelo.Text = "";
                                                    txt_estado.Text = "";
                                                    txt_nombre_r.Text = "";
                                                    txt_apellido_r.Text = "";
                                                    txt_calle.Text = "";
                                                    txt_numero.Text = "";
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Codigo ya registrado, favor de introducir una nuevo");
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
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void VerInfo(List<Visita> lista)
        {
            GridDatos.Rows.Clear();
            foreach (Visita v in lista)
            {
                DataGridViewRow Row = new DataGridViewRow();
                Row.Cells.Add(new DataGridViewTextBoxCell() { Value = v.Codigo });
                Row.Cells.Add(new DataGridViewTextBoxCell() { Value = v.Nombre });
                Row.Cells.Add(new DataGridViewTextBoxCell() { Value = v.Apellido });
                Row.Cells.Add(new DataGridViewTextBoxCell() { Value = v.Modelo });
                Row.Cells.Add(new DataGridViewTextBoxCell() { Value = v.Matricula });
                Row.Cells.Add(new DataGridViewTextBoxCell() { Value = v.Estado });
                Row.Cells.Add(new DataGridViewTextBoxCell() { Value = v.Nombre_R });
                Row.Cells.Add(new DataGridViewTextBoxCell() { Value = v.Apellido_R });
                Row.Cells.Add(new DataGridViewTextBoxCell() { Value = v.Calle });
                Row.Cells.Add(new DataGridViewTextBoxCell() { Value = v.Numero });
                GridDatos.Rows.Add(Row);
            }

        }

        private void GridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Visita v = AJ.Buscar(i => i.Codigo.ToString() == GridDatos.CurrentRow.Cells[0].Value.ToString())[0];
            txt_codigo.Text = v.Codigo.ToString();
            txt_nombre.Text = v.Nombre;
            txt_apellido.Text = v.Apellido;
            txt_modelo.Text = v.Modelo;
            txt_matricula.Text = v.Matricula;
            txt_estado.Text = v.Estado;
            txt_nombre_r.Text = v.Nombre_R;
            txt_apellido_r.Text = v.Apellido_R;
            txt_calle.Text = v.Calle;
            txt_numero.Text = v.Numero.ToString();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            RegistroE form = new RegistroE();
            form.Show();
            this.Hide();
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_modelo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_estado_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
