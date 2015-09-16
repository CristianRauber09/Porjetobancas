using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using PeixeiraConnection;

namespace ProjetoBancaTCC_OO2.Models
{
    public class AlunoRepositorio
    {
        public static List<Aluno> alunos = new List<Aluno>();
        Database conn = new Database();

        public IEnumerable<Aluno> getAll()
        {
            //List<Aluno> aluno = new List<Aluno>();

            string sql = "select * from alunos";
            MySqlDataReader dr = conn.executarConsulta(sql);

            while (dr.Read())
            {
                alunos.Add(new Aluno((int)dr["id"], (string)dr["nome"]));

            }
            return alunos;
        }

        public void Create(Aluno pAluno)
        {
            string sql = "insert into alunos values (";
            sql += pAluno.id + ",'" + pAluno.nome + "')";

            conn.executarComando(sql);

        }
        public Aluno GetOne(int pId)
        {
            string sql = "select * from alunos where id =" + pId;
            MySqlDataReader dr = conn.executarConsulta(sql);

            dr.Read();
            Aluno AlunoEditando = new Aluno((int)dr["id"], (string)dr["nome"]);

            return AlunoEditando;
        }
        public void Update(Aluno pAluno)
        {
            string sql = "update alunos set nome ='" + pAluno.nome + "' where id =" + pAluno.id;
            conn.executarComando(sql);
        }
        public void Delete(int pId)
        {
            string sql = "delete from alunos where id =" + pId;
            conn.executarComando(sql);
            //aluno.RemoveAt(aluno.FindIndex(x => x.Id == pId));
        }
    }
}