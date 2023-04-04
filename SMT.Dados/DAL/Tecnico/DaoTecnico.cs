namespace SMT.Dados.DAL
{
    internal class DaoTecnico
    {
        ///// <summary>
        ///// Inclui um novo tecnico
        ///// </summary>
        ///// <param name="tecnico">Objeto de tecnico</param>
        //internal long Incluir(DML.Tecnico tecnico)
        //{
        //    List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Nome", tecnico.Nome));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("CPF", tecnico.CPF));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("CEP", tecnico.CEP));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Estado", tecnico.Estado));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Cidade", tecnico.Cidade));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Logradouro", tecnico.Logradouro));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Email", tecnico.Email));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Telefone", tecnico.Telefone));

        //    DataSet ds = base.Consultar("FI_SP_IncClienteV2", parametros);
        //    long ret = 0;
        //    if (ds.Tables[0].Rows.Count > 0)
        //        long.TryParse(ds.Tables[0].Rows[0][0].ToString(), out ret);
            
        //    return ret;
        //}

        ///// <summary>
        ///// Inclui um novo cliente
        ///// </summary>
        ///// <param name="cliente">Objeto de cliente</param>
        //internal DML.Tecnico Consultar(long Id)
        //{
        //    List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Id", Id));

        //    DataSet ds = base.Consultar("FI_SP_ConsCliente", parametros);
        //    List<DML.Tecnico> tec = Converter(ds);

        //    return tec.FirstOrDefault();
        //}

        //internal bool VerificarExistencia(string CPF)
        //{
        //    List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

        //    parametros.Add(new System.Data.SqlClient.SqlParameter("CPF", CPF));

        //    DataSet ds = base.Consultar("FI_SP_VerificaCliente", parametros);

        //    return ds.Tables[0].Rows.Count > 0;
        //}

        //internal List<Tecnico> Pesquisa(int iniciarEm, int quantidade, string campoOrdenacao, bool crescente, out int qtd)
        //{
        //    List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

        //    parametros.Add(new System.Data.SqlClient.SqlParameter("iniciarEm", iniciarEm));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("quantidade", quantidade));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("campoOrdenacao", campoOrdenacao));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("crescente", crescente));

        //    DataSet ds = base.Consultar("FI_SP_PesqCliente", parametros);
        //    List<DML.Tecnico> tec = Converter(ds);

        //    int iQtd = 0;

        //    if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
        //        int.TryParse(ds.Tables[1].Rows[0][0].ToString(), out iQtd);

        //    qtd = iQtd;

        //    return tec;
        //}

        ///// <summary>
        ///// Lista todos os clientes
        ///// </summary>
        //internal List<DML.Tecnico> Listar()
        //{
        //    List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Id", 0));

        //    DataSet ds = base.Consultar("FI_SP_ConsCliente", parametros);
        //    List<DML.Tecnico> tec = Converter(ds);

        //    return tec;
        //}

        ///// <summary>
        ///// Inclui um novo tecnico
        ///// </summary>
        ///// <param name="tecnico">Objeto de tecnico</param>
        //internal void Alterar(DML.Tecnico tecnico)
        //{
        //    List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Nome", tecnico.Nome));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("CPF", tecnico.CPF));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("CEP", tecnico.CEP));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Estado", tecnico.Estado));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Cidade", tecnico.Cidade));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Logradouro", tecnico.Logradouro));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Email", tecnico.Email));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Telefone", tecnico.Telefone));
        //    parametros.Add(new System.Data.SqlClient.SqlParameter("ID", tecnico.Id));

        //    base.Executar("FI_SP_AltCliente", parametros);
        //}


        ///// <summary>
        ///// Excluir Cliente
        ///// </summary>
        ///// <param name="cliente">Objeto de cliente</param>
        //internal void Excluir(long Id)
        //{
        //    List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

        //    parametros.Add(new System.Data.SqlClient.SqlParameter("Id", Id));

        //    base.Executar("FI_SP_DelCliente", parametros);
        //}

        //private List<DML.Tecnico> Converter(DataSet ds)
        //{
        //    List<DML.Tecnico> lista = new List<DML.Tecnico>();
        //    if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            DML.Tecnico tec = new DML.Tecnico();
        //            tec.Id = row.Field<long>("Id");
        //            tec.CEP = row.Field<string>("CEP");
        //            tec.Cidade = row.Field<string>("Cidade");
        //            tec.Email = row.Field<string>("Email");
        //            tec.Estado = row.Field<string>("Estado");
        //            tec.Logradouro = row.Field<string>("Logradouro");
        //            tec.Nome = row.Field<string>("Nome");
        //            tec.CPF = row.Field<string>("CPF");
        //            tec.Telefone = row.Field<string>("Telefone");
        //            lista.Add(tec);
        //        }
        //    }

        //    return lista;
        //}
    }
}
