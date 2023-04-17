using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadDailyNews.Models;

namespace ReadDailyNews.IO
{
	public interface INewsRepository
	{
		List<Publisher> Read();

		void Save(List<Publisher> publishers );
	}
}
