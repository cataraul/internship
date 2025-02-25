﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TweetBook.Domain
{
    public class PostTag
    {
       [ForeignKey(nameof(TagName))]
       public  virtual Tag Tag { get; set; }

       public string TagName { get; set; }

       [ForeignKey(nameof(PostId))]
       public  virtual Post Post { get; set; }

       public Guid PostId { get; set; }
    }
}
