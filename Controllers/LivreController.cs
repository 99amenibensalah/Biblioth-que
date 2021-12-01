using GestionLivre;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace bibliotheque.Controllers
{

    [ApiController]
    [Route("api/livre")]
    public class LivreController : Controller
    {
        private Livreservice livreservice;
        public LivreController(Livreservice livreservice)
        {
            this.livreservice = livreservice;
        }
        private List<Livre> Livre = new List<Livre>
        {
          new Livre( "1",  "les miserables"  ),
        new Livre( "2",  "Paul " ),
         new Livre( "3",  "La vie" )
};

        public List<Livre> GetLivre()
        {
            return Livre;
        }
        [HttpGet("{id}")]
        public Livre GetBook(String id)
        {
            return livreservice.GetLivre(id).First();
        }

    }
}