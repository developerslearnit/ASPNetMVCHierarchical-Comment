using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommentSystem.Models.DTO
{
    public class commentDTO
    {
        
        public int parentId { get; set; }
        public string commentText { get; set; }
        public string username { get; set; }
    }

    public class commentViewModel : commentDTO
    {
        public int commentId { get; set; }
        public DateTime commentDate { get; set; }
        public string strCommentDate { get {; return this.commentDate.ToString("dd-MM-yyyy"); } }
    }
}