using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelu_Shifts
{
    public partial class Turnero : Form
    {
        #region propiedades

        DataTable lista = new DataTable();
        int turno = 0;


        #endregion



        #region Constructor

        public Turnero()
        {
            InitializeComponent();
            lista.Columns.Add("Turno", typeof(int));
            lista.Columns.Add("Servicio", typeof(string));
            lista.Columns.Add("Precio", typeof(string));
            lista.Columns.Add("Horario", typeof(string));
            lista.Columns.Add("Peluquero", typeof(string));

            dg.DataSource = lista;
        }


        #endregion


        #region eventos

        private void button1_Click(object sender, EventArgs e) // boton de reservar turno
        {

            turno = turno + 1;

            lista.Rows.Add();

            lista.Rows[lista.Rows.Count - 1]["Turno"] = turno;
            lista.Rows[lista.Rows.Count - 1]["Servicio"] = txtservicios.Text;
            lista.Rows[lista.Rows.Count - 1]["Horario"] = txthorarios.Text;

            Precio();
            Peluquero();

            txthorarios.Items.Remove(txthorarios.Text);
            dg.DataSource = lista;

        }

        private void button2_Click(object sender, EventArgs e) // boton de salir 
        {
            Application.Exit();
        }

        #endregion



        #region metodos

        private void Peluquero()
        {
            if (txthorarios.Text.Trim() == "Martes: 9:00hs" || txthorarios.Text.Trim() == "Martes: 12:00hs" || txthorarios.Text.Trim() == "Martes: 17:00hs" || txthorarios.Text.Trim() == "Martes: 20:00hs" || txthorarios.Text.Trim() == "Viernes: 9:00hs" || txthorarios.Text.Trim() == "Viernes: 12:00hs" || txthorarios.Text.Trim() == "Viernes: 17:00hs" || txthorarios.Text.Trim() == "Viernes: 20:00hs")
            {
                lista.Rows[lista.Rows.Count - 1]["Peluquero"] = "Peluquero 2";
            }
            else if (txthorarios.Text.Trim() == "Miercoles: 9:00hs" || txthorarios.Text.Trim() == "Miercoles: 12:00hs" || txthorarios.Text.Trim() == "Miercoles: 17:00hs" || txthorarios.Text.Trim() == "Miercoles: 20:00hs" || txthorarios.Text.Trim() == "Jueves: 9:00hs" || txthorarios.Text.Trim() == "Jueves: 12:00hs" || txthorarios.Text.Trim() == "Jueves: 17:00hs" || txthorarios.Text.Trim() == "Jueves: 20:00hs")
            {
                lista.Rows[lista.Rows.Count - 1]["Peluquero"] = "Peluqueria 1";
            }
        }


        private void Precio()
        {
            if (txtservicios.Text == "Corte de pelo")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$300";
            }
            else if (txtservicios.Text == "Lavado + Tintura")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$600";
            }
            else if (txtservicios.Text == "Peinados")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$800";
            }
            else if (txtservicios.Text == "Alisado")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$3500";
            }
            else if (txtservicios.Text == "Lavado + Brushing")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$500";
            }


           



        }
        #endregion

    }



}
