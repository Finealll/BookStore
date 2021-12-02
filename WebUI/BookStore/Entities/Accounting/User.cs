using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Entities.BaseObjects;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities.Accounting
{
    /// <summary>
    /// Класс пользователя
    /// </summary>
    public class User : TypeObject
    {
        public User()
        {
            TypeName = nameof(User);
        }

        /// <summary>
        /// Получает или задает Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Получает или задает Дату рождения
        /// </summary>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Получает или задает День рождения пользователя
        /// </summary>
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// Получает или задает День рождения пользователя
        /// </summary>
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// Получаеи или задаеи Роль пользователя
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// Получает или задаеи Id роли
        /// </summary>
        public int? RoleId { get; set; }
    }
}
