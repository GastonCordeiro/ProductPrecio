﻿namespace ProductPrecio
{
    public class Producto
    {
        System.String[] Nombre = new System.String[1];
        System.Decimal[] Precio = new System.Decimal[1];

        System.Int32 CantElem = 0;

        public System.String CargarLista(System.String aNombre,
                                         System.String aPrecio)
        {
            System.String mRes = "";
            System.Decimal mPrecio = System.Convert.ToDecimal(aPrecio);
            
            mRes=this.CargarLista(aNombre, mPrecio);
            //mRes = Listado();
           return mRes;
        }
        public void ordenaralfa()
        {
            for (int i = 0; i <Nombre.Length; i++)
            {
                for (int j = 0; j < Nombre.Length && i != j; j++)
                {
                    if (Nombre[i].CompareTo(Nombre[j])< 0)
                    {
                        string aux = Nombre[i];
                        Nombre[i] = Nombre[j];
                        Nombre[j] = aux;
                        decimal aux1 = Precio[i];
                        Precio[i] = Precio[j];
                        Precio[j] = aux1;
                    }
                }
                
            }
           
        }
        /// <summary>
        /// carga un elemento nuevo a la lista
        /// </summary>
        /// <param name="aElemento">Elemento a cargar en la lista</param>
        /// <returns></returns>
        public System.String CargarLista(System.String aNombre,
                                         System.Decimal mPrecio)
        {
            System.String mRes = "";
            try
            {
                
                if (CantElem == Nombre.Length)
                {
                    Nombre = RedimensionarStr(Nombre);
                    Precio = RedimensionarDec(Precio);
                    
                }
                if (BuscaPorNombre(aNombre) == -1)
                {
                    Nombre[CantElem] = aNombre;
                    Precio[CantElem] = mPrecio;
                    CantElem++;
                    mRes = Listado();
                }
                else
                {
                    mRes = "El elemento " + aNombre + " ya existe";
                }
            }
            catch (System.Exception err)
            {
                
                throw err;
            }
            return mRes;
        }

        /// <summary>
        /// devuelve en un string los elemntos de laa lista
        /// </summary>
        /// <returns></returns>
        public System.String Listado()
        {
            System.String Res = "Productos:\r\n";
            System.Int32 j = 0;
            ordenaralfa();
            foreach (System.String mElemento in Nombre)
            {
                if (mElemento == null)
                {
                    break;
                }
                Res = Res + mElemento 
                    + " - " 
                    + Precio[j].ToString() + "\r\n";
                j = j + 1;
            }

            return Res;

        }

        /// <summary>
        /// devuelve la posicion donde se encuentra un elemento dentro de la lista, 
        /// si el valor devuelto es -1 significa que no se encontro
        /// </summary>
        /// <param name="aElemento">elemnto a buscar en la lista</param>
        /// <returns></returns>
        public System.Int32 BuscaPorNombre(System.String aElemento)
        {
            System.Int32 mREs = -1;

            for (int i = 0; i < Nombre.Length; i++)
            {
                if (Nombre[i] == aElemento)
                {
                    mREs = i + 1;
                    break;
                }
            }
            return mREs;
        }

        /// <summary>
        /// Agrega un elemento null a la lista al final
        /// </summary>
        /// <param name="aLista">Lista de string a redimensionar</param>
        private System.String[] RedimensionarStr(System.String[] aLista)
        {
            System.String[] Res = new System.String[aLista.Length + 1];
            System.Int32 j = 0;
            foreach (System.String mElemento in aLista)
            {
                Res[j] = mElemento;
                j++;
            }

            return Res;
        }

        /// <summary>
        /// Agrega un elemento null a la lista al final
        /// </summary>
        /// <param name="aLista">Lista de descimal a redimensionar</param>
        /// <returns></returns>
        private System.Decimal[] RedimensionarDec(System.Decimal[] aLista)
        {
            System.Decimal[] Res = new System.Decimal[aLista.Length + 1];
            System.Int32 j = 0;
            foreach (System.Decimal mElemento in aLista)
            {
                Res[j] = mElemento;
                j++;
            }

            return Res;
        }
    }
}
