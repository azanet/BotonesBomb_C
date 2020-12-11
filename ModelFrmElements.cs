using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LaBomba
{
    class ModelFrmElements
    {
        private Boolean state = true;
        private frmBomba frm; 

        public ModelFrmElements(frmBomba frm) {
            this.frm = frm;
            initBtnsState();
        }


        private void initBtnsState(){
            frm.BtnCenter.Visible = this.state;
            frm.BtnLeft.Visible = !this.state;
            frm.BtnRight.Visible = !this.state;
        }//Fin de initBtnsState


        public void changeBtns()
        {
            this.state = !this.state;
            initBtnsState();
        }
    }
}
