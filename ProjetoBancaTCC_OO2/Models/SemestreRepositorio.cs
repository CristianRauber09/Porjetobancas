using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PeixeiraConnection;
using ProjetoBancaTCC_OO2.Models;
using MySql.Data.MySqlClient;

namespace ProjetoBancaTCC_OO2.Models
{
    public class SemestreRepositorio
    {
        public static List<Semestre> semestres = new List<Semestre>();
        Database conn = new Database();

        public IEnumerable<Semestre> getAll()
        {
           

            string sql = "select * from semestres";
            MySqlDataReader dr = conn.executarConsulta(sql);

            while (dr.Read())
            {
                semestres.Add(new Semestre((int)dr["id"], (string)dr["nome"]));

            }
            return semestres;
        }

        public void Create(Semestre pSemestre)
        {
            string sql = "insert into semestres values (";
            sql += pSemestre.id + ",'" + pSemestre.nome + "')";

            conn.executarComando(sql);

        }
        public Semestre GetOne(int pId)
        {
            string sql = "select * from semestres where id =" + pId;
            MySqlDataReader dr = conn.executarConsulta(sql);

            dr.Read();
            Semestre semEditando = new Semestre((int)dr["id"], (string)dr["nome"]);

            return semEditando;
        }
        public void Update(Semestre pSemestre)
        {
            string sql = "update semestres set nome ='" + pSemestre.nome + "' where id =" + pSemestre.id;
            conn.executarComando(sql);
        }
        public void Delete(int pId)
        {
            string sql = "delete from semestres where id =" + pId;
            conn.executarComando(sql);
           
        }
    }
}