using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashboard.Modelo
{
    public class Bloco
    {
        private int Cod_Bloco;
        private String Desc_Bloco;

        public int COD_Bloco
        {
            get { return this.Cod_Bloco; }
            set { this.Cod_Bloco = value; }
        }

        public String DESC_Bloco
        {
            get { return this.Desc_Bloco; }
            set { this.Desc_Bloco = value; }
        }
    }
}