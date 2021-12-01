using GestionLivre;
using System.Collections.Generic;


    public class Livreservice 
	{
		private IDAOLivre daolivre;
		public Livreservice(IDAOLivre daolivre)
		{
			this.daolivre = daolivre;
		}
		public List<Livre> GetLivre(string id)
		{
			return daolivre.GetLivre(id);
		}

	}
