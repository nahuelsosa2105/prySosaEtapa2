using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySosaEtapa2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        clsVehiculo objAuto;
        clsVehiculo objAvion;
        clsVehiculo objBarco;
        int cont = 1;

        bool Barco = false;
        private void btnCrear_Click(object sender, EventArgs e)
        {
           //Random rnd = new Random();
            //int numAleatorio = rnd.Next(1,3);

            
            
            switch (cont)
            {
                case 1:
                    objAuto.CrearAuto();
                    objAuto.pctAuto.Location = new Point(100, 50);
                    Controls.Add(objAuto.pctAuto);
                    cont++;
                    if(Barco == true)
                    {
                        objBarco.pctBarco.Dispose();
                    }
                break;

                case 2:
                    objAvion.CrearAvion();
                    objAvion.pctAvion.Location = new Point(300, 50);
                    Controls.Add(objAvion.pctAvion);
                    objAuto.pctAuto.Dispose();
                    cont++;
                break;

                case 3:
                    objBarco.CrearBarco();
                    objBarco.pctBarco.Location = new Point(500, 50);
                    Controls.Add(objBarco.pctBarco);
                    objAvion.pctAvion.Dispose();
                    cont++;
                    cont = 1;
                    Barco = true;
                break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculo();
            objAvion = new clsVehiculo();
            objBarco = new clsVehiculo();

            objAuto.CrearAuto();
            objAvion.CrearAvion();
            objBarco.CrearBarco();
        }
    }
}
