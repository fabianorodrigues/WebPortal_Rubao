using System;
using System.Collections.Generic;
using System.Text;

namespace SMT.Dados.BLL
{
    public class BoTecnico
    {
        ///// <summary>
        ///// Inclui um novo cliente
        ///// </summary>
        ///// <param name="cliente">Objeto de cliente</param>
        //public long Incluir(DML.Tecnico tecnico)
        //{
        //    DAL.DaoTecnico tec = new DAL.DaoTecnico();
        //    return tec.Incluir(tecnico);
        //}

        ///// <summary>
        ///// Altera um cliente
        ///// </summary>
        ///// <param name="cliente">Objeto de cliente</param>
        //public void Alterar(DML.Tecnico tecnico)
        //{
        //    DAL.DaoTecnico tec = new DAL.DaoTecnico();
        //    tec.Alterar(tecnico);
        //}

        ///// <summary>
        ///// Consulta o cliente pelo id
        ///// </summary>
        ///// <param name="id">id do cliente</param>
        ///// <returns></returns>
        //public DML.Tecnico Consultar(long id)
        //{
        //    DAL.DaoTecnico tec = new DAL.DaoTecnico();
        //    return tec.Consultar(id);
        //}

        ///// <summary>
        ///// Excluir o cliente pelo id
        ///// </summary>
        ///// <param name="id">id do cliente</param>
        ///// <returns></returns>
        //public void Excluir(long id)
        //{
        //    DAL.DaoTecnico tec = new DAL.DaoTecnico();
        //    tec.Excluir(id);
        //}

        ///// <summary>
        ///// Lista os clientes
        ///// </summary>
        //public List<DML.Tecnico> Listar()
        //{
        //    DAL.DaoTecnico tec = new DAL.DaoTecnico();
        //    return tec.Listar();
        //}

        ///// <summary>
        ///// Lista os clientes
        ///// </summary>
        //public List<DML.Tecnico> Pesquisa(int iniciarEm, int quantidade, string campoOrdenacao, bool crescente, out int qtd)
        //{
        //    DAL.DaoTecnico tec = new DAL.DaoTecnico();
        //    return tec.Pesquisa(iniciarEm, quantidade, campoOrdenacao, crescente, out qtd);
        //}


        ///// <summary>
        ///// Remove caracteres não numéricos
        ///// </summary>
        ///// <param name="text"></param>
        ///// <returns></returns>
        //public static string RemoveNaoNumericos(string text)
        //{
        //    System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"[^0-9]");
        //    string ret = reg.Replace(text, string.Empty);
        //    return ret;
        //}

        ///// <summary>
        ///// VerificaExistencia
        ///// </summary>
        ///// <param name="CPF"></param>
        ///// <returns></returns>
        //public bool VerificarExistencia(string CPF)
        //{
        //    DAL.DaoTecnico tec = new DAL.DaoTecnico();

        //    CPF = RemoveNaoNumericos(CPF);

        //    if (CPF.Length > 11)
        //        return false;

        //    while (CPF.Length != 11)
        //        CPF = '0' + CPF;

        //    bool igual = true;
        //    for (int i = 1; i < 11 && igual; i++)
        //        if (CPF[i] != CPF[0])
        //            igual = false;

        //    if (igual || CPF == "12345678909")
        //        return false;

        //    int[] numeros = new int[11];

        //    for (int i = 0; i < 11; i++)
        //        numeros[i] = int.Parse(CPF[i].ToString());

        //    int soma = 0;
        //    for (int i = 0; i < 9; i++)
        //        soma += (10 - i) * numeros[i];

        //    int resultado = soma % 11;

        //    if (resultado == 1 || resultado == 0)
        //    {
        //        if (numeros[9] != 0)
        //            return false;
        //    }
        //    else if (numeros[9] != 11 - resultado)
        //        return false;

        //    soma = 0;
        //    for (int i = 0; i < 10; i++)
        //        soma += (11 - i) * numeros[i];

        //    resultado = soma % 11;

        //    if (resultado == 1 || resultado == 0)
        //    {
        //        if (numeros[10] != 0)
        //            return false;
        //    }
        //    else
        //        if (numeros[10] != 11 - resultado)
        //        return false;

        //    return tec.VerificarExistencia(CPF);
        //}
    }
}
