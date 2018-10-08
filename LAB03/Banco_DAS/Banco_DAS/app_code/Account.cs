using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_DAS.app_code
{
    class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastNameFather { get; set; }
        public string LastNameMother { get; set; }
        public int AccountType { get; set; }
        public decimal Cash { get; set; }

        public override string ToString()
        {
            string msj = string.Format("Información de la Cuenta.\n" +
                          "ID: {0},\n" +
                          "Nombre: {1},\n" +
                          "Apellido Paterno: {2},\n" +
                          "Apellido Materno: {3},\n" +
                          "Tipo de cuenta: {4},\n" +
                          "Dispone de {5} colones en la cuenta bancaria.",
                          Id, Name, LastNameFather, LastNameMother, ReturnType(AccountType), Cash);
            return msj;
        }

        private string ReturnType(int type)
        {
            if(type == 1)
            {
                return "Debito";
            }
            else if(type == 2)
            {
                return "Credito";
            }
            else
            {
                return null;
            }
        }
    }
}
