using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkShop2.Models
{
    public class BookSearch
    {
        /// <summary>
        /// 書籍編號
        /// </summary>
        ///[MaxLength(5)]
        public int BookId { get; set; }
   
        /// <summary>
        /// 書籍名稱
        /// </summary>
        [DisplayName("書名")]
        public string BookName { get; set; }    
        /// <summary>
        /// 圖書類別
        /// </summary>
        [DisplayName("圖書類別")]
        public string BookClassName { get; set; }
        /// <summary>
        /// 借閱人
        /// </summary>
        [DisplayName("借閱人")]
        public string MemberName { get; set; }
        /// <summary>
        /// 借閱狀態
        /// </summary>
        [DisplayName("借閱狀態")]
        public string BookStatus { get; set; }
    }
}