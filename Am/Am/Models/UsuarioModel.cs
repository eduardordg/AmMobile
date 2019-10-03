using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Am.Models
{
    public class UsuarioModel
    {
        private string user_adm = "admin";
        private string password_adm = "admin";



        public string getUserAdm()
        {
            return this.user_adm;
        }

        public void setUserAdm(string user)
        {

            this.user_adm = user;
        }

        public string getPasswordAdm()
        {
            return this.password_adm;
        }

        public void getPasswordAdm(string password)
        {

            this.user_adm = password;
        }





    }
}
