using System;
using Struct;

namespace PROFESSORSTRUCT
{
  class Program
  {

    static void Main(string[] args)
    {
      //Struct
      Professor professor1 = new();
      professor1.Nome = "Bruno ";
      professor1.Salario = "RS:4000 ";
      professor1.Endereço = "rua berimbal bol bal 390";
      professor1.CargaHoraria = "12 Horas";
      professor1.QuantidadeAulas = "24";
      professor1.Materia = "ED , TECNICAS WEB";

      Console.WriteLine(professor1.imprimir());
    }

  }
}