using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;

namespace Pelu_Shifts
{
    public partial class Turnero : Form
    {
        #region propiedades

        DataTable lista = new DataTable();
        int turno = 0;
        public Turno objTurno = new Turno();
        public Cliente objCliente = new Cliente();

        #endregion

        public Negocios.NegTurno objNegTurno = new Negocios.NegTurno();
        public Negocios.NegCliente objNegCliente = new Negocios.NegCliente();

        #region Constructor

        public Turnero()
        {

            InitializeComponent();
            lista.Columns.Add("Turno", typeof(int));
            lista.Columns.Add("Servicio", typeof(string));
            lista.Columns.Add("Precio", typeof(string));
            lista.Columns.Add("Cliente", typeof(string));
            lista.Columns.Add("Días", typeof(string));
            lista.Columns.Add("Horarios", typeof(string));
            lista.Columns.Add("Peluquero", typeof(string));

            dg.DataSource = lista;

            
        }


        #endregion


        #region eventos

        private void button1_Click(object sender, EventArgs e) // boton de reservar turno
        {   
            objTurno.Dia = cmbDias.SelectedItem.ToString();
            objTurno.Horario = cmbHorarios.SelectedItem.ToString();

            objCliente.Nombre = txtCliente.Text;

            objNegTurno.abmTurno(objTurno);
            objNegCliente.abmCliente(objCliente);

            Turno turno = new Turno();
            turno.Dia = cmbDias.Text;
            turno.Horario = cmbHorarios.Text;

            Peluquero();
            ControlTxt();
        }


        private void button2_Click(object sender, EventArgs e) // boton de salir 
        {
            Application.Exit();
        }

        #endregion



        #region metodos

        private void Peluquero()
        {
            if (cmbDias.Text.Trim() == "martes" || cmbDias.Text.Trim() == "viernes")
            {

                if (cmbHorarios.Text.Trim() == "9:00hs" || cmbHorarios.Text.Trim() == "12:00hs" || cmbHorarios.Text.Trim() == "17:00hs" || cmbHorarios.Text.Trim() == "20:00hs")
                {
                    ListayPrecio();
                    lista.Rows[lista.Rows.Count - 1]["Peluquero"] = "Peluquero 2";
                    
;
                }


            }

            else if (cmbDias.Text.Trim() == "miercoles" || cmbDias.Text.Trim() == "jueves")
            {

                if (cmbHorarios.Text.Trim() == "9:00hs" || cmbHorarios.Text.Trim() == "12:00hs" || cmbHorarios.Text.Trim() == "17:00hs" || cmbHorarios.Text.Trim() == "20:00hs")
                {
                    ListayPrecio();
                    lista.Rows[lista.Rows.Count - 1]["Peluquero"] = "Peluquero 1";

                }

            }
           
            else if (cmbDias.Text.Trim() == "sabado"&& cmbHorarios.Text.Trim() == "9:00hs" || cmbHorarios.Text.Trim() == "12:00hs")
            {
                ListayPrecio();
                lista.Rows[lista.Rows.Count - 1]["Peluquero"] = "Dueño";

                
            }

            else
            {
                MessageBox.Show("SOLO SE ATIENDE LOS SABADOS DE 9:00hs A 13:00hs");
            }


        }

        private void ListayPrecio() // metodo que engloba: el metodo lista y el metodo precio
        {
            LISTA();
            Precio();
        }


        private void LISTA() // metodo lista
        {

            turno = turno + 1;

            lista.Rows.Add();

            lista.Rows[lista.Rows.Count - 1]["Turno"] = turno;
            lista.Rows[lista.Rows.Count - 1]["Servicio"] = cmbServicios.Text;
            lista.Rows[lista.Rows.Count - 1]["Días"] = cmbDias.Text;
            lista.Rows[lista.Rows.Count - 1]["Horarios"] = cmbHorarios.Text;
            lista.Rows[lista.Rows.Count - 1]["Cliente"] = txtCliente.Text;
            dg.DataSource = lista;



        }


        private void Precio() // metodo precio
        {
            if (cmbServicios.Text == "Corte de pelo")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$300";
            }
            else if (cmbServicios.Text == "Lavado + Tintura")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$600";
            }
            else if (cmbServicios.Text == "Peinados")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$800";
            }
            else if (cmbServicios.Text == "Alisado")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$3500";
            }
            else if (cmbServicios.Text == "Lavado + Brushing")
            {
                lista.Rows[lista.Rows.Count - 1]["Precio"] = "$500";
            }
        }

        private void ControlTxt() // este metodo es para controlar los txt
        {
            txtCliente.Focus();
            txtCliente.Clear();
            cmbServicios.Text = "Servicios";
            cmbDias.Text = "Días";
            cmbHorarios.Text = "Horarios";
        }

        #endregion
    }
}
