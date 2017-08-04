using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Repositories
{
	public class TournamentRepository<T> where T : class
	{
		private TournamentDataContext context = new TournamentDataContext();

		protected DbSet<T> DbSet
		{
			get; set;
		}

		public TournamentRepository()
		{
			DbSet = context.Set<T>();
		}

		public List<T> GetAll()
		{
			return DbSet.ToList();
		}

		public T GetTournament(int id)
		{
			return DbSet.Find(id);
		}

		public List<Tournament> GetTournamentsByName(string name)
		{
			return DbSet.Where(a => a.Name.Contains(name)).ToList();
			
		}

		public void Add(T entity)
		{
			DbSet.Add(entity);
		}

		public void Delete(T entity)
		{
			DbSet.Remove(entity);
		}

		public void SaveChanges()
		{
			context.SaveChanges();
		}
	}
}