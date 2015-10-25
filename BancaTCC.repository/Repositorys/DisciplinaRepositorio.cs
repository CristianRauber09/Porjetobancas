using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PeixeiraConnection;
using MySql.Data.MySqlClient;
using BancaTCC.core;

namespace BancaTCC.repository.Repositorys
{
    public class DisciplinaRepositorio
    {
        public static List<Disciplina> disciplinas = new List<Disciplina>();
        Database conn = new Database();

        public IEnumerable<Disciplina> getAll()
        {
            

            string sql = "select * from disciplinas";
            MySqlDataReader dr = conn.executarConsulta(sql);

            while (dr.Read())
            {
                disciplinas.Add(new Disciplina((int)dr["id"], (string)dr["nome"]));

            }
            return disciplinas;
        }

        public void Create(Disciplina pDisciplina)
        {
            string sql = "insert into disciplinas values (";
            sql += pDisciplina.id + ",'" + pDisciplina.nome + "')";

            conn.executarComando(sql);

        }
        public Disciplina GetOne(int pId)
        {
            string sql = "select * from disciplinas where id =" + pId;
            MySqlDataReader dr = conn.executarConsulta(sql);

            dr.Read();
            Disciplina dipEditando = new Disciplina((int)dr["id"], (string)dr["nome"]);

            return dipEditando;
        }
        public void Update(Aluno pAluno)
        {
            string sql = "update alunos set nome ='" + pAluno.nome + "' where id =" + pAluno.id;
            conn.executarComando(sql);
        }
        public void Delete(int pId)
        {
            string sql = "delete from disciplinas where id =" + pId;
            conn.executarComando(sql);
            
        }
    }
    }
