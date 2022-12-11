namespace TreeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            BinarySearchTree tree = new BinarySearchTree();

            bool UseSort = true; //can change from using the original file or using a sorted file


            tree.CanSort(UseSort);

            //Inserting every data into the tree from the file
            for(int i = 0; i < tree.sort.ScoreData.Count; i++) 
            {
                tree.Insert(i);
            }
            
            Console.WriteLine("InOrder:");
            tree.InOrder(tree.ReturnNode());
            NextPart();

            Console.WriteLine("PreOrder:");
            tree.PreOrder(tree.ReturnNode());
            NextPart();

            Console.WriteLine("PostOrder:");
            tree.PostOrder(tree.ReturnNode());
           
        }

        //Only serves for the console to clear the screen after a key has been pressed
        public static void NextPart()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}