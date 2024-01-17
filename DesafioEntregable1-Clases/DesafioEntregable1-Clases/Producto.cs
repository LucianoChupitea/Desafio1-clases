using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEntregable1_Clases
{
    internal class Producto
    {
        private int _Idprod;
        private string _Descripcion;
        private double _Costo;
        private double _Precioventa;
        private int _Stock;
        private int _Idusuario;

        public Producto()
        {

        }

        public Producto(int id, string descripcion, double costo, double precioventa, int stock , int idusuario)
        {
            this._Idprod = id;
            this._Descripcion = descripcion;
            this._Costo = costo;
            this._Precioventa = precioventa;
            this._Stock = stock;
            this._Idusuario = idusuario;
        }

        public int Idprod { get { return _Idprod; } set { _Idprod = value; } }
        public string Descripcion { get { return _Descripcion; } set { _Descripcion = value; } }
        public double Costo { get { return _Costo; } set { _Costo = value; } }
        public double Precioventa { get { return _Precioventa; } set { _Precioventa = value; } }
        public int Stock { get { return _Stock; } set { _Stock = value; } }
        public int Idusuario { get { return _Idusuario; } set { _Idusuario = value; } }






    }
}
