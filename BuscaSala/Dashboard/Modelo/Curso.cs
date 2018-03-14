using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashboard.Modelo
{
    public class Curso
    {
        private int Cod_Curso;
        private String Desc_Curso;

        public int COD_Curso
        {
            get { return this.Cod_Curso; }
            set { this.Cod_Curso = value; }
        }

        public String DESC_Curso
        {
            get { return this.Desc_Curso; }
            set { this.Desc_Curso = value; }
        }
    }
}