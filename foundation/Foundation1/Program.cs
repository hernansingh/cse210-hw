using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Emily Rivers", "The Art of Landscape Photography", 720);
        video1.AddComment("John Doe", "This was incredibly helpful! Thanks for sharing your tips!");
        video1.AddComment("Sarah Lee", "I love the way you captured the essence of nature. Amazing!");
        video1.AddComment("Alex Green", "Could you make a video on night photography next?");

        Video video2 = new Video("FitLife Studio", "10-Minute Yoga for Beginners", 600);
        video2.AddComment("Rachel Kim", "This routine is perfect for my busy mornings. Thank you!");
        video2.AddComment("Michael Brooks", "Can you do one for back pain relief? Great content!");
        video2.AddComment("Sophia Adams", "I’ve been trying this every day, and it’s made a big difference. Thanks!");

        Video video3 = new Video("HomeGlow Designs", "DIY Home Office Makeover", 900);
        video3.AddComment("Chris Taylor", "Your ideas are so creative! I’m inspired to revamp my space.");
        video3.AddComment("Ella Jordan", "This is exactly what I needed! My home office looks so dull.");
        video3.AddComment("Jake Benson", "Can you share links to the items you used? Thanks!");

        video1.PrintVideoDetails();
        video2.PrintVideoDetails();
        video3.PrintVideoDetails();
    }
}