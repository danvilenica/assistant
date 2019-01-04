using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.DB.ViewModels
{
    public class AddPlayerVM
    {
        public List<PlayerModel> Data { get; set; }
    }

    public class PlayerModel
    {
        public DataModelPlayer Data { get; set; }
    }

    public class DataModelPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string nationality { get; set; }
        public string birthdate { get; set; }
        public string birthcountry { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string image_path { get; set; }
    }
}
