using System;
namespace CountUnivalTree
{
    public class TestData
    {
        public TestData()
        {

        }

        public static Node Tree_4()
        {

            var root = new Node(3);
            var l = root.AddLeft(2);
            var r = root.AddRight(3);

            var rr = r.AddRight(2);

            var rrl = rr.AddLeft(2);
            var rrr = rr.AddRight(2);

            return root;
        }

        public static Node Tree_5()
        {

            var root = new Node(3);
            var l = root.AddLeft(2);
            var r = root.AddRight(2);

            var rr = r.AddRight(2);
            var rl = r.AddLeft(2);

            var rrl = rr.AddLeft(2);
            var rrr = rr.AddRight(2);

            var rll = rl.AddLeft(2);
            var rllr = rll.AddRight(2);
            var rllrr = rllr.AddRight(2);

            return root;
        }

        public static Node Tree_1()
        {
            var root = new Node(1);
            root.AddRight(2).AddRight(2);
            return root;
        }

        static Node Tree_2()
        {
            var r = new Node(1);
            r.AddRight(1);
            r.AddLeft(1).AddLeft(1);

            return r;
        }
    }
}
