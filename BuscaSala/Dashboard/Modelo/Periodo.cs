using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashboard.Modelo
{
    public class Periodo
    {
        private int Cod_Periodo;
        private String Desc_Periodo;

        public int COD_Periodo
        {
            get { return this.Cod_Periodo; }
            set { this.Cod_Periodo = value; }
        }

        public String DESC_Periodo
        {
            get { return this.Desc_Periodo; }
            set { this.Desc_Periodo = value; }
        }
    }
}