using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEntregable1_Clases
{
    internal class ProductoVendido
    {
        private int _Idprodvend;
        private int _Idproducto;
        private int _Stock;
        private int _Idventa;
       
        public ProductoVendido() 
        {

        }

        public ProductoVendido(int idprodvend, int idproducto, int srock, int idventa)
        {
            this._Idprodvend = idprodvend;
            this._Idproducto = idproducto;
            this._Stock = _Stock;
            this._Idventa = idventa;
           
        }

        public int Idprodvend { get { return _Idprodvend; } set { _Idprodvend = value; } }
        public int Idproducto { get { return _Idproducto; } set { _Idproducto = value; } }
        public int Stock { get { return _Stock; } set { _Stock = value; } }
        public int Idventa { get { return _Idventa; } set { _Idventa = value; } }
       


    }
}
