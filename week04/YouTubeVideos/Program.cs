using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("How to Program in C# from Scratch", "Carlos Silva", 300);
        List<Comment> comments1 = new List<Comment>();

        comments1.Add(new Comment("Sofia Rocha", "Excellent video! The explanations are clear and easy to follow."));
        comments1.Add(new Comment("Pedro Lima", "Very good, Carlos! It helped me understand the basic programming concepts."));     
        comments1.Add(new Comment("Juliana Oliveira", "I wish there was an explanation about classes and objects, but the video was great."));     
        comments1.Add(new Comment("Lucas Costa", "I loved the content! I just thought the pace was a bit fast in some parts."));

        Video video2 = new Video("Introduction to Interface Design", "Fernanda Almeida", 270 );
        List<Comment> comments2 = new List<Comment>();

        comments2.Add(new Comment("Ricardo Pereira", "Very good! Now I know how to create more user-friendly interfaces."));
        comments2.Add(new Comment( "Camila Santos", "I loved the accessibility tips. I'll apply them to my project."));
        comments2.Add(new Comment("Eduardo Martins", "The video is great, but the section on colors could have been more detailed."));
        comments2.Add(new Comment("Paula Mendes", "I liked the practical example at the end, it made the understanding easier."));

         Video video3 = new Video("Data Structures in C++", "João Barbosa", 350 );
        List<Comment> comments3 = new List<Comment>();

        comments3.Add(new Comment("Marcos Silva", "The video was great, but it could have shown more code examples."));
        comments3.Add(new Comment("Tatiane Costa", "Clear explanations, but the audio was a bit low in some parts."));
        comments3.Add(new Comment( "Lucas Almeida", "I'm just starting to learn C++, and this video was a great introduction!"));
        comments3.Add(new Comment("Gabriela Pereira", "I found the explanation about linked lists interesting, I never really understood it"));

         Video video4 = new Video("How to Create a Responsive Website with HTML and CSS", "Felipe Martins", 320 );
        List<Comment> comments4 = new List<Comment>();

        comments4.Add(new Comment("Sofia Rocha", "Perfect! Now I know how to create a layout that works well on any device."));
        comments4.Add(new Comment("Ricardo Souza", "I liked the section on media queries, but it would have been good to see more practical examples."));
        comments4.Add(new Comment( "Mariana Costa", "I loved the video! I will try to apply the tips to my next project."));
        comments4.Add(new Comment("André Silva", "There should have been an explanation of Flexbox properties, but overall it was excellent."));
        

        Console.WriteLine(video1.GetVideo());
        Console.WriteLine($"Total: {comments1.Count}");
        foreach (Comment comment in comments1)
        {
            Console.WriteLine(comment.GetCommentary());
        }

        Console.WriteLine(video2.GetVideo());
        Console.WriteLine($"Total: {comments2.Count}");
        foreach (Comment comment in comments2)
        {
            Console.WriteLine(comment.GetCommentary());
        }

        Console.WriteLine(video3.GetVideo());
        Console.WriteLine($"Total: {comments3.Count}");
        foreach (Comment comment in comments3)
        {
            Console.WriteLine(comment.GetCommentary());
        }

        Console.WriteLine(video4.GetVideo());
        Console.WriteLine($"Total: {comments4.Count}");
        foreach (Comment comment in comments4)
        {
            Console.WriteLine(comment.GetCommentary());
        }
    }
}