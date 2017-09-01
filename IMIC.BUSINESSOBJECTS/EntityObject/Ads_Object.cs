using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.BUSINESSOBJECTS.EntityObject
{
    public class Ads_Object
    {
        public System.Guid AdsID { get; set; }
        public string Icon { get; set; }
        public string Tittle { get; set; }
        public string Image { get; set; }
        public Nullable<int> Rank { get; set; }
        public string Content { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Position { get; set; }
        public string TrangThai { get; set; }
        public string Link { get; set; }

        public bool ImageFlag { get; set; }
    }
}
