using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashboard.Modelo
{
    public class Semestre
    {
        private int Cod_Semestre;
        private String DESC_Semestre;


        public int COD_Semestre
        {
            get { return this.Cod_Semestre; }
            set { this.Cod_Semestre = value; }
        }

        public String Desc_Semestre
        {
            get { return this.DESC_Semestre; }
            set { this.DESC_Semestre = value; }
        }
    }
}