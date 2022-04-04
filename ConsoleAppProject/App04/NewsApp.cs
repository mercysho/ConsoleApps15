using System;
using System.Net.Http.Headers;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;

public class NewsApp
    {

        private NewsFeed news = new NewsFeed();

        public NewsFeed NewsFeed
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// This method shows a display menu for users to select from the choices below
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("\t\t Mercy's News Feed");

            Console.ForegroundColor = ConsoleColor.Blue;

            string[] choices = new string[]
            {
                "Post Message",
                "Post Image",
                "Remove Post",
                "Display All Posts",
                "Add Comment to Post",
                "Like/Unlike Post",
                "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1:
                        PostMessage();
                        break;
                    case 2:
                        PostImage();
                        break;
                    case 3:
                        RemovePost();
                        break;
                    case 4:
                        DisplayAll();
                        break;
                    case 5 :
                        AddComment();
                        break;
                    case 6:
                        LikePosts();
                        break;
                    case 7:
                        wantToQuit = true;
                        break;
                }
            }
            while (!wantToQuit);
        }

        /// <summary>
        /// This is a method to add likes to the post
        /// </summary>
        private void LikePosts()
        {
            ConsoleHelper.OutputTitle("Like or Unlike a Post");
            int id = (int)ConsoleHelper.InputNumber("Please enter the post id > ", 1, Post.GetNumberOfPosts());
            
            Console.WriteLine("Do you want to (like) or (unlike) the post? > ");
            string choices = Console.ReadLine();

            switch (choices)
            {
                case "like":
                    Console.WriteLine("Like a post\n");
                    news.LikePost(id);
                    break;
                case "unlike":
                    Console.WriteLine("Unlike a post\n");
                    news.UnlikePost(id);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try Again.");
                    LikePosts();
                    break;
            }

        }

        /// <summary>
        /// This is a method to add comments to the post
        /// </summary>
        private void AddComment()
        {
            ConsoleHelper.OutputTitle("Add a comment to a Post");
            int id = (int)ConsoleHelper.InputNumber("Please enter the post id > ", 1, Post.GetNumberOfPosts());
            
            Console.WriteLine("Enter the comment you want to add > ");
            string comment = Console.ReadLine();
            news.AddPost(id, comment);
        }
        
        private void DisplayByAuthor()
        {
            Console.WriteLine("Enter the name of user you want to display > ");
            string author = Console.ReadLine();
            
        }

        /// <summary>
        /// This method will display the all the posts made by the user
        /// </summary>
        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// This method can remove all the posted messages in the news feed
       /// </summary>
        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a Post");

            int id = (int)ConsoleHelper.InputNumber("Please enter post id > ", 1, Post.GetNumberOfPosts());

           
        }
        
        private void PostImage()
        {
             ConsoleHelper.OutputTitle("Posting an Image/Photo");
             
             string author = InputName();

             Console.WriteLine("Please enter your image file name > ");
             string filename = Console.ReadLine();

             Console.WriteLine("Please enter your image caption > ");
             string caption = Console.ReadLine();

             PhotoPost post = new PhotoPost(author, filename, caption);
             news.AddPhotoPost(post);

             ConsoleHelper.OutputTitle("You have just posted this image:");
             post.Display();
        }
        
        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting an Message");
           
            string author = InputName();

            Console.WriteLine("Please enter your Message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddPost(post);

            ConsoleHelper.OutputTitle("You have just posted this message:");
            post.Display();
        }

        /// <summary>
        /// This method inputs the authors name
        /// </summary>
        private string InputName()
        {
            Console.Write("Please enter your name > ");
            string author = Console.ReadLine();
            
            return author;
        }
      
    }

public class NewsFeed
{
    public void AddPost(int id, string comment)
    {
        throw new NotImplementedException();
    }

    public void AddPhotoPost(PhotoPost post)
    {
        throw new NotImplementedException();
    }
    

    public void Display()
    {
        throw new NotImplementedException();
    }

    public void AddPost(MessagePost post)
    {
        throw new NotImplementedException();
    }

    public void LikePost(int id)
    {
        throw new NotImplementedException();
    }

    public void UnlikePost(int id)
    {
        throw new NotImplementedException();
    }
}

