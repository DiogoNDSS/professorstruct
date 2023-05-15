namespace Struct;

public struct Professor
{
  public string Nome;
  public string Salario;
  public string Endereço;
  public string CargaHoraria;
  public string QuantidadeAulas;
  public string Materia;



  public Professor(string nome, string salario, string endereco, string cargahoraria, string qtdaula, string materia)
  {
    this.Nome = nome;
    this.Salario = salario;
    this.Endereço = endereco;
    this.CargaHoraria = cargahoraria;
    this.QuantidadeAulas = qtdaula;
    this.Materia = materia;
  }

  public string imprimir()
  {
    return "\nNome: " + this.Nome +
    "\nSalario: " + this.Salario +
    "\nEndereço: " + this.Endereço +
    "\nCarga Horaria: " + this.CargaHoraria +
    "\nQuantidade de Aulas: " + this.Materia;

  }
}