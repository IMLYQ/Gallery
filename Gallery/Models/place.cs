using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery.Models
{
    public class place
    {
        /// <summary>
        /// ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 地方名称
        /// </summary>
        public string placename { get; set; }

        /// <summary>
        /// 一个地方有多幅照片 
        /// </summary>
        public virtual ICollection<photo> photos { get; set; }
    }
}