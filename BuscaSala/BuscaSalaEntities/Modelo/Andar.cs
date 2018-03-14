using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuscaSalaEntities.Modelo
{
    public class Andar
    {
        private int Cod_Andar;
        private String Desc_Andar;

        public int COD_Andar
        {
            get { return this.Cod_Andar; }
            set { this.Cod_Andar = value; }
        }

        public String DESC_Andar
        {
            get { return this.Desc_Andar; }
            set { this.Desc_Andar = value; }
        }


    }
}