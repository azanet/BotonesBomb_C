using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaBomba
{
    class Controller 
    {
       
        private frmBomba frm;
        private ModelFrmElements mdlFrmElmnts;
        private ControllerEvents ctrlEvnt;
        public Controller() {

            InitComponents();
        }//Fin del constructor



        private void InitComponents(){
            frm = new frmBomba();

            //Inicializando objetos de modelo y eventos
            mdlFrmElmnts = new ModelFrmElements(frm);
            ctrlEvnt = new ControllerEvents(frm,mdlFrmElmnts);  

            //Arrancando la vista
            Application.EnableVisualStyles();
            try{
                Application.SetCompatibleTextRenderingDefault(false);
            }catch (Exception e) {
            }
            Application.Run(frm);

           

        }//Fin de initComponents


    }//Fin de la class controller
}//Fin de namespace
