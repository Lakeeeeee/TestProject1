namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }

    public class Test8
    {
        //�����@�ӯZ�Ū��ǥ�
        //�ШD�X�����q�Ҧ��Z��������(�|�ˤ��J��p���I��ĤG��)���Ĥ@�W������ǥ�
        //�Ц^�ǸӦ�ǥͬ�����

        public Member test(List<Member> members)
        {
            return null;
        }
    }

    public class Member
    {
        public string _name;
        public int[] _scores;

        public Member(string name, int[] scores)
        {
            _name = name;
            _scores = scores;
        }
    }


    public class Test6
    {
        public Point[] test(Point[] points)
        {
            int pointCount = points.Length;
            //New�@�Ӱ}�C���� - 1���s�}�C distanceMap
            for (int i = 0; i < pointCount - 1; i++)
            {
                int maxDistance = 0;
                for (int j = 1; j < pointCount; j++)//��᭱�}�C����
                {
                    //
                    double distance = calDistance(points[i], points[j]);
                    //��j�p ��smaxDistance 
                }
            };

            Point[] ansPoints = new Point[2];
            ansPoints[1] = new Point(1, 7);
            ansPoints[0] = new Point(5, 1);
            return ansPoints;
        }
        private double calDistance(Point p1, Point p2)
        {
            var r = (p1._x - p2._x) * (p1._x - p2._x) + (p1._y - p2._y) * (p1._y - p2._y);
            double distance = Math.Sqrt(r);
            return distance;
        }
    }
    public class Point
    {
        public int _x;
        public int _y;
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public int getX()
        {
            return _x;
        }
        public int getY()
        {
            return _y;
        }
        public override bool Equals(object obj)
        {
            var input = obj as Point;
            if (input == null)
            {
                return false;
            }
            else
            {
                return (_x == input._x) && (_y == input._y);
            }
        }
        public override int GetHashCode() { return 0; }
    }

}