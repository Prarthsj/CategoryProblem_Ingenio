using System;
using System.Collections.Generic;

namespace Ingenio_CategoryProblem
{
    class Program
    {
        private static int categoryId;
        private static int parent;
        private static string name;
        private static string keywords;
        private static List<Data> nodesList = new List<Data>(); 
        private static Data GenerateTree()
        {
            Data root = new Data(0, new Category());
            root.Left = new Data(100, new Category(100, -1, "Business", "Money"));
            root.Left.Left = new Data(101, new Category(101, 100, "Accounting", "Taxes"));
            root.Left.Right = new Data(102, new Category(102, 100, "Taxation", string.Empty));
            root.Left.Left.Left = new Data(103, new Category(103, 101, "Corporate Tax", string.Empty));
            root.Left.Left.Right = new Data(109, new Category(109, 101, "Small business Tax", string.Empty));
            root.Right = new Data(200, new Category(200, -1, "Tutoring", "Teaching"));
            root.Right.Left = new Data(201, new Category(201, 200, "Computer", string.Empty));
            root.Right.Left.Left = new Data(202, new Category(202, 201, "Operating System", string.Empty));
            // Root node.
            return root;
        }

        private static void Main()
        {
            Data rootNode = GenerateTree();
            Console.WriteLine("1st problem Sample Input/Output: Input a Category id");
            #region first question
            string key = Console.ReadLine();
            if (int.TryParse(key, out int value))
            {
                SearchByCategoryId(rootNode, value);
            }
            #endregion

            #region Nth level

            Console.WriteLine("2nd problem Sample Input/Output: Input a level");

            string level = Console.ReadLine();
            if (int.TryParse(level, out int nth))
            {
                GetNodesInLevel(rootNode, nth);

                foreach (var item in nodesList)
                {
                    Console.WriteLine("CatId: {0}, Name:{1} ", item.Key, item.Category.Name);
                }
            }


            #endregion
            Console.ReadLine();
        }

        /// <summary>
        /// Search by category Id over the Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="tarjet"></param>
        /// <returns></returns>
        private static bool SearchByCategoryId(Data root, int tarjet)
        {
            if (root == null)
                return false;

            if (root.Key == tarjet)
            {
                categoryId = root.Category.CategoryId;
                parent = root.Category.ParentCategoryId;
                name = root.Category.Name;
                keywords = root.Category.Keywords;
                return true;
            }

            //check bouth (left and right).
            if (SearchByCategoryId(root.Left, tarjet) || SearchByCategoryId(root.Right, tarjet))
            {
                if (root.Key != 0)// not consider Zero node.
                {
                    // Console.WriteLine("parent {0} ", root.Key);

                    if (string.IsNullOrEmpty(keywords) && !string.IsNullOrEmpty(root.Category.Keywords))
                    {
                        //set values for Keywords from Parent.
                        keywords = root.Category.Keywords;
                    }

                    return true;
                }
                Console.WriteLine("{0} {1} {2} {3}", categoryId, parent, name, keywords);

            }

            return false;
        }
        private static void GetNodesInLevel(Data root, int level)
        {
            if (root == null || level < 0)
                return;
            if (level == 0)
                nodesList.Add(root);
            if (root.Left != null)
                GetNodesInLevel(root.Left, level - 1);
            if (root.Right != null)
                GetNodesInLevel(root.Right, level - 1);
        }

    }
}
