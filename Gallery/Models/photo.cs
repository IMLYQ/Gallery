using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery.Models
{
    public class photo
    {

        /// <summary>
        /// 编号
        /// </summary>
        public int id { set; get; }

        /// <summary>
        /// 图片名称
        /// </summary>
        public string name { set; get; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string url { set; get; }
        /// <summary>
        ///拍摄时间 
        /// </summary>
        public DateTime shootingtime { set; get; }

        /// <summary>
        /// 简介
        /// </summary>
        public string content { set; get; }

        /// <summary>
        /// 所属地点的id
        /// </summary>
        public int placeID { set; get; }

        /// <summary>
        /// 一个照片对应一个地方
        /// </summary>
        public virtual place place { set; get; }
    }
}