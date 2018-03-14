using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashboard.Modelo
{
    public class Campus
    {
        private int Cod_Campus;
        private String Desc_Campus;

        public int COD_Campus
        {
            get { return this.Cod_Campus; }
            set { this.Cod_Campus = value; }
        }

        public String DESC_Campus
        {
            get { return this.Desc_Campus; }
            set { this.Desc_Campus = value; }
        }
    }
}