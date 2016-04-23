﻿namespace MvcEssentials.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using MvcEssentials.Data.Common.Models;

    public class File : BaseModel<int>
    {
        [StringLength(255)]
        public string FileName { get; set; }

        [StringLength(100)]
        public string ContentType { get; set; }

        public byte[] Content { get; set; }

        public int NewsArticleId { get; set; }

        [Required]
        public virtual NewsArticle NewsArticle { get; set; }
    }
}
