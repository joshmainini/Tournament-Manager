using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Repositories
{
	public class TeamRepository<T> where T : class
	{
		private TeamDataContext context = new TeamDataContext();

		protected DbSet<T> DbSet
		{
			get; set;
		}

		public TeamRepository()
		{
			DbSet = context.Set<T>();
		}

		public List<T> GetAllTeams()
		{
			return DbSet.ToList();
		}

		public T GetTeam(int id)
		{
			return DbSet.Find(id);
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