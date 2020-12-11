using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBomba
{
 
    class ControllerEvents{

        private frmBomba frm;
        private ModelFrmElements mdlFrmElmnts;
    
        
        public ControllerEvents(frmBomba frm, ModelFrmElements mdlFrmElmnts) {
            this.frm = frm;
            this.mdlFrmElmnts = mdlFrmElmnts;
            InitEvents();
        }//Fin del constructor



        private void InitEvents()
        {
            frm.BtnLeft.Click += new System.EventHandler(this.btn_Click);
            frm.BtnCenter.Click += new System.EventHandler(this.btn_Click);
            frm.BtnRight.Click += new System.EventHandler(this.btn_Click);
        }



        private void btn_Click(object sender, EventArgs e)
        {
            mdlFrmElmnts.changeBtns();
        }


    }//Fin de ControllerEvents
}
