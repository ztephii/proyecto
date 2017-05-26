using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proyecto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCarga frm = new frmCarga();
            frm.Show();

            #region comunidad 
            string id;
            string nombre;
            string pob;
            string lineah;
           
            StreamReader textoa = new StreamReader("C:/programacion/DatosComunidades.txt");
            while ((lineah = textoa.ReadLine()) != null)
            {
                string[] campos = lineah.Split('#');
                id = campos[0];
                nombre = campos[1];
                pob = campos[2];
                Comunidad nuevo = new Comunidad(id, nombre, pob);
                General.Listacom.Add(nuevo);
            }
            textoa.Close();
            #endregion

            #region gastos
            string idg;
            string nombreg;
            string tipr;
            string lineai;

            StreamReader textob = new StreamReader("C:/programacion/DatosGastos.txt");
            while ((lineai = textob.ReadLine()) != null)
            {
                string[] campos1 = lineai.Split('#');
                idg = campos1[0];
                nombreg = campos1[1];
                tipr = campos1[2];
                Gastos nuevo1 = new Gastos(idg, nombreg, tipr);
                General.Listagas.Add(nuevo1);
            }
            textob.Close();

            #endregion

            #region gastos generales
            string idgg;
            string desc;
            string impor;
            string tipzonare;
            string lineaj;

            StreamReader textoc = new StreamReader("C:/programacion/DatosGastosGenerales.txt");
            while ((lineaj = textoc.ReadLine()) != null)
            {
                string[] campos2 = lineaj.Split('#');
                idgg = campos2[0];
                desc = campos2[1];
                impor = campos2[2];
                tipzonare = campos2[3];
                GastosGenerales nuevo2 = new GastosGenerales(idgg, desc, impor, tipzonare);
                General.Listagasge.Add(nuevo2);
            }
            textoc.Close();

            #endregion

            #region propiedades
            string tipop;
            string cpropiedad;
            string mc;
            string nitpro;
            string listpor;
            string lineak;

            StreamReader textod = new StreamReader("C:/programacion/DatosPropiedades.txt");
            while ((lineak = textod.ReadLine()) != null)
            {
                string[] campos3 = lineak.Split('#');
                tipop = campos3[0];
                cpropiedad = campos3[1];
                mc = campos3[2];
                nitpro = campos3[3];
                listpor = campos3[4];
                Propiedades nuevo3 = new Propiedades(tipop, cpropiedad, mc, nitpro, listpor);
                General.Listapro.Add(nuevo3);
            }
            textod.Close();

            #endregion

            #region propietarios
            string nit;
            string nombrepro;
            string email;
            string lineal;

            StreamReader textoe = new StreamReader("C:/programacion/DatosPropietarios.txt");
            while ((lineal = textoe.ReadLine()) != null)
            {
                string[] campos4 = lineal.Split('#');
                nit = campos4[0];
                nombrepro = campos4[1];
                email = campos4[2];
                Propietarios nuevo4 = new Propietarios(nit, nombrepro, email);
                General.Listapropietarios.Add(nuevo4);
            }
            textoe.Close();

            #endregion
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

      
    }
}
