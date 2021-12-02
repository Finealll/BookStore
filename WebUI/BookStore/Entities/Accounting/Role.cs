using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Entities.BaseObjects;

namespace BookStore.Entities.Accounting
{
    public class Role : DictObject
    {
        /// <summary>
        /// Получает или задает спискок пользователей
        /// </summary>
        public List<User> Users { get; set; }
        public Role()
        {
            Users = new List<User>();
        }
    }
}
