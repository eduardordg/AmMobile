using Am.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Am.Layers.Business
{
   public class UsuarioBusiness
    {
        public bool GetLogin(string user, string password)
        {

            //Chama metodo de validação
            bool login = Validation(user, password);

            //retorna boolean para logar
            return login;
        }


       
        public bool Validation(string user, string password)
        {
            //instancia usuario model para pegar login e senha adm
            var usuarioModel = new UsuarioModel();
            var userAdm = usuarioModel.getUserAdm();
            var passwordAdm = usuarioModel.getPasswordAdm(); 

            bool validado = false;


            //comparar o que ele digitou na tela com o login do adm
            if (user == userAdm && password == passwordAdm) {

                validado = true;
            }

            //retorna boolean 
            return validado;
        }

    }
}
