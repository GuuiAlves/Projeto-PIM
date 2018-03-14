using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuscaSalaEntities.Modelo
{
    public class Sala
    {
        private int Cod_Sala;
        private String Desc_Sala;

        public int COD_Sala
        {
            get { return this.Cod_Sala; }
            set { this.Cod_Sala = value; }
        }

        public String DESC_Sala
        {
            get { return this.Desc_Sala; }
            set { this.Desc_Sala = value; }
        }
    }
}