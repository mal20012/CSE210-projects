using System;

public class Video{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comment = List <Comment>();

    public Video(string title, string author, double length){
        _title = title;
        _author = author;
        _length = length;
    }
    public void ListComment(Comment comment){
        _comments.Add(comment);
    }
     public int CountComments()
    {
        int count = 0;
        count = _comments.Count;
        return count;
    }
    public void DisplayVideo(){
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} seconds");
        Console.WriteLine();
        int commentCount = CountComments();
        Console.WriteLine($"Number of comments: {commentCount}");
        foreach (Comment comment in _comments){
            comment.DisplayVideo();
        }
    }
}

