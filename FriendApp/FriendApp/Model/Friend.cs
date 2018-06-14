using FriendApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FriendApp.Model
{
   public class Friend : Notificable
    {
        #region Atributos
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        private string nombre;
        private string telefono;
        private string correo;
        #endregion

       

        public string Correo
        {
            get { return correo; }
            set {
                SetValue(ref nombre, value);
            }
        }


        public string Telefono
        {
            get { return telefono; }
            set {
                SetValue(ref nombre, value);
            }
        }


        public string Nombre
        {
            get { return nombre; }
            set {
                SetValue( ref nombre, value);
            }
        }



    }
}
