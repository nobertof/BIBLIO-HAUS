using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblio_haus.Models
{
    public class tbUsuarios
    {
        //campos do model de usuarios
        public int tbUsuarios_id {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public string Cargo {get;set;}
        public string Status {get;set;}
        public List<tbEmprestimos> Emprestimos {get;set;}
        public List<tbFichamentos> Fichamentos {get;set;}
    }
}