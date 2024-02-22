using System.Collections.Generic;
using System.Text;
namespace PostsComents.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int Likes { get; set; }

        public List<Comment> Comments =new List<Comment>();

        public  Post()
        {

        }

        public  Post(
            DateTime moment , string title, string content,int likes
        )
        {
            Moment=moment;
            Title=title;
            Content=content;
            Likes=likes;
        }

        public void AddComent(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComent(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {   
            // string pharse=$"{Title}\n{Likes} Likes - {Moment}\n{Content}\nComments : \n";
            // foreach (Comment comment in Comments)
            // {
            //     pharse+=comment.Text+"\n";
            // }
            // return pharse;

            // Now Using String Builder


            StringBuilder sb =new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments");
            foreach (Comment comment in Comments)
            {
                sb.AppendLine(comment.Text);
            }

            return sb.ToString();
        }
    }
}