using System;
using System.Diagnostics;
using Caelum.Stella.CSharp.Validation;
using Caelum.Stella.CSharp.Vault;

namespace ValidadorDeDocumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpf1 = "02604042096";
            var cpf2 = "02604042000";
            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
        }

        private static void ValidarCPF(string cpf)
        {
            try
            {
                new CPFValidator().AssertValid(cpf);
                Debug.WriteLine("CPF válido: " + cpf);
            }
            catch (Exception exc)
            {
                Debug.WriteLine("CPF inválido: " + cpf + " : " + exc.ToString());
            }
        }

    }
}
