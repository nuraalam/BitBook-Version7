//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WallPostByTechBrij.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserProfile
    {
        public UserProfile()
        {
            this.PostComments = new HashSet<PostComment>();
            this.Posts = new HashSet<Post>();
            this.Friendships = new HashSet<Friendship>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string AvatarExt { get; set; }
    
        public virtual ICollection<PostComment> PostComments { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Friendship> Friendships { get; set; }
    }
}
