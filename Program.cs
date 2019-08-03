using System;
using System.Diagnostics;
namespace CountUnivalTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = CountUnival_n_solution(TestData.Tree_5()).CountSubUnival;
            Console.WriteLine(count);
        }

        // Complexity = n * complexity of IsUnival() => Total = n^2
        static int CountUnival(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            if (IsUnival(root))
            {
                return 1 + CountUnival(root.L) + CountUnival(root.R);
            }
            else
            {
                return CountUnival(root.L) + CountUnival(root.R);
            }
        }

        // Complexity = O(n)
        static bool IsUnival(Node root)
        {
            if (root == null) return true;
            if (root.L == null && root.R == null) return true;
            if (root.L != null && root.R != null)
                if (root.L.Value == root.Value && root.R.Value == root.Value)
                {
                    return IsUnival(root.L) && IsUnival(root.R);
                }
            return false;
        }

        
        class Uni
        {
            public int CountSubUnival { get; set; }
            public bool IsUnival { get; set; }

            public Uni(int count, bool isUnival)
            {
                CountSubUnival = count;
                IsUnival = isUnival;
            }
        }
        // Complexity = n
        static Uni CountUnival_n_solution(Node r)
        {
            if (r == null) return new Uni(0, true);

            var isUnival = false;

            var leftUni = CountUnival_n_solution(r.L);
            var rightUni = CountUnival_n_solution(r.R);

            if (r.L == null && r.R == null)
                isUnival = true;

            if (r.L != null && r.R != null && r.Value == r.L.Value && r.Value == r.R.Value)
                if (leftUni.IsUnival && rightUni.IsUnival)
                    isUnival = true;


            if (isUnival)
                return new Uni(leftUni.CountSubUnival + rightUni.CountSubUnival + 1, true);
            else
                return new Uni(leftUni.CountSubUnival + rightUni.CountSubUnival, false);
        }
    }
}
