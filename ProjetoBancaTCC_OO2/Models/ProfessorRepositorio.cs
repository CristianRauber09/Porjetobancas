using MySql.Data.MySqlClient;
using PeixeiraConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBancaTCC_OO2.Models
{
    public class ProfessorRepositorio
    {
        public static List<Professor> professores = new List<Professor>();
        Database conn = new Database();

        public IEnumerable<Professor> getAll()
        {


            string sql = "select * from professores";
            MySqlDataReader dr = conn.executarConsulta(sql);

            while (dr.Read())
            {
                professores.Add(new Professor((int)dr["id"], (string)dr["nome"]));

            }
            return professores;
        }

        public void Create(Professor pProfessor)
        {
            string sql = "insert into professores values (";
            sql += pProfessor.id + ",'" + pProfessor.nome + "')";

            conn.executarComando(sql);

        }
        public Professor GetOne(int pId)
        {
            string sql = "select * from professores where id =" + pId;
            MySqlDataReader dr = conn.executarConsulta(sql);

            dr.Read();
            Professor profEditando = new Professor((int)dr["id"], (string)dr["nome"]);

            return profEditando;
        }
        public void Update(Professor pProfessor)
        {
            string sql = "update professores set nome ='" + pProfessor.nome + "' where id =" + pProfessor.id;
            conn.executarComando(sql);
        }
        public void Delete(int pId)
        {
            string sql = "delete from professores where id =" + pId;
            conn.executarComando(sql);

        }
    }
}